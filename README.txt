
Reference documents for use on linux

https://docs.microsoft.com/en-us/dotnet/core/linux-prerequisites?tabs=netcore21

https://github.com/dotnet/core/blob/master/Documentation/self-contained-linux-apps.md

https://opensource.com/article/17/11/net-linux


How to install .NET Core on Linux
The list of Linux distributions on which you can run .NET Core includes Red Hat Enterprise Linux (RHEL), Ubuntu, Debian, Fedora, CentOS, Oracle, and SUSE.

Each distribution has its own installation instructions. For example, consider Fedora 26:

Step 1: Add the dotnet product feed.

        sudo rpm --import https://packages.microsoft.com/keys/microsoft.asc
        sudo sh -c 'echo -e "[packages-microsoft-com-prod]\nname=packages-microsoft-com-prod \nbaseurl=https://packages.microsoft.com/yumrepos/microsoft-rhel7.3-prod\nenabled=1\ngpgcheck=1\ngpgkey=https://packages.microsoft.com/keys/microsoft.asc" > /etc/yum.repos.d/dotnetdev.repo'
Step 2: Install the .NET Core SDK.

        sudo dnf update
        sudo dnf install libunwind libicu compat-openssl10
        sudo dnf install dotnet-sdk-2.0.0
Creating the Hello World console app
Now that you have .NET Core installed, you can create the ubiquitous "Hello World" console application before learning more about .NET Core. After all, you're a developer: You want to create and run some code now. Fair enough; this is easy. Create a directory, move into it, create the code, and run it:

mkdir helloworld && cd helloworld
dotnet new console
dotnet run
You’ll see the following output:

$ dotnet run
Hello World!


Other Information
NET Core 2.1 is supported on the following Linux distributions/versions:

Red Hat Enterprise Linux 7, 6 - 64-bit (x86_64 or amd64)
CentOS 7 - 64-bit (x86_64 or amd64)
Oracle Linux 7 - 64-bit (x86_64 or amd64)
Fedora 28, 27 - 64-bit (x86_64 or amd64)
Debian 9 (64-bit, arm32), 8.7 or later versions - 64-bit (x86_64 or amd64)
Ubuntu 18.04 (64-bit, arm32), 16.04, 14.04 - 64-bit (x86_64 or amd64)
Linux Mint 18, 17 - 64-bit (x86_64 or amd64)
openSUSE 42.3 or later versions - 64-bit (x86_64 or amd64)
SUSE Enterprise Linux (SLES) 12 Service Pack 2 or later - 64-bit (x86_64 or amd64)
Alpine Linux 3.7 or later versions - 64-bit (x86_64 or amd64)

Linux distribution dependencies
The following are intended to be examples. The exact versions and names may vary slightly on your Linux distribution of choice.

Ubuntu
Ubuntu distributions require the following libraries installed:

liblttng-ust0
libcurl3
libssl1.0.0
libkrb5-3
zlib1g
libicu52 (for 14.x)
libicu55 (for 16.x)
libicu57 (for 17.x)
libicu60 (for 18.x)
For versions earlier than .NET Core 2.1, following dependencies are also required:

libunwind8
libuuid1
CentOS and Fedora
CentOS distributions require the following libraries installed:

lttng-ust
libcurl
openssl-libs
krb5-libs
libicu
zlib
Fedora users: If your openssl's version >= 1.1, you'll need to install compat-openssl10.
