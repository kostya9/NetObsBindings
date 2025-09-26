namespace ObsInterop;

public partial struct encoder_packet_time
{
    [NativeTypeName("int64_t")]
    public long pts;

    [NativeTypeName("uint64_t")]
    public ulong cts;

    [NativeTypeName("uint64_t")]
    public ulong fer;

    [NativeTypeName("uint64_t")]
    public ulong ferc;

    [NativeTypeName("uint64_t")]
    public ulong pir;
}
