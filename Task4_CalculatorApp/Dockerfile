# Use the official .NET runtime as a base image
FROM ://microsoft.com AS base
WORKDIR /app
EXPOSE 8080

# Copy the published files from GitHub actions into the container
COPY ./publish .

# Start the application 
ENTRYPOINT ["dotnet", "CalculatorApp.dll"]
