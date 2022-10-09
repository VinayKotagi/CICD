FROM mcr.microsoft.com/dotnet/aspnet:3.1-focal AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:3.1-focal AS build
WORKDIR /src
COPY ["CICDWebApp/CICDWebApp.csproj", "CICDWebApp/"]
RUN dotnet restore "CICDWebApp/CICDWebApp.csproj"
COPY . .
WORKDIR "/src/CICDWebApp"
RUN dotnet build "CICDWebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CICDWebApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CICDWebApp.dll"]
