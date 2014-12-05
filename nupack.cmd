@ECHO OFF

ECHO Packing GNaP.WebApi.Versioning
nuget pack src\GNaP.WebApi.Versioning\GNaP.WebApi.Versioning.csproj -Build -Prop Configuration=Release -Exclude gnap.ico