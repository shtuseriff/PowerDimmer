# PowerDimmer (Fork)

A simple distraction dimmer for Windows

> **About this fork:** This is a fork of [shayne/PowerDimmer](https://github.com/shayne/PowerDimmer). The original had a bug where dimming didn't work on external monitors in mixed-DPI setups ([issue #4](https://github.com/shayne/PowerDimmer/issues/4)), and I wanted a couple of extra features. No commits have been made to the original repo in 2+ years, so I fixed and extended it (and by that I mean Claude fixed and extended it :-). Just did this for personal use. Not tested on any PCs except my own and haven't checked if the changes affect resource usage compared to the original, so YMMV.
>
> **Changes from the original:**
> - Fixed multi-monitor dimming on mixed-DPI setups (uses Win32 pixel coordinates instead of WPF DIPs)
> - Added "Undim on desktop click" option — click the desktop wallpaper to temporarily remove all dimming
> - Added "Dim all monitors?" toggle — optionally limit dimming to the primary monitor only
> - Upgraded from .NET 6 to .NET 8 (LTS)

| [<img src="https://user-images.githubusercontent.com/79330/147771591-853256ae-f4f1-42d3-8c68-ea467febeb58.png" width="800" />](https://user-images.githubusercontent.com/79330/147771591-853256ae-f4f1-42d3-8c68-ea467febeb58.png) |
| :--: |
| *Dim everything but focused window* |

| [<img src="https://user-images.githubusercontent.com/79330/147770555-5efe9efc-88e1-438e-a559-47b5f495976b.png" width="800" />](https://user-images.githubusercontent.com/79330/147770555-5efe9efc-88e1-438e-a559-47b5f495976b.png) |
| :--: |
| *Multiple focused windows via dimming toggle hotkey* |

## Features

Initial Release

* Dims all but currently focused window
* Toggle dimming for a specific window via `Win + Shift + D`
* Adjust brightness level from the system tray context menu

New features
* Toggle shade for a specific window via `Win + Alt + S`, usefull for that one bright screen without darkmode
* Shade an area of a window via `Win + Alt + A` then select the area to shade. The shade will move with the window

## Building

Just install the [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) and then `dotnet run`

## Context

I threw this project together after finding my own need PowerDimmer. I initially tried LeDimmer. It works well enough, but it's abandoned, closed source and very out of date.

A fan of PowerToys I checked for an open issue and found [microsoft/PowerToys#13035](https://github.com/microsoft/PowerToys/issues/13035). I decided to write this to try and gain support and get this module added to PowerToys.