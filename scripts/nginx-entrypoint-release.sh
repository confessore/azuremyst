#!/bin/sh

if [ ! -f /etc/letsencrypt/options-ssl-nginx.conf ]
then
    nginx
    echo "Generating SSL Certificate..."
    certbot certonly \
        -n \
        --nginx \
        --register-unsafely-without-email \
        --agree-tos \
        -d azuremy.st \
        -d www.azuremy.st
    echo "SSL Certificate Generated!"
    echo "Reloading NGINX..."
    nginx -t && nginx -s reload
    echo "NGINX Reloaded!"
    service nginx stop
fi
echo "Scheduling Cron Job..."
echo "0 23 * * * root certbot -q renew --pre-hook='systemctl stop nginx' --post-hook='systemctl start nginx'" | crontab -
echo "Cron Job Scheduled!"
nginx -g 'daemon off;'
