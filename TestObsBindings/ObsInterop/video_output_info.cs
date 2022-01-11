namespace ObsInterop;

public unsafe partial struct video_output_info
{
    [NativeTypeName("const char *")]
    public sbyte* name;

    [NativeTypeName("enum video_format")]
    public video_format format;

    [NativeTypeName("uint32_t")]
    public uint fps_num;

    [NativeTypeName("uint32_t")]
    public uint fps_den;

    [NativeTypeName("uint32_t")]
    public uint width;

    [NativeTypeName("uint32_t")]
    public uint height;

    [NativeTypeName("size_t")]
    public nuint cache_size;

    [NativeTypeName("enum video_colorspace")]
    public video_colorspace colorspace;

    [NativeTypeName("enum video_range_type")]
    public video_range_type range;
}
