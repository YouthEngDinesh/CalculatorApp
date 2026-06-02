# 1. Use the .NET SDK to build the application
FROM ://microsoft.com AS build-env
WORKDIR /app

# Copy everything and restore/publish the app
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# 2. Build the runtime image
FROM ://microsoft.com
WORKDIR /app
COPY --from=build-env /app/out .

# Expose port 8080 for Render
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

# Run the app (Render will automatically catch this)
ENTRYPOINT ["dotnet", "Task4_CalculatorApp.dll"]

