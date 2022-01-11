namespace ObsInterop;

public unsafe partial struct gs_tvertarray
{
    [NativeTypeName("size_t")]
    public nuint width;

    public void* array;
}
