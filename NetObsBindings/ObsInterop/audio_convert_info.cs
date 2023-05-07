namespace ObsInterop;

public partial struct audio_convert_info
{
    [NativeTypeName("uint32_t")]
    public uint samples_per_sec;

    [NativeTypeName("enum audio_format")]
    public audio_format format;

    [NativeTypeName("enum speaker_layout")]
    public speaker_layout speakers;

    [NativeTypeName("bool")]
    public byte allow_clipping;
}
