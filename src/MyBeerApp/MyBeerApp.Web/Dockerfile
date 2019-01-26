FROM microsoft/dotnet:2.2-aspnetcore-runtime-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk-stretch AS build
WORKDIR /src
COPY ["src/MyBeerApp", "MyBeerApp"]
RUN dotnet restore "MyBeerApp/MyBeerApp.sln"
COPY . .
RUN dotnet build "MyBeerApp/MyBeerApp.sln" -c Release -o /app

FROM build AS unittest
RUN dotnet test "MyBeerApp/MyBeerApp.UnitTests/MyBeerApp.UnitTests.csproj" -c Release /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=MyBeerApp.UnitTests.coverage.xml

FROM build AS integrationtest
RUN dotnet test "MyBeerApp/MyBeerApp.IntegrationTests/MyBeerApp.IntegrationTests.csproj" -c Release /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=MyBeerApp.IntegrationTests.coverage.xml

FROM build AS publish
RUN dotnet publish "MyBeerApp/MyBeerApp.Web/MyBeerApp.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyBeerApp.Web.dll"]