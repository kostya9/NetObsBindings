using System;
using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsBmem
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [Obsolete]
    public static extern void base_set_allocator([NativeTypeName("struct base_allocator *")] base_allocator* defs);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* bmalloc([NativeTypeName("size_t")] nuint size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* brealloc(void* ptr, [NativeTypeName("size_t")] nuint size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void bfree(void* ptr);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int base_get_alignment();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("long")]
    public static extern int bnum_allocs();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* bmemdup([NativeTypeName("const void *")] void* ptr, [NativeTypeName("size_t")] nuint size);
}
