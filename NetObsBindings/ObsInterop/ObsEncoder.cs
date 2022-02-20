using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsEncoder
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_register_encoder_s([NativeTypeName("const struct obs_encoder_info *")] obs_encoder_info* info, [NativeTypeName("size_t")] nuint size);
}
