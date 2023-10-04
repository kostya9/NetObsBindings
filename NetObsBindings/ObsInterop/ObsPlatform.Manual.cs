using System.Diagnostics;

namespace ObsInterop;

/// <summary>
/// This method contains bindings generated form platform.h header file in the OBS library.
/// <para />
/// [IMPORTANT] Please use with care and prefer .NET APIs whenever possible. 
/// <para />
/// For example, the os_cpu_usage_info_start() method returns a pointer to the struct that has different layout in different systems.
/// </summary>
public partial class ObsPlatform
{
    public static readonly unsafe int ARCH_BITS = sizeof(nint) * 8;
}