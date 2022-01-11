namespace ObsInterop;

public partial struct obs_audio_info
{
    [NativeTypeName("uint32_t")]
    public uint samples_per_sec;

    [NativeTypeName("enum speaker_layout")]
    public speaker_layout speakers;
}
