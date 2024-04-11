namespace ObsInterop;

public partial struct obs_mouse_event
{
    [NativeTypeName("uint32_t")]
    public uint modifiers;

    [NativeTypeName("int32_t")]
    public int x;

    [NativeTypeName("int32_t")]
    public int y;
}
