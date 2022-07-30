namespace ObsInterop;

public unsafe partial struct obs_module_failure_info
{
    [NativeTypeName("char **")]
    public sbyte** failed_modules;

    [NativeTypeName("size_t")]
    public nuint count;
}
