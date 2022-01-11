using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsService
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_register_service_s([NativeTypeName("const struct obs_service_info *")] obs_service_info* info, [NativeTypeName("size_t")] nuint size);
}
