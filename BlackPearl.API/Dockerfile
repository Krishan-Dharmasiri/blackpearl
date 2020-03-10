FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["BlackPearl.API/BlackPearl.API.csproj", "BlackPearl.API/"]
RUN dotnet restore "BlackPearl.API/BlackPearl.API.csproj"
COPY . .
WORKDIR "/src/BlackPearl.API"
RUN dotnet build "BlackPearl.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlackPearl.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlackPearl.API.dll"]