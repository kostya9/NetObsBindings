namespace ObsInterop;

public unsafe partial struct obs_key_event
{
    [NativeTypeName("uint32_t")]
    public uint modifiers;

    [NativeTypeName("char *")]
    public sbyte* text;

    [NativeTypeName("uint32_t")]
    public uint native_modifiers;

    [NativeTypeName("uint32_t")]
    public uint native_scancode;

    [NativeTypeName("uint32_t")]
    public uint native_vkey;
}
