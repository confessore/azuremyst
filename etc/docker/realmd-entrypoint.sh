#!/bin/sh

sed -i "s/{{MYSQL_USER}}/$MYSQL_USER/g" /azuremyst/src/mangos/run/etc/realmd.conf
sed -i "s/{{MYSQL_PASSWORD}}/$MYSQL_PASSWORD/g" /azuremyst/src/mangos/run/etc/realmd.conf

/azuremyst/src/mangos/run/bin/realmd -c /azuremyst/src/mangos/run/etc/realmd.conf