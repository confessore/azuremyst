#syntax=docker/dockerfile:1.2

#================================================================
#
# base: the base image from which we will build our containers
#
#=================================================================

FROM ubuntu:20.04 as base

ARG USER_ID=1000
ARG GROUP_ID=1000
ARG DOCKER_USER=mangos

LABEL description="base image for containers"

ENV DOCKER=1

# list of timezones: http://en.wikipedia.org/wiki/List_of_tz_database_time_zones
# set timezone environment variable
ENV TZ=Etc/UTC

# set noninteractive mode so tzdata doesn't ask to set timezone on install
ENV DEBIAN_FRONTEND=noninteractive

# create a non-root user
RUN addgroup --gid $GROUP_ID $DOCKER_USER && \
    adduser --disabled-password --gecos '' --uid $USER_ID --gid $GROUP_ID $DOCKER_USER && \
    passwd -d $DOCKER_USER && \
    echo '$DOCKER_USER ALL=(ALL:ALL) NOPASSWD: ALL' >> /etc/sudoers

# install dependencies
RUN rm -f /etc/apt/apt.conf.d/docker-clean
RUN --mount=type=cache,target=/var/cache/apt apt update && apt install -y build-essential gcc g++ \
    automake git-core autoconf make patch libmysql++-dev \
    mysql-server libtool libssl-dev grep binutils zlibc \
    libbz2-dev cmake libboost-all-dev && rm -rf /var/lib/apt/lists/*

# change timezone in container
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone && dpkg-reconfigure --frontend noninteractive tzdata

COPY --chown=$DOCKER_USER:$DOCKER_USER . /azuremyst

USER $DOCKER_USER

WORKDIR /azuremyst

#================================================================
#
# dev: dev container
#
#=================================================================

FROM base as dev

LABEL description="dev image for dev containers"

#================================================================
#
# base: the base image from which we will build our containers
#
#=================================================================

FROM ubuntu:20.04 as servicebase

ARG USER_ID=1000
ARG GROUP_ID=1000
ARG DOCKER_USER=mangos

LABEL description="servicebase image for containers"

ENV DOCKER=1

# list of timezones: http://en.wikipedia.org/wiki/List_of_tz_database_time_zones
# set timezone environment variable
ENV TZ=Etc/UTC

# set noninteractive mode so tzdata doesn't ask to set timezone on install
ENV DEBIAN_FRONTEND=noninteractive

# create a non-root user
RUN addgroup --gid $GROUP_ID $DOCKER_USER && \
    adduser --disabled-password --gecos '' --uid $USER_ID --gid $GROUP_ID $DOCKER_USER && \
    passwd -d $DOCKER_USER && \
    echo '$DOCKER_USER ALL=(ALL:ALL) NOPASSWD: ALL' >> /etc/sudoers

# install dependencies
RUN rm -f /etc/apt/apt.conf.d/docker-clean
RUN --mount=type=cache,target=/var/cache/apt apt update && apt install -y build-essential gcc g++ \
    automake git-core autoconf make patch libmysql++-dev \
    mysql-server libtool libssl-dev grep binutils zlibc \
    libbz2-dev cmake libboost-all-dev && rm -rf /var/lib/apt/lists/*

# change timezone in container
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone && dpkg-reconfigure --frontend noninteractive tzdata

USER $DOCKER_USER

WORKDIR /azuremyst

#================================================================
#
# build: compile source
#
#=================================================================

FROM base as build

ARG DOCKER_USER=mangos

RUN mkdir -p /azuremyst/src/mangos/build
RUN --mount=type=cache,target=/azuremyst/src/mangos/build,uid=1000,gid=1000 \
    cd /azuremyst/src/mangos/build && \
    cmake ../ -DCMAKE_INSTALL_PREFIX=\../run -DPCH=1 -DDEBUG=0 -DBUILD_PLAYERBOT=OFF && \
    make install -j8

WORKDIR /azuremyst

#================================================================
#
# auth service: create a ready-to-use authserver image
# with binaries included
#
#=================================================================
FROM servicebase as realmd

LABEL description="authserver"

ARG DOCKER_USER=mangos

COPY --chown=$DOCKER_USER:$DOCKER_USER --from=build /azuremyst/etc/mangos/realmd.conf /azuremyst/src/mangos/run/etc/realmd.conf
COPY --chown=$DOCKER_USER:$DOCKER_USER --from=build /azuremyst/src/mangos/run/bin/realmd /azuremyst/src/mangos/run/bin/realmd
COPY --chown=$DOCKER_USER:$DOCKER_USER --from=build /azuremyst/scripts/realmd-entrypoint-debug.sh /azuremyst/scripts/realmd-entrypoint-debug.sh

ENTRYPOINT ["/azuremyst/scripts/realmd-entrypoint-debug.sh"]

#================================================================
#
# world service: create a ready-to-use worldserver image
# with binaries and data included
#
#=================================================================
FROM servicebase as mangosd

LABEL description="worldserver"

ARG DOCKER_USER=mangos

COPY --chown=$DOCKER_USER:$DOCKER_USER --from=build /azuremyst/etc/mangos/mangosd.conf /azuremyst/src/mangos/run/etc/mangosd.conf
COPY --chown=$DOCKER_USER:$DOCKER_USER --from=build /azuremyst/src/mangos/run/bin/mangosd /azuremyst/src/mangos/run/bin/mangosd
COPY --chown=$DOCKER_USER:$DOCKER_USER --from=build /azuremyst/scripts/mangosd-entrypoint-debug.sh /azuremyst/scripts/mangosd-entrypoint-debug.sh

ENTRYPOINT ["/azuremyst/scripts/mangosd-entrypoint-debug.sh"]