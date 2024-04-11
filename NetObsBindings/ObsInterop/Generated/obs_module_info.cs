namespace ObsInterop;

public unsafe partial struct obs_module_info
{
    [NativeTypeName("const char *")]
    public sbyte* bin_path;

    [NativeTypeName("const char *")]
    public sbyte* data_path;
}
