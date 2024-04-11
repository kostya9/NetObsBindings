using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsFormatConversion
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void compress_uyvx_to_i420([NativeTypeName("const uint8_t *")] byte* input, [NativeTypeName("uint32_t")] uint in_linesize, [NativeTypeName("uint32_t")] uint start_y, [NativeTypeName("uint32_t")] uint end_y, [NativeTypeName("uint8_t *[]")] byte** output, [NativeTypeName("const uint32_t[]")] uint* out_linesize);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void compress_uyvx_to_nv12([NativeTypeName("const uint8_t *")] byte* input, [NativeTypeName("uint32_t")] uint in_linesize, [NativeTypeName("uint32_t")] uint start_y, [NativeTypeName("uint32_t")] uint end_y, [NativeTypeName("uint8_t *[]")] byte** output, [NativeTypeName("const uint32_t[]")] uint* out_linesize);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void convert_uyvx_to_i444([NativeTypeName("const uint8_t *")] byte* input, [NativeTypeName("uint32_t")] uint in_linesize, [NativeTypeName("uint32_t")] uint start_y, [NativeTypeName("uint32_t")] uint end_y, [NativeTypeName("uint8_t *[]")] byte** output, [NativeTypeName("const uint32_t[]")] uint* out_linesize);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void decompress_nv12([NativeTypeName("const uint8_t *const[]")] byte** input, [NativeTypeName("const uint32_t[]")] uint* in_linesize, [NativeTypeName("uint32_t")] uint start_y, [NativeTypeName("uint32_t")] uint end_y, [NativeTypeName("uint8_t *")] byte* output, [NativeTypeName("uint32_t")] uint out_linesize);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void decompress_420([NativeTypeName("const uint8_t *const[]")] byte** input, [NativeTypeName("const uint32_t[]")] uint* in_linesize, [NativeTypeName("uint32_t")] uint start_y, [NativeTypeName("uint32_t")] uint end_y, [NativeTypeName("uint8_t *")] byte* output, [NativeTypeName("uint32_t")] uint out_linesize);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void decompress_422([NativeTypeName("const uint8_t *")] byte* input, [NativeTypeName("uint32_t")] uint in_linesize, [NativeTypeName("uint32_t")] uint start_y, [NativeTypeName("uint32_t")] uint end_y, [NativeTypeName("uint8_t *")] byte* output, [NativeTypeName("uint32_t")] uint out_linesize, [NativeTypeName("bool")] byte leading_lum);
}
