FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Task01/Task01.csproj", "Task01/"]
RUN dotnet restore "Task01/Task01.csproj"
COPY . .
WORKDIR "/src/Task01"
RUN dotnet build "Task01.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task01.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task01.dll"]
