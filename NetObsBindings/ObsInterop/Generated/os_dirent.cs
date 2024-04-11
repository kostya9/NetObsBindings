namespace ObsInterop;

public unsafe partial struct os_dirent
{
    [NativeTypeName("char[256]")]
    public fixed sbyte d_name[256];

    [NativeTypeName("bool")]
    public byte directory;
}
