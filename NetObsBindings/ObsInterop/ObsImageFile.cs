using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsImageFile
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_image_file_init([NativeTypeName("gs_image_file_t *")] gs_image_file* image, [NativeTypeName("const char *")] sbyte* file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_image_file_free([NativeTypeName("gs_image_file_t *")] gs_image_file* image);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_image_file_init_texture([NativeTypeName("gs_image_file_t *")] gs_image_file* image);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_image_file_tick([NativeTypeName("gs_image_file_t *")] gs_image_file* image, [NativeTypeName("uint64_t")] ulong elapsed_time_ns);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_image_file_update_texture([NativeTypeName("gs_image_file_t *")] gs_image_file* image);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_image_file2_init([NativeTypeName("gs_image_file2_t *")] gs_image_file2* if2, [NativeTypeName("const char *")] sbyte* file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_image_file2_tick([NativeTypeName("gs_image_file2_t *")] gs_image_file2* if2, [NativeTypeName("uint64_t")] ulong elapsed_time_ns);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_image_file2_update_texture([NativeTypeName("gs_image_file2_t *")] gs_image_file2* if2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_image_file3_init([NativeTypeName("gs_image_file3_t *")] gs_image_file3* if3, [NativeTypeName("const char *")] sbyte* file, [NativeTypeName("enum gs_image_alpha_mode")] gs_image_alpha_mode alpha_mode);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_image_file3_tick([NativeTypeName("gs_image_file3_t *")] gs_image_file3* if3, [NativeTypeName("uint64_t")] ulong elapsed_time_ns);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_image_file3_update_texture([NativeTypeName("gs_image_file3_t *")] gs_image_file3* if3);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_image_file4_init([NativeTypeName("gs_image_file4_t *")] gs_image_file4* if4, [NativeTypeName("const char *")] sbyte* file, [NativeTypeName("enum gs_image_alpha_mode")] gs_image_alpha_mode alpha_mode);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_image_file4_tick([NativeTypeName("gs_image_file4_t *")] gs_image_file4* if4, [NativeTypeName("uint64_t")] ulong elapsed_time_ns);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_image_file4_update_texture([NativeTypeName("gs_image_file4_t *")] gs_image_file4* if4);
}
