
FROM microsoft/aspnetcore:1.0.1
LABEL Name=clinical-management-system Version=0.0.1 
ARG source=.
WORKDIR /app
EXPOSE 5000
COPY $source .
ENTRYPOINT dotnet clinical-management-system.dll
