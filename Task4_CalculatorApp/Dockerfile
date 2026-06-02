# 1. Use the official .NET SDK image to compile the code
FROM ://microsoft.com AS build-env
WORKDIR /app

# Copy the source files and compile the app
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# 2. Build the final lightweight runtime container
FROM ://microsoft.com
WORKDIR /app
COPY --from=build-env /app/out .

# Expose port 8080 for Render's routing web server
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

# Tell the container what file to execute on startup
ENTRYPOINT ["dotnet", "Task4_CalculatorApp.dll"]


