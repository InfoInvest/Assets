# syntax=docker/dockerfile:1.2

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Assets.API.csproj", "Assets.API/"]
RUN --mount=type=secret,id=read_nuget_pat dotnet nuget add source --username Lothyriel --password /run/secrets/read_nuget_pat --store-password-in-clear-text --name github "https://nuget.pkg.github.com/InfoInvest/index.json"
RUN dotnet restore "Assets.API/Assets.API.csproj"

COPY . .
WORKDIR "/src/Assets.API"
RUN dotnet build "Assets.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Assets.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Assets.API.dll"]
