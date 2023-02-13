# NetObsBindings

[![NuGet version (NetObsBindings)](https://img.shields.io/nuget/v/NetObsBindings.svg?style=flat-square)](https://www.nuget.org/packages/NetObsBindings/)

NetObsBindings is a library that provides .NET bindings for Open Broadcaster Software (OBS).

These bindings are generated from the OBS repository, specifically [libobs](https://github.com/obsproject/obs-studio/tree/master/libobs) and [obs-frontend](https://github.com/obsproject/obs-studio/tree/master/UI/obs-frontend-api) projects.

The approach taken is to generate a static class per header file via [ClangSharp](https://github.com/dotnet/ClangSharp) generator.
This means, that, for example, you could find functions exported from the [obs-service.h](https://github.com/obsproject/obs-studio/blob/master/libobs/obs-service.h) file in the [ObsService](https://github.com/kostya9/NetObsBindings/blob/main/NetObsBindings/ObsInterop/ObsService.cs) C# class.

## How to use these bindings?

These bindings can be used to create your own plugin in C#. There is one caveat: make sure you are publishing the plugins as NativeAOT libraries, this is essential to make it work due to the plugin model of OBS.

Examples:
- samples folder contains a [simple plugin example](https://github.com/kostya9/NetObsBindings/blob/main/samples/SimplePlugin/ObsPlugin.cs).
- more compresensive example - [ObsCSharpExample](https://github.com/YorVeX/ObsCSharpExample) by [@YorVeX](https://github.com/YorVeX)
    > Example for an OBS plugin written in C# containing various standard items like output, filter, source or a settings dialog in the OBS Tools menu.


Plugins made using this library:
- [xObsBrowserAutoRefresh](https://github.com/YorVeX/xObsBrowserAutoRefresh) by [@YorVeX](https://github.com/YorVeX)
    > OBS plugin providing a filter for automatically refreshing a browser source in a configurable interval.



---

## How to generate bindings locally?

In order to generate bindings locally, please use the [build.ps1](https://github.com/kostya9/NetObsBindings/blob/main/build.ps1) script. Make sure that you have ClangSharpPInvokeGenerator dotnet tool installed.

This script will:
1. Clone the OBS repository
2. Generate bindings for all required modules
3. Insert the version of the OBS library to [Obs.Version.cs](https://github.com/kostya9/NetObsBindings/blob/main/NetObsBindings/Obs.Version.cs) file.

---

Originally, these bindings generated in the blog post https://sharovarskyi.com/blog/posts/clangsharp-dotnet-interop-bindings/
