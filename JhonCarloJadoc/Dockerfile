# Use the official ASP.NET Core runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["JhonCarloJadoc/JhonCarloJadoc.csproj", "JhonCarloJadoc/"]
RUN dotnet restore "JhonCarloJadoc/JhonCarloJadoc.csproj"
COPY . .
WORKDIR "/src/JhonCarloJadoc"
RUN dotnet build "JhonCarloJadoc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JhonCarloJadoc.csproj" -c Release -o /app/publish

# Final stage/image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JhonCarloJadoc.dll"]
