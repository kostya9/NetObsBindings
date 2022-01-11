namespace ObsInterop;

public unsafe partial struct gs_shader_param_info
{
    [NativeTypeName("enum gs_shader_param_type")]
    public gs_shader_param_type type;

    [NativeTypeName("const char *")]
    public sbyte* name;
}
