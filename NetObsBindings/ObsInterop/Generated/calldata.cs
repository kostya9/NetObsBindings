namespace ObsInterop;

public unsafe partial struct calldata
{
    [NativeTypeName("uint8_t *")]
    public byte* stack;

    [NativeTypeName("size_t")]
    public nuint size;

    [NativeTypeName("size_t")]
    public nuint capacity;

    [NativeTypeName("bool")]
    public byte @fixed;
}
