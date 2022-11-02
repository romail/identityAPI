FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Takoha/nuget.config", "Takoha/"]
COPY ["Takoha/src/Takoha.Web/Takoha.Web.csproj", "Takoha/src/Takoha.Web/"]
COPY ["Takoha/src/Takoha.Infrastructure/Takoha.Infrastructure.csproj", "Takoha/src/Takoha.Infrastructure/"]
COPY ["Takoha/src/Takoha.Core/Takoha.Core.csproj", "Takoha/src/Takoha.Core/"]
COPY ["Takoha/src/Takoha.SharedKernel/Takoha.SharedKernel.csproj", "Takoha/src/Takoha.SharedKernel/"]
RUN dotnet restore "Takoha/src/Takoha.Web/Takoha.Web.csproj"
COPY . .
WORKDIR "/src/Takoha/src/Takoha.Web"
RUN dotnet build "Takoha.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Takoha.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Takoha.Web.dll"]