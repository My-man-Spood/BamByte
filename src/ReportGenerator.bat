:: Copier ce file dans un des projets tests pour generer le rapport
:: L'enlever par la suite
@echo off
set /p proj=Enter project name: 


dotnet %USERPROFILE%\.nuget\packages\reportgenerator\4.8.12\tools\netcoreapp3.0\ReportGenerator.dll -reports:%proj%/coverage.opencover.xml -targetdir:%proj%/TestReport -reporttypes:Html