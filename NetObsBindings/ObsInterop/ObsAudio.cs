using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsAudio
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int audio_output_open([NativeTypeName("audio_t **")] audio_output** audio, [NativeTypeName("struct audio_output_info *")] audio_output_info* info);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void audio_output_close([NativeTypeName("audio_t *")] audio_output* audio);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte audio_output_connect([NativeTypeName("audio_t *")] audio_output* video, [NativeTypeName("size_t")] nuint mix_idx, [NativeTypeName("const struct audio_convert_info *")] audio_convert_info* conversion, [NativeTypeName("audio_output_callback_t")] delegate* unmanaged[Cdecl]<void*, nuint, audio_data*, void> callback, void* param4);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void audio_output_disconnect([NativeTypeName("audio_t *")] audio_output* video, [NativeTypeName("size_t")] nuint mix_idx, [NativeTypeName("audio_output_callback_t")] delegate* unmanaged[Cdecl]<void*, nuint, audio_data*, void> callback, void* param3);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte audio_output_active([NativeTypeName("const audio_t *")] audio_output* audio);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint audio_output_get_block_size([NativeTypeName("const audio_t *")] audio_output* audio);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint audio_output_get_planes([NativeTypeName("const audio_t *")] audio_output* audio);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint audio_output_get_channels([NativeTypeName("const audio_t *")] audio_output* audio);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint audio_output_get_sample_rate([NativeTypeName("const audio_t *")] audio_output* audio);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const struct audio_output_info *")]
    public static extern audio_output_info* audio_output_get_info([NativeTypeName("const audio_t *")] audio_output* audio);
}
