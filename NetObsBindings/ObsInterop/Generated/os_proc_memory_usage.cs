namespace ObsInterop;

public partial struct os_proc_memory_usage
{
    [NativeTypeName("uint64_t")]
    public ulong resident_size;

    [NativeTypeName("uint64_t")]
    public ulong virtual_size;
}
