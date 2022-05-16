FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS dotnet-build-base
WORKDIR /src
RUN apt-get update && apt-get install curl -y \
  && curl -sL https://deb.nodesource.com/setup_14.x | bash -\
  && apt-get install nodejs -y
COPY azuremyst.sln .
COPY Directory.* .
COPY src/**/*.csproj ./
RUN for file in $(ls *.csproj); do mkdir -p src/${file%.*}/ && mv $file src/${file%.*}/; done
RUN dotnet restore azuremyst.sln
COPY . . 

FROM dotnet-build-base AS dotnet-build
RUN dotnet build -c Debug --no-restore azuremyst.sln

FROM dotnet-build AS dotnet-test
RUN dotnet test -c Debug --no-build --no-restore azuremyst.sln

FROM dotnet-build AS publish
RUN dotnet publish -c Debug --no-build --no-restore -o /app  src/azuremyst/azuremyst.csproj

FROM base AS final
COPY --from=publish /app .
COPY --from=publish /src/scripts/healthcheck.sh .
COPY --from=publish /src/src/db/ACID/acid_tbc.sql .
ENTRYPOINT ["dotnet", "azuremyst.dll"]
 