#!/bin/sh

if [ "$(dirname $0)" = "." ]
then
    cd ../src/azuremyst
else
    parent=$(dirname $(dirname "$0"))
    cd "$parent"/src/azuremyst
fi

date=$(date '+%H-%M-%S_%d-%m-%Y')

dotnet ef migrations add _"$date" --context DefaultDbContext
dotnet ef migrations add _"$date" --context KeyDbContext
dotnet ef migrations add _"$date" --context AuthDbContext
dotnet ef migrations add _"$date" --context LogsDbContext