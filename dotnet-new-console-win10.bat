:: dotnet-new-console-win10.bat

:: clear previous builds
rem bin
rem obj
rem *.csproj
rem *.dll
rem *.pdb

:: init new dotnet project
dotnet clean
dotnet new console --force

:: import desired Program.cs
xcopy Program.txt Program.cs /Y