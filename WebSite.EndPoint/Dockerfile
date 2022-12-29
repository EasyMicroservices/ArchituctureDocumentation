FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WebSite.EndPoint/WebSite.EndPoint.csproj", "WebSite.EndPoint/"]
RUN dotnet restore "WebSite.EndPoint/WebSite.EndPoint.csproj"
COPY . .
WORKDIR "/src/WebSite.EndPoint"
RUN dotnet build "WebSite.EndPoint.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebSite.EndPoint.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebSite.EndPoint.dll"]
