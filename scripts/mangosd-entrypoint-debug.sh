#!/bin/sh

if mysql -h mariadb -uazuremyst -pazuremyst -e "USE azuremyst.mangos"; then echo "exists"; fi
/azuremyst/src/mangos/run/bin/mangosd -c /azuremyst/src/mangos/run/etc/mangosd.conf