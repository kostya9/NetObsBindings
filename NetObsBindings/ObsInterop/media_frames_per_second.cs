namespace ObsInterop;

public partial struct media_frames_per_second
{
    [NativeTypeName("uint32_t")]
    public uint numerator;

    [NativeTypeName("uint32_t")]
    public uint denominator;
}
