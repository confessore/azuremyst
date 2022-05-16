FROM ubuntu:20.04
RUN apt-get update -y
RUN apt-get install -y nginx
COPY etc/nginx/nginx-staging.conf ./etc/nginx/nginx.conf
COPY scripts/nginx-entrypoint-staging.sh .
RUN chmod +x ./nginx-entrypoint-staging.sh
ENTRYPOINT ["./nginx-entrypoint-staging.sh"]