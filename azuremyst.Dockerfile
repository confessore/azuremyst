FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS azuremyst-build-base
WORKDIR /build
COPY Azuremyst.sln Azuremyst.sln
COPY src/ src/
RUN --mount=type=cache,target=/root/.nuget/packages \
	dotnet restore ./Azuremyst.sln

FROM azuremyst-build-base AS azuremyst-build
RUN --mount=type=cache,target=/root/.nuget/packages \
	dotnet build -c Release --no-restore ./Azuremyst.sln

FROM azuremyst-build AS azuremyst-test
RUN dotnet test -c Release --no-build --no-restore ./Azuremyst.sln

FROM azuremyst-build AS publish-azuremyst
RUN --mount=type=cache,target=/root/.nuget/packages \
	dotnet publish -c Release --no-build --no-restore -o /app ./src/Azuremyst/Azuremyst.csproj

FROM base AS final-azuremyst
COPY --from=publish-azuremyst /app .
ENTRYPOINT ["dotnet", "Azuremyst.dll", "--urls", "http://[::]:5000"]