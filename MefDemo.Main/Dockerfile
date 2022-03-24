FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MefDemo/MefDemo.csproj", "MefDemo/"]
RUN dotnet restore "MefDemo/MefDemo.csproj"
COPY . .
WORKDIR "/src/MefDemo"
RUN dotnet build "MefDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MefDemo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MefDemo.dll"]
