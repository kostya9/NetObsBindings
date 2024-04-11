namespace ObsInterop;

public unsafe partial struct darray
{
    public void* array;

    [NativeTypeName("size_t")]
    public nuint num;

    [NativeTypeName("size_t")]
    public nuint capacity;
}
