FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY eAirFlow.Model/eAirFlow.Model.csproj eAirFlow.Model/
COPY eAirFlow.Services/eAirFlow.Services.csproj eAirFlow.Services/
COPY eAirFlow.Subscriber/eAirFlow.Subscriber.csproj eAirFlow.Subscriber/

RUN dotnet restore "eAirFlow.Subscriber/eAirFlow.Subscriber.csproj"

COPY . .

RUN dotnet publish "eAirFlow.Subscriber/eAirFlow.Subscriber.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "eAirFlow.Subscriber.dll"]
