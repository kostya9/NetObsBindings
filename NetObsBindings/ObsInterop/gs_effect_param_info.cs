namespace ObsInterop;

public unsafe partial struct gs_effect_param_info
{
    [NativeTypeName("const char *")]
    public sbyte* name;

    [NativeTypeName("enum gs_shader_param_type")]
    public gs_shader_param_type type;
}
