namespace ObsInterop;

public unsafe partial struct obs_video_info
{
    [NativeTypeName("const char *")]
    public sbyte* graphics_module;

    [NativeTypeName("uint32_t")]
    public uint fps_num;

    [NativeTypeName("uint32_t")]
    public uint fps_den;

    [NativeTypeName("uint32_t")]
    public uint base_width;

    [NativeTypeName("uint32_t")]
    public uint base_height;

    [NativeTypeName("uint32_t")]
    public uint output_width;

    [NativeTypeName("uint32_t")]
    public uint output_height;

    [NativeTypeName("enum video_format")]
    public video_format output_format;

    [NativeTypeName("uint32_t")]
    public uint adapter;

    public bool gpu_conversion;

    [NativeTypeName("enum video_colorspace")]
    public video_colorspace colorspace;

    [NativeTypeName("enum video_range_type")]
    public video_range_type range;

    [NativeTypeName("enum obs_scale_type")]
    public obs_scale_type scale_type;
}
