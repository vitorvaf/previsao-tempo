FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-stretch AS build
WORKDIR /api
COPY ["api/PrevisaoTempo.WebApi/PrevisaoTempo.Api.csproj", "src/PrevisaoTempo.Api/"]
COPY ["api/PrevisaoTempo.Ioc/PrevisaoTempo.Ioc.csproj", "api/PrevisaoTempo.Application/"]
COPY ["api/PrevisaoTempo.Dados/PrevisaoTempo.Dados.csproj", "api/PrevisaoTempo.Data/"]
COPY ["api/PrevisaoTempo.Dominio/PrevisaoTempo.Dominio.csproj", "api/PrevisaoTempo.Domain/"]
RUN dotnet restore "api/PrevisaoTempo.WebApi/PrevisaoTempo.WebApi.csproj"
COPY . .
WORKDIR "api/PrevisaoTempo.WebApi/"
RUN dotnet build "PrevisaoTempo.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PrevisaoTempo.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PrevisaoTempo.WebApi.dll"]