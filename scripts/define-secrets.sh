#!/bin/sh

read -p "please enter the discord client id: " discordClientId
read -p "please enter the discord secret id: " discordSecretId
read -p "please enter the discord bot token: " discordBotToken
read -p "please enter the sql server address (example - 'mariadb' for docker-compose): " sqlServer
read -p "please enter the sql root password: " sqlPasswordRoot
read -p "please enter the sql username (example - 'root'): " sqlUsername
read -p "please enter the sql password: " sqlPassword
read -p "please enter the sql database name (example - 'justchooseanydbname'): " sqlDatabase
read -p "please enter the smtp host address (example -'mail.privateemail.com' for namecheap): " smtpHost
read -p "please enter the smtp port (example - '465' for namecheap): " smtpPort
read -p "please enter the smtp username (example 'noreply@example.com'): " smtpUsername
read -p "please enter the smtp password: " smtpPassword
read -p "please enter the smtp from name (example - 'Elon Musk'): " smtpFromName
read -p "please enter the smtp from address (example - 'noreply@example.com'): " smtpFromAddress
if [ "$(dirname $0)" = "." ]
then
    cd ../secrets
else
    parent=$(dirname $(dirname "$0"))
    cd "$parent"/secrets
fi
echo "generating secrets..."
echo "$discordClientId" > discord-clientid
echo "$discordSecretId" > discord-secretid
echo "$discordBotToken" > discord-bottoken
echo "$sqlServer" > sql-server
echo "$sqlPasswordRoot" > sql-password-root
echo "$sqlUsername" > sql-username
echo "$sqlPassword" > sql-password
echo "$sqlDatabase" > sql-database
echo "$smtpHost" > smtp-host
echo "$smtpPort" > smtp-port
echo "$smtpUsername" > smtp-username
echo "$smtpPassword" > smtp-password
echo "$smtpFromName" > smtp-fromname
echo "$smtpFromAddress" > smtp-fromaddress
echo "secrets generated!"
