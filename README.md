# Batman: Arkham Asylum - Advanced Launcher

This is a replacement application for the original BmLauncher of the game. Alongside the vastly superior configuration options, this Launcher also offers:

- Tooltips for every configuration option
- Option to disable Startup Movies
- Compatibility Fixes for [HD Texture Packs](https://steamcommunity.com/sharedfiles/filedetails/?id=1159691355)
- NVIDIA API Implementation (Enable HBAO+ using the Launcher!) (Powered by [NvAPIWrapper](https://github.com/falahati/NvAPIWrapper))
- Extensive Logging Functionality (Powered by [NLog](https://github.com/NLog/NLog))

Works with both the Steam and EGS Version!

**This Application depends on .NET Framework 4.5**. If you are using Windows 8 (or newer), you shouldn't have any issues executing it. Windows 7 SP1 (and older) might need to install [.NET Framework 4.5](https://download.microsoft.com/download/B/A/4/BA4A7E71-2906-4B2D-A0E1-80CF16844F5F/dotNetFx45_Full_setup.exe) manually. Other Environments than Windows are currently not supported.

## Preview

![BMLauncher Preview](https://user-images.githubusercontent.com/49599979/76242354-e3edf400-6236-11ea-805d-7ce97b110ae8.png)

## Download

See: [Current Release](https://github.com/neatodev/BmLauncher/releases)

## Installation

Drag the contents of the .zip file into the 'Batman Arkham Asylum GOTY\Binaries' folder.

To find this folder for the *Steam* version, just right-click the game in Steam, select Properties->Local Files->Browse Local Files.

Since *EGS* doesn't have an option like this, your best bet is to just open your C:\Program Files\ folder and look for the installation there.


## Usage

You can just launch your game via Steam or EGS as you normally would, though in some cases you might need to unblock the BmLauncher application for it to work properly.

To do that, just right-click the application, select Properties and enable the highlighted checkbox as seen in the image below:

![Unblock Image](https://user-images.githubusercontent.com/49599979/75610370-e2268100-5b10-11ea-978d-c257a2466dc8.png)

## Bug Reports

To file a bug report, or if you have suggestions for the Launcher in general, please file an [issue](https://github.com/neatodev/BmLauncher/issues/new). I read these regularly and should normally be able to respond within a day. If you are using version 1.5+ (which you should), please also include the most recent bmlauncher_report in the issue (if available). You can find the reports in the 'Batman Arkham Asylum GOTY\Binaries\logs' folder.

## Known Issues

**NVAPI_ACCESS_DENIED**: See [my response](https://github.com/neatodev/BmLauncher/issues/3#issuecomment-681074403) to Issue [#3](https://github.com/neatodev/BmLauncher/issues/3) for a solution.


## About this Project

This is my first programming project using C#. I created it in a very short timespan and only incrementally patched up issues. So for any fellow programmer looking through the source code, expect some messy implementations and the occasional disregard for C# Code Conventions. I have cleaned up the code quite a bit, it's not perfect yet, but as it stands it works just fine and I am occupied with other projects. Please keep this in mind.

### License

This work is licensed under a
[Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License][cc-by].

[![CC BY 4.0][cc-by-shield]][cc-by]

[cc-by]: https://creativecommons.org/licenses/by-nc-sa/4.0/
[cc-by-shield]: https://licensebuttons.net/l/by-nc-sa/4.0/80x15.png
