using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsSource
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_register_source_s([NativeTypeName("const struct obs_source_info *")] obs_source_info* info, [NativeTypeName("size_t")] nuint size);
}
