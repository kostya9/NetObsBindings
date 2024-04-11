using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsVideoScaler
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int video_scaler_create([NativeTypeName("video_scaler_t **")] video_scaler** scaler, [NativeTypeName("const struct video_scale_info *")] video_scale_info* dst, [NativeTypeName("const struct video_scale_info *")] video_scale_info* src, [NativeTypeName("enum video_scale_type")] video_scale_type type);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void video_scaler_destroy([NativeTypeName("video_scaler_t *")] video_scaler* scaler);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte video_scaler_scale([NativeTypeName("video_scaler_t *")] video_scaler* scaler, [NativeTypeName("uint8_t *[]")] byte** output, [NativeTypeName("const uint32_t[]")] uint* out_linesize, [NativeTypeName("const uint8_t *const[]")] byte** input, [NativeTypeName("const uint32_t[]")] uint* in_linesize);

    [NativeTypeName("#define VIDEO_SCALER_SUCCESS 0")]
    public const int VIDEO_SCALER_SUCCESS = 0;

    [NativeTypeName("#define VIDEO_SCALER_BAD_CONVERSION -1")]
    public const int VIDEO_SCALER_BAD_CONVERSION = -1;

    [NativeTypeName("#define VIDEO_SCALER_FAILED -2")]
    public const int VIDEO_SCALER_FAILED = -2;
}
