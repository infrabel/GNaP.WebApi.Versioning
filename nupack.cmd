@ECHO OFF

ECHO Packing GNaP.WebApi.Versioning
nuget pack src\GNaP.WebApi.Versioning\GNaP.WebApi.Versioning.csproj -Prop Configuration=Release

ECHO Packing GNaP.WebApi.Versioning.SystemWeb
nuget pack src\GNaP.WebApi.Versioning.SystemWeb\GNaP.WebApi.Versioning.SystemWeb.csproj -Prop Configuration=Release