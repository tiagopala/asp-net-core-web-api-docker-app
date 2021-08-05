FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
LABEL maintainer="tiagopala"

WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ./src /src

RUN dotnet restore  "AspNetCoreWebApiDockerApp.sln"
RUN dotnet build    "AspNetCoreWebApiDockerApp.sln"

FROM build AS publish
RUN dotnet publish "AspNetCoreWebApiDockerApp.sln" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "AspNetCoreWebApiDockerApp.Api.dll" ]