#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/Contact/Contact.API/Contact.API.csproj", "Services/Contact/Contact.API/"]
COPY ["Services/Contact/Contact.Infrastructure/Contact.Infrastructure.csproj", "Services/Contact/Contact.Infrastructure/"]
COPY ["Services/Contact/Contact.Models/Contact.Models.csproj", "Services/Contact/Contact.Models/"]
COPY ["Services/Contact/Contact.Services/Contact.Services.csproj", "Services/Contact/Contact.Services/"]
RUN dotnet restore "Services/Contact/Contact.API/Contact.API.csproj"
COPY . .
WORKDIR "/src/Services/Contact/Contact.API"
RUN dotnet build "Contact.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Contact.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:7000
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Contact.API.dll"]