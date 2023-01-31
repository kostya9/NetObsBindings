# NetObsBindings

[![NuGet version (NetObsBindings)](https://img.shields.io/nuget/v/NetObsBindings.svg?style=flat-square)](https://www.nuget.org/packages/NetObsBindings/)

NetObsBindings is a library that provides .NET bindings for Open Broadcast Software (OBS).

These bindings are generated from the OBS repository, specifically [libobs](https://github.com/obsproject/obs-studio/tree/master/libobs) and [obs-frontend](https://github.com/obsproject/obs-studio/tree/master/UI) projects.

The approach taken is to generate a static class per header file via [ClangSharp](https://github.com/dotnet/ClangSharp) generator.
This means, that, for example, you could find functions exported from the [obs-service](https://github.com/obsproject/obs-studio/blob/master/libobs/obs-service.h) file in the [ObsService](https://github.com/kostya9/NetObsBindings/blob/main/NetObsBindings/ObsInterop/ObsService.cs) C# class.

## How to use these bindings?

These bindings can be used to create your own plugin in C#.

Simple plugin example:

```c#
public static class ObsPlugin
{
    public static nint ObsModulePointer { get; set; }

    [UnmanagedCallersOnly(EntryPoint = "obs_module_set_pointer", CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    public static void SetPointer(nint obsModulePointer)
    {
        Log("[blog] Pointer Saved!");
        ObsModulePointer = obsModulePointer;
    }
    
    [UnmanagedCallersOnly(EntryPoint = "obs_module_ver", CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    public static uint GetVersion()
    {
        Log("[blog] Returned version!");
        
        var major = (uint) Obs.Version.Major;
        var minor = (uint) Obs.Version.Minor;
        var patch = (uint) Obs.Version.Build;
        var version = (major << 24) | (minor << 16) | patch;
        return version;
    }

    [UnmanagedCallersOnly(EntryPoint = "obs_module_load", CallConvs = new[] {typeof(System.Runtime.CompilerServices.CallConvCdecl)})]
    public static bool ModuleLoad()
    {
        Log("[blog] Loaded!");
        return true;
    }

    private static unsafe void Log(string text)
    {
        var asciiBytes = Encoding.UTF8.GetBytes(text);
        fixed (byte* logMessagePtr = asciiBytes)
        {
            ObsBase.blogva(ObsBase.LOG_INFO, (sbyte*) logMessagePtr, null);   
        }
    }
}
```

There is one caveat: make sure you are publishing the plugins as NativeAOT libraries, this is essential to make it work due to the plugin model of OBS.

---

## How to generate bindings locally?

In order to generate bindings locally, please use the [build.ps1](https://github.com/kostya9/NetObsBindings/blob/main/build.ps1) script. Make sure that you have ClangSharpPInvokeGenerator dotnet tool installed.

This script will:
1. Clone the OBS repository
2. Generate bindings for all required modules
3. Insert the version of the OBS library to [Obs.Version.cs](https://github.com/kostya9/NetObsBindings/blob/main/NetObsBindings/Obs.Version.cs) file.

---

Originally, these bindings generated in the blog post https://sharovarskyi.com/blog/posts/clangsharp-dotnet-interop-bindings/