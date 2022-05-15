# **azuremyst** 

&nbsp;

## **debugging with microsoft net**
set the variables inside of `appsettings.Development.json` and remove the `.Development` portion of the file extension


## **deploying to production with docker**
# **THIS SHOULD ONLY BE DEPLOYED TO A SERVER WITH AN IP ADDRESS LINKED TO THE DOMAIN NAME**
# **FAILURE TO ADHERE TO THIS WILL RESULT IN RATELIMITING BY 'LETSENCRYPT'**

&nbsp;

this deployment guide is tailored for debian based operating systems    
it is tested against ubuntu 20.04

&nbsp;

if you kinda-sorta already know what you are doing, you can install docker and docker-compose on an ubuntu box with `docker-install.sh` in the scripts directory

&nbsp;

* install `docker engine` (https://docs.docker.com/engine/install/)
```sh
    $ sudo apt update
    $ sudo apt install apt-transport-https ca-certificates curl gnupg lsb-release
    $ curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo gpg --dearmor -o /usr/share/keyrings/docker-archive-keyring.gpg
    $ echo \
        "deb [arch=amd64 signed-by=/usr/share/keyrings/docker-archive-keyring.gpg] https://download.docker.com/linux/ubuntu \
        $(lsb_release -cs) stable" | sudo tee /etc/apt/sources.list.d/docker.list > /dev/null
    $ sudo apt update
    $ sudo apt install docker-ce docker-ce-cli containerd.io
```

&nbsp;

* install `docker compose` (https://docs.docker.com/compose/install)
```sh
    $ sudo apt install docker-compose
```

&nbsp;

* execute `define-secrets.sh` to define the SQL and SMTP secrets
```sh
    $ sudo chmod +x ~/azuremyst/scripts/define-secrets.sh
    $ ~/azuremyst/scripts/define-secrets.sh
```
> note: you could also define and then remove the `.default` extension from each file in the `secrets` folder

&nbsp;

* create docker volumes for the database and SSL certificate
```sh
    $ sudo docker volume create azuremyst-db
    $ sudo docker volume create azuremyst-ssl
    $ sudo docker volume create azuremyst-data
```

&nbsp;

* build and run the composition
```sh
    $ sudo docker-compose -f docker-compose-debug.yml build
    $ sudo docker-compose -f docker-compose-debug.yml up -d
```

&nbsp;


## **afterthoughts**

the `nginx` service will generate the SSL certificate  
it will also renew the certificate before it expires  

&nbsp;

the `api` service will automagically apply migrations and update the database each time it starts