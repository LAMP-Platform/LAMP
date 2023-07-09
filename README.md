[![GitHub all releases](https://img.shields.io/github/downloads/ConConner/LAMP/total?color=%232ea043&label=Downloads&style=flat-square)](https://github.com/ConConner/LAMP/releases/tag/Beta) [![Discord](https://img.shields.io/discord/675716572156788776?color=%2347a6ff&label=Dev.%20Discord&logo=Discord&logoColor=%23FFFFFF&style=flat-square)](https://discord.gg/YT6M2rAqqS) [![](https://img.shields.io/badge/Community-Metroid%20Construction-eb7f00?style=flat-square)](https://metroidconstruction.com/)

# LAMP ![](https://i.imgur.com/GU6OWbJ.png)
**Level Arranging Metroid (2) Program**

LAMP is a feature-rich Metroid 2: Return of Samus editor. Made with .NET and Windows Forms.  
You **_need_** to install **.NET 6** (or higher) to run the program. If you don't have it installed it can be downloaded here:
* [.NET 7 64bit/x64](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-7.0.7-windows-x64-installer)
* [.NET 7 32bit/x86](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-7.0.7-windows-x86-installer)

LAMP is split into a 32bit/x86 and 64bit/x64 version.  
This is due to the zooming feature having huge performance issues on higher zooming levels on the x86 version.

## Releases
**The newest stable version of LAMP can always be found [here](https://github.com/ConConner/LAMP/releases)!**  
Stable releases take a long time but add a lot of features and fix a lot of bugs.  
If you want faster updates and quicker access to features, which might still be in development, download one of the development builds.  
**Development builds can be found [here](https://github.com/ConConner/LAMP/actions)!**  
The newest development version will be under the Artifacts section in one of the selected Actions.

## Build instructions
To build LAMP from source, open a CLI in your repository root and run:  

**For x64**
```
dotnet publish -r win-x64 -c release
```
**For x86**
```
dotnet publish -r win-x86 -c release
```
#
For assistance and help refer to the [LAMP Wiki](https://github.com/ConConner/LAMP/wiki) or join the [Development Discord](https://discord.gg/YT6M2rAqqS)!
