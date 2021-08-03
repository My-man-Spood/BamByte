FROM mcr.microsoft.com/dotnet/sdk:5.0 as build-env
WORKDIR /app

COPY /src ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/runtime:5.0
WORKDIR /app
COPY --from=build-env /app/out .

RUN cat ${DISCORD_TOKEN} > TokenDiscord.txt
RUN cat ${GIPHY_TOKEN} > TokenGiphy.txt

ENTRYPOINT ["dotnet", "Bambyte.dll"]