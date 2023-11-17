FROM mcr.microsoft.com/dotnet/sdk:8.0
ENV PATH $PATH:/root/.dotnet/tools

RUN apt-get update \
    && apt-get install -y sqlite3 \
    && rm -rf /var/lib/apt/lists/*

RUN dotnet tool install -g dotnet-ef