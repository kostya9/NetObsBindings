using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class TextLookup
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lookup_t *")]
    public static extern text_lookup* text_lookup_create([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte text_lookup_add([NativeTypeName("lookup_t *")] text_lookup* lookup, [NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void text_lookup_destroy([NativeTypeName("lookup_t *")] text_lookup* lookup);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte text_lookup_getstr([NativeTypeName("lookup_t *")] text_lookup* lookup, [NativeTypeName("const char *")] sbyte* lookup_val, [NativeTypeName("const char **")] sbyte** @out);
}
