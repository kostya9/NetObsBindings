namespace ObsInterop;

public unsafe partial struct gs_shader_texture
{
    [NativeTypeName("gs_texture_t *")]
    public gs_texture* tex;

    public bool srgb;
}
