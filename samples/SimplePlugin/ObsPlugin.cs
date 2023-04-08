using System.Runtime.InteropServices;
using System.Text;
using ObsInterop;

namespace SimplePlugin;

public static class ObsPlugin
{
    private static nint _obsModulePointer;

    [UnmanagedCallersOnly(EntryPoint = "obs_module_set_pointer", CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    public static void SetPointer(nint obsModulePointer)
    {
        Log("Pointer Saved!");
        _obsModulePointer = obsModulePointer;
    }
    
    [UnmanagedCallersOnly(EntryPoint = "obs_module_ver", CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    public static uint GetVersion()
    {
        Log("Returned version!");
        
        var major = (uint) Obs.Version.Major;
        var minor = (uint) Obs.Version.Minor;
        var patch = (uint) Obs.Version.Build;
        var version = (major << 24) | (minor << 16) | patch;
        return version;
    }

    [UnmanagedCallersOnly(EntryPoint = "obs_module_load", CallConvs = new[] {typeof(System.Runtime.CompilerServices.CallConvCdecl)})]
    public static unsafe bool ModuleLoad()
    {
        Log("Loaded!");
        
        var profilePath = ObsFrontendApi.obs_frontend_get_current_profile_path();
        var name = new string(profilePath);
        Log($"Current profile path = {name}");
        ObsBmem.bfree(profilePath);
        
        return true;
    }

    private static unsafe void Log(string text)
    {
        text = $"[ObsPlugin]: {text}";
        var asciiBytes = Encoding.UTF8.GetBytes(text);
        fixed (byte* logMessagePtr = asciiBytes)
        {
            ObsBase.blog(ObsBase.LOG_INFO, (sbyte*) logMessagePtr);
        }
    }
}
