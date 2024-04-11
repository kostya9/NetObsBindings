namespace ObsInterop;

public partial struct matrix3
{
    [NativeTypeName("struct vec3")]
    public System.Numerics.Vector3 x;

    [NativeTypeName("struct vec3")]
    public System.Numerics.Vector3 y;

    [NativeTypeName("struct vec3")]
    public System.Numerics.Vector3 z;

    [NativeTypeName("struct vec3")]
    public System.Numerics.Vector3 t;
}
