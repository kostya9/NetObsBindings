namespace ObsInterop;

public partial struct obs_audio_info2
{
    [NativeTypeName("uint32_t")]
    public uint samples_per_sec;

    [NativeTypeName("enum speaker_layout")]
    public speaker_layout speakers;

    [NativeTypeName("uint32_t")]
    public uint max_buffering_ms;

    [NativeTypeName("bool")]
    public byte fixed_buffering;
}
