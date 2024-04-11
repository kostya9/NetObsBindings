namespace ObsInterop;

public partial struct gs_display_mode
{
    [NativeTypeName("uint32_t")]
    public uint width;

    [NativeTypeName("uint32_t")]
    public uint height;

    [NativeTypeName("uint32_t")]
    public uint bits;

    [NativeTypeName("uint32_t")]
    public uint freq;
}
