namespace ObsInterop;

public unsafe partial struct pass_shaderparam
{
    [NativeTypeName("struct gs_effect_param *")]
    public gs_effect_param* eparam;

    [NativeTypeName("gs_sparam_t *")]
    public gs_shader_param* sparam;
}
