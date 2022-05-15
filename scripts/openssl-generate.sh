#!/bin/sh

if [ "$(dirname $0)" = "." ]
then
    cd ../src/azuremyst/etc/openssl
else
    parent=$(dirname $(dirname "$0"))
    cd "$parent"/src/azuremyst/etc/openssl
fi
openssl req -x509 -nodes -days 365 -newkey rsa:4096 -keyout localhost.key -out localhost.crt -config localhost.conf -passin pass:root
openssl pkcs12 -export -out localhost.pfx -inkey localhost.key -in localhost.crt -passout pass:root