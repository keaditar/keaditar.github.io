#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["KeklandBankSystem/KeklandBankSystem.csproj", "KeklandBankSystem/"]
RUN dotnet restore "KeklandBankSystem/KeklandBankSystem.csproj"
COPY . .
WORKDIR "/src/KeklandBankSystem"
RUN dotnet build "KeklandBankSystem.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KeklandBankSystem.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

EXPOSE 5001
ENTRYPOINT ["dotnet", "KeklandBankSystem.dll"]
