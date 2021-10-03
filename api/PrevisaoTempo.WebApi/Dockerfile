FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /api
COPY ["api/PrevisaoTempo.WebApi/PrevisaoTempo.WebApi.csproj", "api/PrevisaoTempo.WebApi/"]
COPY ["api/PrevisaoTempo.Application/PrevisaoTempo.Application.csproj", "api/PrevisaoTempo.Application/"]
COPY ["api/PrevisaoTempo.Data/PrevisaoTempo.Data.csproj", "api/PrevisaoTempo.Data/"]
COPY ["api/PrevisaoTempo.Domain/PrevisaoTempo.Domain.csproj", "api/PrevisaoTempo.Domain/"]
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