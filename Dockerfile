# Build stage image
FROM mcr.microsoft.com/dotnet/sdk:10.0@sha256:e70cdb7f80b0348f5cb85f19a8f670fca061f033d57eed12fa003d58b0e06317 AS build
WORKDIR /src
COPY . .
WORKDIR "/src"
RUN dotnet build --warnaserror
RUN dotnet test --test-modules WasteOrganisationsStub.Test/bin/Debug/net10.0/WasteOrganisationsStub.Test.dll --no-build
RUN dotnet publish WasteOrganisationsStub -c Release -o /app/publish /p:UseAppHost=false

# Final production image
FROM mcr.microsoft.com/dotnet/aspnet:10.0@sha256:de0ee358cdd672f7017a003bed21e9ac9ed48a27c922a59b18175b6e82fa7fee
WORKDIR /app

# Add curl to template, CDP PLATFORM HEALTHCHECK REQUIREMENT
RUN apt update && \
    apt install curl -y && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

COPY --from=build /app/publish .
EXPOSE 8085
ENTRYPOINT ["dotnet", "WasteOrganisationsStub.dll"]
