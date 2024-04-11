namespace ObsInterop;

public partial struct gs_image_file2
{
    [NativeTypeName("struct gs_image_file")]
    public gs_image_file image;

    [NativeTypeName("uint64_t")]
    public ulong mem_usage;
}
