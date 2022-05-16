#!/bin/sh

if [ "$(dirname $0)" = "." ]
then
    cd ../src/azuremyst
else
    parent=$(dirname $(dirname "$0"))
    cd "$parent"/src/azuremyst
fi
dotnet ef database drop --force --context LogsDbContext
for file in ./migrations/*
do
	if [[ "$file" = *Global* || "$file" = *Designer* || "$file" = *Snapshot* ]]
	then
		continue
	fi
	dotnet ef migrations remove --context LogsDbContext
done
dotnet ef migrations add init --context LogsDbContext
