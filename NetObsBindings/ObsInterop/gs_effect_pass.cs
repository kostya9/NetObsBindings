namespace ObsInterop;

public unsafe partial struct gs_effect_pass
{
    [NativeTypeName("char *")]
    public sbyte* name;

    [NativeTypeName("enum effect_section")]
    public effect_section section;

    [NativeTypeName("gs_shader_t *")]
    public gs_shader* vertshader;

    [NativeTypeName("gs_shader_t *")]
    public gs_shader* pixelshader;

    public pass_shaderparam_array_t vertshader_params;

    public pass_shaderparam_array_t pixelshader_params;
}
