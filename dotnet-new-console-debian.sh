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

	if [ ! -f packages-microsoft-prod.deb ]; then
		wget https://packages.microsoft.com/config/debian/10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
	fi

	if [ -f packages-microsoft-prod.deb ]; then
		sudo dpkg -i packages-microsoft-prod.deb &&

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
	fi

	cd $currentDir
}

function InstallVSCode {
	## https://code.visualstudio.com/docs/?dv=linux64_deb
	## https://wiki.debian.org/VisualStudioCode
	## https://github.com/Microsoft/vscode

	echo -e "\nInstall VSCode from:
	https://code.visualstudio.com/docs/?dv=linux64_deb
	https://wiki.debian.org/VisualStudioCode
	https://github.com/Microsoft/vscode
	"
}

function InstallVSCodium {
	## https://gitlab.com/paulcarroty/vscodium-deb-rpm-repo

	read -e -p "Install vscodium texteditor? [y/N]: " -i "N" yn

	case $yn in
		[Yy]* )
			wget -qO - https://gitlab.com/paulcarroty/vscodium-deb-rpm-repo/raw/master/pub.gpg \
				| gpg --dearmor \
				| sudo dd of=/usr/share/keyrings/vscodium-archive-keyring.gpg

			echo 'deb [ signed-by=/usr/share/keyrings/vscodium-archive-keyring.gpg ] https://paulcarroty.gitlab.io/vscodium-deb-rpm-repo/debs vscodium main' \
				| sudo tee /etc/apt/sources.list.d/vscodium.list

			sudo apt update
			sudo apt install codium
			;;
	esac
}

function run {

	command -v dotnet
	isDotNet=$?

	if [ $isDotNet -eq 0 ]; then
		echo "Init dotnet project ..."

		## clear previous builds
		rm -rf bin
		rm -rf obj
		rm *.csproj

		sleep 2

		## init new dotnet project
		dotnet clean
		dotnet new console --force

		sleep 2

		## import desired Program.cs
		cp Program.txt Program.cs
	else
		echo "Error."
		echo -e "dotnet is  not installed. Attempting to install now.\n"

		read -e -p "Install Csharp dependancied? [Y/n]: " -i "Y" yn
		case $yn in
            [Yy]* )
				InstallCsharp

				echo -e "\nIf Csharp was installed,\n\trun this script again to initialze this dot net project.\n"
				;;
		esac

		InstallVSCode
		InstallVSCodium
	fi

}

run
