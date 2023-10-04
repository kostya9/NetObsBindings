namespace ObsInterop;

public unsafe partial struct os_glob_info
{
    [NativeTypeName("size_t")]
    public nuint gl_pathc;

    [NativeTypeName("struct os_globent *")]
    public os_globent* gl_pathv;
}
