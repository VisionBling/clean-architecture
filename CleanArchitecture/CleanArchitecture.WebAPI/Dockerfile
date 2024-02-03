# Dockerfile for CleanArchitecture.WebAPI

# Use the official ASP.NET Core runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Use the official .NET SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy the solution and restore dependencies
COPY CleanArchitecture.sln ./
COPY CleanArchitecture.WebAPI/CleanArchitecture.WebAPI.csproj CleanArchitecture.WebAPI/
RUN dotnet restore CleanArchitecture.WebAPI/CleanArchitecture.WebAPI.csproj

# Copy the rest of the application code and build it
COPY . .
WORKDIR /src/CleanArchitecture.WebAPI
RUN dotnet build CleanArchitecture.WebAPI.csproj -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish CleanArchitecture.WebAPI.csproj -c Release -o /app/publish

# Use the runtime image for the final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CleanArchitecture.WebAPI.dll"]
