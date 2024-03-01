FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["FinanceSystem.Search/FinanceSystem.Search.csproj", "FinanceSystem.Search/"]
RUN dotnet restore "FinanceSystem.Search/FinanceSystem.Search.csproj"
COPY . .
WORKDIR "/src/FinanceSystem.Search"
RUN dotnet build "FinanceSystem.Search.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "FinanceSystem.Search.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FinanceSystem.Search.dll"]
