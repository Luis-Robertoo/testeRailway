


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY . ./
RUN dotnet restore
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app ./

ARG PORT
ENV PORT ${PORT}
ENV ASPNETCORE_URLS=http://+:${PORT}

EXPOSE ${PORT}

ENTRYPOINT ["dotnet", "TesteDockerRailway.dll"]

