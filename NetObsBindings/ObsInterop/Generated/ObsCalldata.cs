using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsCalldata
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte calldata_get_data([NativeTypeName("const calldata_t *")] calldata* data, [NativeTypeName("const char *")] sbyte* name, void* @out, [NativeTypeName("size_t")] nuint size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void calldata_set_data([NativeTypeName("calldata_t *")] calldata* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const void *")] void* @in, [NativeTypeName("size_t")] nuint new_size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte calldata_get_string([NativeTypeName("const calldata_t *")] calldata* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char **")] sbyte** str);

    [NativeTypeName("#define CALL_PARAM_IN (1 << 0)")]
    public const int CALL_PARAM_IN = (1 << 0);

    [NativeTypeName("#define CALL_PARAM_OUT (1 << 1)")]
    public const int CALL_PARAM_OUT = (1 << 1);
}
