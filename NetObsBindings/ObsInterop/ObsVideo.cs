using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsVideo
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum video_format")]
    public static extern video_format video_format_from_fourcc([NativeTypeName("uint32_t")] uint fourcc);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte video_format_get_parameters([NativeTypeName("enum video_colorspace")] video_colorspace color_space, [NativeTypeName("enum video_range_type")] video_range_type range, [NativeTypeName("float[16]")] float* matrix, [NativeTypeName("float[3]")] float* min_range, [NativeTypeName("float[3]")] float* max_range);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte video_format_get_parameters_for_format([NativeTypeName("enum video_colorspace")] video_colorspace color_space, [NativeTypeName("enum video_range_type")] video_range_type range, [NativeTypeName("enum video_format")] video_format format, [NativeTypeName("float[16]")] float* matrix, [NativeTypeName("float[3]")] float* min_range, [NativeTypeName("float[3]")] float* max_range);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int video_output_open([NativeTypeName("video_t **")] video_output** video, [NativeTypeName("struct video_output_info *")] video_output_info* info);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void video_output_close([NativeTypeName("video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte video_output_connect([NativeTypeName("video_t *")] video_output* video, [NativeTypeName("const struct video_scale_info *")] video_scale_info* conversion, [NativeTypeName("void (*)(void *, struct video_data *)")] delegate* unmanaged[Cdecl]<void*, video_data*, void> callback, void* param3);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte video_output_connect2([NativeTypeName("video_t *")] video_output* video, [NativeTypeName("const struct video_scale_info *")] video_scale_info* conversion, [NativeTypeName("uint32_t")] uint frame_rate_divisor, [NativeTypeName("void (*)(void *, struct video_data *)")] delegate* unmanaged[Cdecl]<void*, video_data*, void> callback, void* param4);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void video_output_disconnect([NativeTypeName("video_t *")] video_output* video, [NativeTypeName("void (*)(void *, struct video_data *)")] delegate* unmanaged[Cdecl]<void*, video_data*, void> callback, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte video_output_active([NativeTypeName("const video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const struct video_output_info *")]
    public static extern video_output_info* video_output_get_info([NativeTypeName("const video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte video_output_lock_frame([NativeTypeName("video_t *")] video_output* video, [NativeTypeName("struct video_frame *")] video_frame* frame, int count, [NativeTypeName("uint64_t")] ulong timestamp);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void video_output_unlock_frame([NativeTypeName("video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong video_output_get_frame_time([NativeTypeName("const video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void video_output_stop([NativeTypeName("video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte video_output_stopped([NativeTypeName("video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum video_format")]
    public static extern video_format video_output_get_format([NativeTypeName("const video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint video_output_get_width([NativeTypeName("const video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint video_output_get_height([NativeTypeName("const video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double video_output_get_frame_rate([NativeTypeName("const video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint video_output_get_skipped_frames([NativeTypeName("const video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint video_output_get_total_frames([NativeTypeName("const video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void video_output_inc_texture_encoders([NativeTypeName("video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void video_output_dec_texture_encoders([NativeTypeName("video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void video_output_inc_texture_frames([NativeTypeName("video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void video_output_inc_texture_skipped_frames([NativeTypeName("video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("video_t *")]
    public static extern video_output* video_output_create_with_frame_rate_divisor([NativeTypeName("video_t *")] video_output* video, [NativeTypeName("uint32_t")] uint divisor);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void video_output_free_frame_rate_divisor([NativeTypeName("video_t *")] video_output* video);

    [NativeTypeName("#define VIDEO_OUTPUT_SUCCESS 0")]
    public const int VIDEO_OUTPUT_SUCCESS = 0;

    [NativeTypeName("#define VIDEO_OUTPUT_INVALIDPARAM -1")]
    public const int VIDEO_OUTPUT_INVALIDPARAM = -1;

    [NativeTypeName("#define VIDEO_OUTPUT_FAIL -2")]
    public const int VIDEO_OUTPUT_FAIL = -2;
}
