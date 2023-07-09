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
* **[Stable](https://github.com/ConConner/LAMP/releases)**
* **[Development](https://github.com/ConConner/LAMP/actions)**

Stable releases take a longer time to release but add a lot of features, which are considered stable, and fix a lot of bugs.  
If you want faster updates and quicker access to features, which might still be in development, download one of the development builds.

## Projects made with LAMP
Even though LAMP is a fairly new program there are already some projects which are made with the help of LAMP.
### [Distress Call](https://metroidconstruction.com/hack.php?id=737)
A hack created by moehr. You have to explore a research satellite, which was attacked by the space pirates. Distress Call brings a lot of QOL improvements to the table
like a built in map and beam switching.  

<img src="https://i.imgur.com/bI8l4jC.png" alt="drawing" width="160"/> <img src="https://i.imgur.com/bAJrr1Z.png" alt="drawing" width="160"/> <img src="https://i.imgur.com/bJwlYXF.png" alt="drawing" width="160"/>

### M2NES - Zebes Revisited
A hack currently in development by LOO-E. Zebes is being carefully recreated in the engine of Metroid 2. There might even be some new content
in the hack once it is finished.

<img src="https://cdn.discordapp.com/attachments/370769199653584896/1127734500047212595/Bendezium_Mines-0.png" alt="drawing" width="160"/> <img src="https://cdn.discordapp.com/attachments/370769199653584896/1127741751357087905/norfair-1.png" alt="drawing" width="160"/> <img src="https://cdn.discordapp.com/attachments/370769199653584896/1127741750782459944/tourian-1.png" alt="drawing" width="160"/>

These projects show that everyone can easily pick up LAMP and make a promising hack of Metroid 2 with it!

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
