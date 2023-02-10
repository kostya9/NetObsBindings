namespace ObsInterop;

public partial struct resample_info
{
    [NativeTypeName("uint32_t")]
    public uint samples_per_sec;

    [NativeTypeName("enum audio_format")]
    public audio_format format;

    [NativeTypeName("enum speaker_layout")]
    public speaker_layout speakers;
}
