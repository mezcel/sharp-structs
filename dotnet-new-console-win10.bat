:: dotnet-new-console-win10.bat

:: clear previous builds
rem bin
rem obj
rem *.csproj

:: init new dotnet project
dotnet new console --force

:: import desired Program.cs
xcopy Program.txt Program.cs /Y