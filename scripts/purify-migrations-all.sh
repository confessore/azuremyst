#!/bin/sh

if [ "$(dirname $0)" = "." ]
then
    cd ../src/azuremyst
else
    parent=$(dirname $(dirname "$0"))
    cd "$parent"/src/azuremyst
fi
dotnet ef database drop --force --context DefaultDbContext
dotnet ef database drop --force --context KeyDbContext
dotnet ef database drop --force --context LogsDbContext
dotnet ef database drop --force --context AuthDbContext
dotnet ef database drop --force --context CharacterDbContext
dotnet ef database drop --force --context WorldDbContext
for file in ./migrations/*
do
	if [[ "$file" = *Global* || "$file" = *Designer* || "$file" = *Snapshot* ]]
	then
		continue
	fi
	dotnet ef migrations remove --context DefaultDbContext
	dotnet ef migrations remove --context KeyDbContext
	dotnet ef migrations remove --context LogsDbContext
	dotnet ef migrations remove --context AuthDbContext
	dotnet ef migrations remove --context CharacterDbContext
	dotnet ef migrations remove --context WorldDbContext
done
dotnet ef migrations add init --context DefaultDbContext
dotnet ef migrations add init --context KeyDbContext
dotnet ef migrations add init --context LogsDbContext
dotnet ef migrations add init --context AuthDbContext
dotnet ef migrations add init --context CharacterDbContext
dotnet ef migrations add init --context WorldDbContext