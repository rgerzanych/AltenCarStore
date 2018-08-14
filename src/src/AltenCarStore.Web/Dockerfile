FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY AltenCarStore.Web/AltenCarStore.Web.csproj AltenCarStore.Web/
RUN dotnet restore AltenCarStore.Web/AltenCarStore.Web.csproj
COPY . .
WORKDIR /src/AltenCarStore.Web
RUN dotnet build AltenCarStore.Web.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AltenCarStore.Web.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AltenCarStore.Web.dll"]
