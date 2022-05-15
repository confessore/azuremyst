#!/bin/sh

echo "Copying Config..."
cp /nginx-staging.conf /etc/nginx/nginx.conf
echo "Config Copied!"
nginx -g 'daemon off;'
