#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 7091

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/Reservation/Reservation.API/Reservation.API.csproj", "Services/Reservation/Reservation.API/"]
COPY ["Services/Reservation/Reservation.Infrastructure/Reservation.Infrastructure.csproj", "Services/Reservation/Reservation.Infrastructure/"]
COPY ["Services/Reservation/Reservation.Models/Reservation.Models.csproj", "Services/Reservation/Reservation.Models/"]
COPY ["Services/Reservation/Reservation.Services/Reservation.Services.csproj", "Services/Reservation/Reservation.Services/"]
RUN dotnet restore "Services/Reservation/Reservation.API/Reservation.API.csproj"
COPY . .
WORKDIR "/src/Services/Reservation/Reservation.API"
RUN dotnet build "Reservation.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Reservation.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:7001
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Reservation.API.dll"]