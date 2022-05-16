#!/bin/sh
mysql -u azuremyst -p azuremyst mangosd <<EOSQL
SELECT * FROM db_version ORDER BY VERSION DESC, structure DESC, content DESC LIMIT 0,1;
exit;
EOSQL
/azuremyst/src/mangos/run/bin/realmd -c /azuremyst/src/mangos/run/etc/realmd.conf