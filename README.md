# sharp-structs

Csharp console application which converts csv to struct to perform ER queries.

Csharp version of the CSV ER Database from [printf-time.git](https://github.com/mezcel/printf-time.git)

---

## Initialize and run this .NET Project

Debian
```bash
## rm previous bulds and initialize with *.txt script *.cs
## .NET for Debian will also be installed if needed
## https://docs.microsoft.com/en-us/dotnet/core/install/linux-debian

./dotnet-new-console-debian.sh

## Run project

dotnet run
```

Win10
```bat
:: rem previous builds and initialize with *.txt script *.cs

.\dotnet-new-console-win10.bat

:: Run project

dotnet run
```

---

# Development

## Default Assumptions

### CSV

* ```*.csv``` files are ```;``` delineated instead of ```,```
* Csv header format ERClassName.ERClassAttribute
    * Example:
        ```csv
        "bead.beadID";"bead.beadType"
        0;"my bead type string"
        ```

### Database

Assumes CSV files are stored in ```.\database\csv\*.csv```

* Change ```MyFunctions.CsvFilePath( csvBaseName )``` instructions or omit it's usage to import an external ER class.
    * Manual definition example:
        ```cs
        // base file name
        string csvBaseName = "myCsvFile.csv";
        ERClass.Bead.csvBaseName = csvBaseName;

        // Default
        string path = MyFunctions.CsvFilePath( csvBaseName ); // @".\database\csv\myCsvFile.csv"
        ERClass.Bead.path = path;

        // Alternate (N/A)
        string path = @"C:\database\myCsvFile.csv"; // Custom path location
        ERClass.Bead.path = path;
        ```

## Dependencies (Debian)

Guidance: [Install the .NET SDK or the .NET Runtime on Debian](https://docs.microsoft.com/en-us/dotnet/core/install/linux-debian)

```sh
## DL *.deb

wget https://packages.microsoft.com/config/debian/10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb

## install .Net

sudo dpkg -i packages-microsoft-prod.deb

sudo apt-get update; \
	  sudo apt-get install -y apt-transport-https && \
	  sudo apt-get update && \
	  sudo apt-get install -y dotnet-sdk-5.0

sudo apt-get update; \
    sudo apt-get install -y apt-transport-https && \
    sudo apt-get update && \
    sudo apt-get install -y dotnet-runtime-5.0
```

## Dependencies (Win10)

### .NET 5.0 (recommended)

.NET is a free, cross-platform, open-source developer platform for building many different types of applications.

| .NET 5.0 (recommended) x64 | .NET 5.0 (recommended) x86 |
| :---: | :---: |
| [dotnet-sdk-5.0.202-win-x64.exe](https://download.visualstudio.microsoft.com/download/pr/2de622da-5342-48ec-b997-8b025d8ee478/5c11b643ea7534f749cd3f0e0302715a/dotnet-sdk-5.0.202-win-x64.exe) | [dotnet-sdk-5.0.202-win-x86.exe](https://download.visualstudio.microsoft.com/download/pr/4e1426ee-1560-4df2-b307-692e28941ebf/aa8910349571ff68407e42ed63ee5f5d/dotnet-sdk-5.0.202-win-x86.exe) |
| [windowsdesktop-runtime-5.0.5-win-x64.exe](https://download.visualstudio.microsoft.com/download/pr/c1ef0b3f-9663-4fc5-85eb-4a9cadacdb87/52b890f91e6bd4350d29d2482038df1c/windowsdesktop-runtime-5.0.5-win-x64.exe) | [windowsdesktop-runtime-5.0.5-win-x86.exe](https://download.visualstudio.microsoft.com/download/pr/c089205d-4f58-4f8d-ad84-c92eaf2f3411/5cd3f9b3bd089c09df14dbbfb64124a4/windowsdesktop-runtime-5.0.5-win-x86.exe) |

### .NET Core 3.1 (LTS)

.NET Core is a free, cross-platform, open-source developer platform for building many different types of applications.

| .NET Core 3.1 (LTS) x64 | .NET Core 3.1 (LTS) x86 |
| :---: | :---: |
|[dotnet-sdk-3.1.408-win-x64.exe](https://download.visualstudio.microsoft.com/download/pr/fa20039c-5871-4597-8a7b-f0553a12edcc/4fb1cce6214049fe639dd230a9265133/dotnet-sdk-3.1.408-win-x64.exe)|[dotnet-sdk-3.1.408-win-x86.exe](https://download.visualstudio.microsoft.com/download/pr/d5821095-b8e2-47fd-b6a0-815beeefb0d4/f9b8a167f7e389b5e0207ada20caa1e9/dotnet-sdk-3.1.408-win-x86.exe)|
|[windowsdesktop-runtime-3.1.14-win-x64.exe](https://download.visualstudio.microsoft.com/download/pr/88437980-f813-4a01-865c-f992ad4909bb/9a936984781f6ce3526ffc946267e0ea/windowsdesktop-runtime-3.1.14-win-x64.exe)|[windowsdesktop-runtime-3.1.14-win-x86.exe](https://download.visualstudio.microsoft.com/download/pr/f449f435-25d3-4d5c-ad14-0c84f5131dea/a597530464689595a430407e440787c4/windowsdesktop-runtime-3.1.14-win-x86.exe)|

---

## Export as a packaged executable
```ps1
dotnet publish --output "c:/temp/myapp" --runtime win-x64 --configuration Release -p:PublishSingleFile=true -p:PublishTrimmed=true --self-contained true
```

---

## VSCode Plugin

```sh
## https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp

code --list-extensions
code --install-extension ms-dotnettools.csharp
#code --uninstall-extension ms-dotnettools.csharp
```

* VSCodium Plugin (alternative)

    Non-MS Version: [https://github.com/muhammadsammy/free-omnisharp-vscode](https://github.com/muhammadsammy/free-omnisharp-vscode)