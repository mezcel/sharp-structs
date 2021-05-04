:: publish within the project home directory
dotnet publish --output "./" --runtime win-x64 --configuration Release -p:PublishSingleFile=true -p:PublishTrimmed=true --self-contained true