FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY src/AltenCarStore.Services/AltenCarStore.VehicleStateService/AltenCarStore.VehicleStateService.csproj src/AltenCarStore.Services/AltenCarStore.VehicleStateService/
RUN dotnet restore src/AltenCarStore.Services/AltenCarStore.VehicleStateService/AltenCarStore.VehicleStateService.csproj
COPY . .
WORKDIR /src/src/AltenCarStore.Services/AltenCarStore.VehicleStateService
RUN dotnet build AltenCarStore.VehicleStateService.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AltenCarStore.VehicleStateService.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AltenCarStore.VehicleStateService.dll"]
