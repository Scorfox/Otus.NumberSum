FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Otus.NumbersSum/Otus.NumbersSum.csproj", "Otus.NumbersSum/"]
RUN dotnet restore "Otus.NumbersSum/Otus.NumbersSum.csproj"
COPY . .
WORKDIR "/src/Otus.NumbersSum"
RUN dotnet build "Otus.NumbersSum.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Otus.NumbersSum.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Otus.NumbersSum.dll"]
