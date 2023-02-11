namespace ObsInterop;

public partial struct matrix4
{
    [NativeTypeName("struct vec4")]
    public System.Numerics.Vector4 x;

    [NativeTypeName("struct vec4")]
    public System.Numerics.Vector4 y;

    [NativeTypeName("struct vec4")]
    public System.Numerics.Vector4 z;

    [NativeTypeName("struct vec4")]
    public System.Numerics.Vector4 t;
}
