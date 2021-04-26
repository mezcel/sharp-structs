#!/bin/bash

## dotnet-new-console-debian.sh

function InstallCsharp {
	currentDir=$(PWD)
	
	## Install the .NET SDK or the .NET Runtime on Debian
	## https://docs.microsoft.com/en-us/dotnet/core/install/linux-debian

	## Microsoft package signing key to your list of trusted keys and add the package repository.

	mkdir -p ~/Downloads
	cd ~/Downlaods

	## Install an IDE
	sudo apt update
	sudo apt install -y wget build-essential vim tmux vifm aspell bc geany geany-plugins zip unzip

	wget https://packages.microsoft.com/config/debian/10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
	sudo dpkg -i packages-microsoft-prod.deb

	## Install the SDK
	## The .NET SDK allows you to develop apps with .NET. If you install the .NET SDK, you don't need to install the corresponding runtime.

	sudo apt-get update; \
	  sudo apt-get install -y apt-transport-https && \
	  sudo apt-get update && \
	  sudo apt-get install -y dotnet-sdk-5.0

	## The ASP.NET Core Runtime allows you to run apps that were made with .NET that didn't provide the runtime. The following commands install the ASP.NET Core Runtime, which is the most compatible runtime for .NET.

	sudo apt-get update; \
	  sudo apt-get install -y apt-transport-https && \
	  sudo apt-get update && \
	  sudo apt-get install -y dotnet-runtime-5.0

	#sudo apt-get install -y aspnetcore-runtime-5.0

	## Disable telemetry
	export DOTNET_CLI_TELEMETRY_OPTOUT=1

	echo -e "\n## Disable telemetry\nexport DOTNET_CLI_TELEMETRY_OPTOUT=1" >> ~/.bashrc

	cd $currentDir
}

function run {
	command -v dotnet
	isDotNet=$?

	if [ $isDotNet -eq 0 ]; then
		## clear previous builds
		rm -rf bin
		rm -rf obj
		rm *.csproj

		sleep 2

		## init new dotnet project
		dotnet new console

		sleep 2

		## import desired Program.cs
		cp Program.txt Program.cs
	else
		echo "Error."
		echo -e "dotnet is  not installed. Attempting to install now.\n"

		read -e -p "Press [enter] to continue ..." yn

		InstallCsharp
	fi

}





