namespace ObsInterop;

public unsafe partial struct gs_device_loss
{
    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> device_loss_release;

    [NativeTypeName("void (*)(void *, void *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void> device_loss_rebuild;

    public void* data;
}
