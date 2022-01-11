namespace ObsInterop;

public unsafe partial struct audio_output_info
{
    [NativeTypeName("const char *")]
    public sbyte* name;

    [NativeTypeName("uint32_t")]
    public uint samples_per_sec;

    [NativeTypeName("enum audio_format")]
    public audio_format format;

    [NativeTypeName("enum speaker_layout")]
    public speaker_layout speakers;

    [NativeTypeName("audio_input_callback_t")]
    public delegate* unmanaged[Cdecl]<void*, ulong, ulong, ulong*, uint, audio_output_data*, byte> input_callback;

    public void* input_param;
}
