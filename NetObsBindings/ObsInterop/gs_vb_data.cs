namespace ObsInterop;

public unsafe partial struct gs_vb_data
{
    [NativeTypeName("size_t")]
    public nuint num;

    [NativeTypeName("struct vec3 *")]
    public System.Numerics.Vector3* points;

    [NativeTypeName("struct vec3 *")]
    public System.Numerics.Vector3* normals;

    [NativeTypeName("struct vec3 *")]
    public System.Numerics.Vector3* tangents;

    [NativeTypeName("uint32_t *")]
    public uint* colors;

    [NativeTypeName("size_t")]
    public nuint num_tex;

    [NativeTypeName("struct gs_tvertarray *")]
    public gs_tvertarray* tvarray;
}
