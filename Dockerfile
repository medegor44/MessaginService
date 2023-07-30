FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "MessagingService/MessagingService.csproj"
WORKDIR "/src/MessagingService"
RUN dotnet build "MessagingService.csproj" -c Release -o /app/build

FROM base AS run
WORKDIR /app
COPY --from=build /app/build .
ENTRYPOINT ["dotnet", "MessagingService.dll"]
