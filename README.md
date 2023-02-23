<a href="https://github.com/confessore/azuremyst">
    <img src="https://raw.githubusercontent.com/confessore/azuremyst/main/src/azuremyst/wwwroot/images/azuremyst.png" height="200" />
</a>

&nbsp;

![open issues](https://img.shields.io/github/issues/confessore/azuremyst)
![forks](https://img.shields.io/github/forks/confessore/azuremyst)
![stars](https://img.shields.io/github/stars/confessore/azuremyst)
![license](https://img.shields.io/github/license/confessore/azuremyst)

&nbsp;

[join us on discord!](https://discord.gg/B44vuM2xxG)

&nbsp;

create your .env file from the example.

this deployment guide is tailored for debian based operating systems
and always a work in progress. everything should "just work".

it is tested against debian:bullseye-slim

- remember the submodules
```sh
$ git submodule update --init --recursive
$ git submodule update --recursive --remote
```

&nbsp;



- copy `dbc`, `maps`, `mmaps`, and `vmaps` data to the `~/azuremyst/data` directory

&nbsp;

* create the required docker volumes
```sh
    $ sudo docker volume create azuremyst-db
```

&nbsp;

* build and run the composition
```sh
    $ sudo docker compose build
    # go make some food or fold laundry
    # todo: add some more advanced caching to reduce subsequent build time
    $ sudo docker compose up -d db
    # wait a few seconds for db to init
    $ sudo docker compose up -d
    # first run installs db
```

&nbsp;

(public boxes require that the realm in db be bound to the gateway ip)

set realmlist and enjoy!