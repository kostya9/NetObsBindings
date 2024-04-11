using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsEffect
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void effect_param_parse_property([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("const char *")] sbyte* property);
}
