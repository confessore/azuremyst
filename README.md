<a href="https://github.com/confessore/azuremyst">
    <img src="https://raw.githubusercontent.com/confessore/azuremyst/main/src/azuremyst/wwwroot/images/azuremyst.png" height="200" />
</a>

&nbsp;

![open issues](https://img.shields.io/github/issues/confessore/azuremyst)
![forks](https://img.shields.io/github/forks/confessore/azuremyst)
![stars](https://img.shields.io/github/stars/confessore/azuremyst)
![license](https://img.shields.io/github/license/confessore/azuremyst)

&nbsp;

azuremyst is a free project with the following goal:

  **Doing Emulation Right!**

this means, we want to focus on:

* Doing
  * This project is focused on developing software!
  * Also there are many other aspects that need to be done and are
    considered equally important.
  * Anyone who wants to do stuff is very welcome to do so!

* Emulation
  * This project is about developing a server software that is able to
    emulate a well known MMORPG service.

* Right
  * Our goal must always be to provide the best code that we can.
  * Being 'right' is defined by the behaviour of the system
    we want to emulate.
  * Developing things right also includes documenting and discussing
    _how_ to do things better, hence...
  * Learning and teaching are very important in our view, and must
    always be a part of what we do.

To be able to accomplish these goals, we support and promote:

* Freedom
  * of our work: Our work - including our code - is released under the GPL.
    So everybody is free to use and contribute to this open source project.
  * for our developers and contributors on things that interest them.
    No one here is telling anybody _what_ to do.
    If you want somebody to do something for you, pay them,
    but we are here to enjoy.
  * to have FUN with developing.

* A friendly environment
  * We try to leave personal issues behind us.
  * We only argue about content and not about thin air!
  * We follow the [Netiquette](http://tools.ietf.org/html/rfc1855).

-- the azuremyst team!

this deployment guide is tailored for debian based operating systems
and always a work in progress

it is tested against ubuntu 20.04

- remember the submodules
```sh
$ git submodule update --init --recursive
$ git submodule update --recursive --remote
```

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

* execute `define-secrets.sh` to define the secrets
* server - mariadb
* user - azuremyst
* pass - azuremyst
* db - azuremyst
```sh
    $ sudo chmod +x ~/azuremyst/scripts/define-secrets.sh
    $ ~/azuremyst/scripts/define-secrets.sh
```

&nbsp;

- create a  `~/azuremyst/data` directory and copy `dbc`, `maps`, `mmaps`, and `vmaps`

&nbsp;

* create the required docker volumes
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

- if you're on desktop, you probably have the compose module
```sh
    $ sudo docker compose -f docker-compose-debug.yml build
    $ sudo docker compose -f docker-compose-debug.yml up -d
```
- remember to set the realmd realmlist address to 'localhost' to avoid realmlist looping

&nbsp;


## **afterthoughts**

avoid letsencrypt rate-limiting:
only docker-compose-release in a domain linked environment with all the necessary ports open

the `nginx` service will generate the SSL certificate
it will also renew the certificate before it expires  

&nbsp;

the `api` service will automagically apply migrations and update the database each time it starts
