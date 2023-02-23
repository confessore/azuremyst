#!/bin/sh

mysql -s -N -h db -uroot -p$MYSQL_ROOT_PASSWORD -e "GRANT ALL PRIVILEGES ON *.* TO '$MYSQL_USER'@'%';"
mysql -s -N -h db -uroot -p$MYSQL_ROOT_PASSWORD -e "FLUSH PRIVILEGES;"

result=$(mysql -s -N -u$MYSQL_USER -p$MYSQL_PASSWORD -h db -e "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME='azuremyst.logs';");
if [ -z "$result" ];
then
echo "logs db does not exist";
mysql -s -N -h db -u$MYSQL_USER -p$MYSQL_PASSWORD -e "CREATE DATABASE IF NOT EXISTS \`azuremyst.logs\`;"
mysql -s -N -h db -u$MYSQL_USER -p$MYSQL_PASSWORD azuremyst.logs < /azuremyst/src/mangos/sql/base/logs.sql
echo "logs db created and based";
fi

result=$(mysql -s -N -h db -u$MYSQL_USER -p$MYSQL_PASSWORD -e "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME='azuremyst.realmd';");
if [ -z "$result" ];
then
echo "realmd db does not exist";
mysql -s -N -h db -u$MYSQL_USER -p$MYSQL_PASSWORD -e "CREATE DATABASE IF NOT EXISTS \`azuremyst.realmd\`;"
mysql -s -N -h db -u$MYSQL_USER -p$MYSQL_PASSWORD azuremyst.realmd < /azuremyst/src/mangos/sql/base/realmd.sql
echo "realmd db created and based";
fi

result=$(mysql -s -N -h db -u$MYSQL_USER -p$MYSQL_PASSWORD -e "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME='azuremyst.character';");
if [ -z "$result" ];
then
echo "character db does not exist";
mysql -s -N -h db -u$MYSQL_USER -p$MYSQL_PASSWORD -e "CREATE DATABASE IF NOT EXISTS \`azuremyst.character\`;"
mysql -s -N -h db -u$MYSQL_USER -p$MYSQL_PASSWORD azuremyst.character < /azuremyst/src/mangos/sql/base/characters.sql
echo "character db created and based";
fi

result=$(mysql -s -N -h db -u$MYSQL_USER -p$MYSQL_PASSWORD -e "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME='azuremyst.mangos';");
if [ -z "$result" ];
then
echo "mangos db does not exist";
mysql -s -N -h db -u$MYSQL_USER -p$MYSQL_PASSWORD -e "CREATE DATABASE IF NOT EXISTS \`azuremyst.mangos\`;"
mysql -s -N -h db -u$MYSQL_USER -p$MYSQL_PASSWORD azuremyst.mangos < /azuremyst/src/mangos/sql/base/mangos.sql
cd /azuremyst/src/db && bash ./InstallFullDB.sh -World && cd
echo "mangos db created and based";
fi

/azuremyst/src/mangos/run/bin/mangosd -c /azuremyst/src/mangos/run/etc/mangosd.conf