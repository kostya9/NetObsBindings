namespace ObsInterop;

public partial struct obs_encoder_roi
{
    [NativeTypeName("uint32_t")]
    public uint top;

    [NativeTypeName("uint32_t")]
    public uint bottom;

    [NativeTypeName("uint32_t")]
    public uint left;

    [NativeTypeName("uint32_t")]
    public uint right;

    public float priority;
}
