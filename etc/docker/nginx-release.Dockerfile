FROM ubuntu:20.04
RUN apt-get update -y
RUN apt-get install -y nginx
COPY etc/nginx/nginx-release.conf ./etc/nginx/nginx.conf
COPY scripts/nginx-entrypoint-release.sh .
RUN chmod +x ./nginx-entrypoint-release.sh
ENTRYPOINT ["./nginx-entrypoint-release.sh"]