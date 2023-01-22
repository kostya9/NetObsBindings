namespace ObsInterop;

public partial struct profiler_time_entry
{
    [NativeTypeName("uint64_t")]
    public ulong time_delta;

    [NativeTypeName("uint64_t")]
    public ulong count;
}
