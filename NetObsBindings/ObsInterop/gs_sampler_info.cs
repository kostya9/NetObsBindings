namespace ObsInterop;

public partial struct gs_sampler_info
{
    [NativeTypeName("enum gs_sample_filter")]
    public gs_sample_filter filter;

    [NativeTypeName("enum gs_address_mode")]
    public gs_address_mode address_u;

    [NativeTypeName("enum gs_address_mode")]
    public gs_address_mode address_v;

    [NativeTypeName("enum gs_address_mode")]
    public gs_address_mode address_w;

    public int max_anisotropy;

    [NativeTypeName("uint32_t")]
    public uint border_color;
}
