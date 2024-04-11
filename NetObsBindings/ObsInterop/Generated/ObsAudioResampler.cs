using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsAudioResampler
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("audio_resampler_t *")]
    public static extern audio_resampler* audio_resampler_create([NativeTypeName("const struct resample_info *")] resample_info* dst, [NativeTypeName("const struct resample_info *")] resample_info* src);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void audio_resampler_destroy([NativeTypeName("audio_resampler_t *")] audio_resampler* resampler);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte audio_resampler_resample([NativeTypeName("audio_resampler_t *")] audio_resampler* resampler, [NativeTypeName("uint8_t *[]")] byte** output, [NativeTypeName("uint32_t *")] uint* out_frames, [NativeTypeName("uint64_t *")] ulong* ts_offset, [NativeTypeName("const uint8_t *const[]")] byte** input, [NativeTypeName("uint32_t")] uint in_frames);
}
