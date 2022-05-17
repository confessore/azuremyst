#!/bin/sh

if mysql -h mariadb -uazuremyst -pazuremyst -e "USE azuremyst.realmd"; then echo "exists"; fi
/azuremyst/src/mangos/run/bin/realmd -c /azuremyst/src/mangos/run/etc/realmd.conf
