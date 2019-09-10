FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Ginfo.Web/Ginfo.Web.csproj", "Ginfo.Web/"]
RUN dotnet restore "Ginfo.Web/Ginfo.Web.csproj"
COPY . .
WORKDIR "/src/Ginfo.Web"
RUN dotnet build "Ginfo.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Ginfo.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Ginfo.Web.dll"]