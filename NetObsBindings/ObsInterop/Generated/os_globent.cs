namespace ObsInterop;

public unsafe partial struct os_globent
{
    [NativeTypeName("char *")]
    public sbyte* path;

    [NativeTypeName("bool")]
    public byte directory;
}
