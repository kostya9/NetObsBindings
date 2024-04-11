using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsLibnsgif
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gif_create(gif_animation* gif, gif_bitmap_callback_vt* bitmap_callbacks);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern gif_result gif_initialise(gif_animation* gif, [NativeTypeName("size_t")] nuint size, [NativeTypeName("unsigned char *")] byte* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern gif_result gif_decode_frame(gif_animation* gif, [NativeTypeName("unsigned int")] uint frame);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gif_finalise(gif_animation* gif);

    [NativeTypeName("#define GIF_MAX_LZW 12")]
    public const int GIF_MAX_LZW = 12;
}
