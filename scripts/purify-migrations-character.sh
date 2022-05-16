#!/bin/sh

if [ "$(dirname $0)" = "." ]
then
    cd ../src/azuremyst
else
    parent=$(dirname $(dirname "$0"))
    cd "$parent"/src/azuremyst
fi
dotnet ef database drop --force --context CharacterDbContext
for file in ./migrations/CharacterDb/*
do
	if [[ "$file" = *Global* || "$file" = *Designer* || "$file" = *Snapshot* ]]
	then
		continue
	fi
	dotnet ef migrations remove --context CharacterDbContext
done
dotnet ef migrations add init --context CharacterDbContext
