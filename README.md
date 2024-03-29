# THIS PROJECT IS ARCHIVED. 
# A NEW VERSION RUNNING .NET 6 IS [AVAILABLE HERE](https://github.com/neatodev/BmLauncherAsylumNET6)!
# THIS VERSION IS NO LONGER SUPPORTED!

# Batman: Arkham Asylum - Advanced Launcher [OUTDATED]

This is a replacement application for the original BmLauncher of the game. Alongside vastly superior configuration options, this Launcher also offers:

- Tooltips for every configuration option
- Option to disable Startup Movies
- Texmod Autoload Support
- Experimental Wine (Linux) Support (More Information at the bottom)
- Compatibility Fixes for [HD Texture Packs](https://steamcommunity.com/sharedfiles/filedetails/?id=1159691355)
- NVIDIA API Implementation (Enable HBAO+ using the Launcher!) (Powered by [NvAPIWrapper](https://github.com/falahati/NvAPIWrapper))
- Extensive Logging Functionality (Powered by [NLog](https://github.com/NLog/NLog))

Works with both the Steam and EGS Version!

**This Application depends on .NET Framework 4.8**. If you are using Windows 8 (or newer), you shouldn't have any issues executing it. Windows 7 SP1 (and older) might need to install [.NET Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-offline-installer) manually. **Other Environments than Windows are not supported.**

**This application has only been tested on Windows 7 SP1, Windows 8, Windows 8.1, Windows 10 and Wine. It supports the Steam, GOG and Epic Games Store version and nothing else.**

## Preview

![BMLauncher Preview](https://user-images.githubusercontent.com/49599979/195911308-4c53fa9e-8f6e-49dc-a626-c5cda228498a.png)

## Installation

Drag the contents of the .zip file into the 'Batman Arkham Asylum GOTY\Binaries' folder.

To find this folder for the *Steam* version, just right-click the game in Steam, select Properties->Local Files->Browse Local Files and navigate from there.

To find it for the *EGS* version, right-click the game and select "Manage". Then click the folder icon in the "Installation" tab and navigate from there.

For the *GOG* version, click the icon next to the PLAY button and select "Manage installation->Show folder" and navigate from there.


## Usage

You can just launch your game via Steam or EGS as you normally would, though in some cases you might need to unblock the BmLauncher application for it to work properly.

To do that, just right-click the application, select Properties and enable the highlighted checkbox as seen in the image below:

![Unblock Image](https://user-images.githubusercontent.com/49599979/75610370-e2268100-5b10-11ea-978d-c257a2466dc8.png)

## Hint for Linux users

To achieve the best results when using the Launcher, you should install the Calibri font for 

Protontricks:
`protontricks 35140 -q calibri`

or

Winetricks:
`WINEPREFIX=<path-to-SteamLibrary>/steamapps/compatdata/35140/pfx winetricks -q calibri`

Furthermore, to run Arkham Asylum properly on Linux, the following fix is needed:

`protontricks 35140 -q d3dx9 d3dcompiler_43`

If you wish to make full use of PhysX for Arkham Asylum on Linux you also need to copy Arkham City's [PhysXDevice.dll](https://drive.google.com/file/d/1hcM3y34HN2yLYmd1S_cV1q2MrOU6q_5w/view) into the same folder as the Launcher (Batman Arkham Asylum GOTY\Binaries).

This help section and the working Proton/Wine support was only made possible through heavy cooperation with [ThisNekoGuy](https://github.com/ThisNekoGuy).

## Bug Reports

To file a bug report, or if you have suggestions for the Launcher in general, please file an [issue](https://github.com/neatodev/BmLauncher/issues/new). I read these regularly and should normally be able to respond within a day. If you are using version 1.6+ (which you should), please also include the most recent bmlauncher_report in the issue (if available). You can find the reports in the 'Batman Arkham Asylum GOTY\Binaries\logs' folder.

## Known Issues

**NVAPI_ACCESS_DENIED**: See [my response](https://github.com/neatodev/BmLauncher/issues/3#issuecomment-681074403) to Issue [#3](https://github.com/neatodev/BmLauncher/issues/3) for a solution.

## About this Project

This is my first programming project using C#. I created it in a very short timespan and only incrementally patched up issues. So for any fellow programmer looking through the source code, expect some messy implementations and the occasional disregard for C# Code Conventions. I have cleaned up the code quite a bit, it's not perfect yet, but as it stands it works just fine and I am occupied with other projects. Please keep this in mind.

#### License

[![CC BY 4.0][cc-by-shield]][cc-by]

[cc-by]: https://creativecommons.org/licenses/by-nc-sa/4.0/
[cc-by-shield]: https://licensebuttons.net/l/by-nc-sa/4.0/80x15.png
