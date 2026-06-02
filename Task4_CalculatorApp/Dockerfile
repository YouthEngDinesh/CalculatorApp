FROM mcr.microsoft.com AS build-env
WORKDIR /app

COPY. ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com
WORKDIR /app
COPY --from=build-env /app/out .

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "Task4_CalculatorApp.dll"]

