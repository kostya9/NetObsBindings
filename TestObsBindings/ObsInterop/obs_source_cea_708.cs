namespace ObsInterop;

public unsafe partial struct obs_source_cea_708
{
    [NativeTypeName("const uint8_t *")]
    public byte* data;

    [NativeTypeName("uint32_t")]
    public uint packets;

    [NativeTypeName("uint64_t")]
    public ulong timestamp;
}
