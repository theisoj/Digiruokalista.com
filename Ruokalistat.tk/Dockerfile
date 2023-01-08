FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /Ruokalistat.tk

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /Ruokalistat.tk
COPY --from=build-env /Ruokalistat.tk/out .
ENTRYPOINT ["dotnet", "Digiruokalista.com.dll"]