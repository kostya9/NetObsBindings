namespace ObsInterop;

public partial struct video_scale_info
{
    [NativeTypeName("enum video_format")]
    public video_format format;

    [NativeTypeName("uint32_t")]
    public uint width;

    [NativeTypeName("uint32_t")]
    public uint height;

    [NativeTypeName("enum video_range_type")]
    public video_range_type range;

    [NativeTypeName("enum video_colorspace")]
    public video_colorspace colorspace;
}
