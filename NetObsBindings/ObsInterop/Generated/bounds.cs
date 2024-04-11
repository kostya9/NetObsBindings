namespace ObsInterop;

public partial struct bounds
{
    [NativeTypeName("struct vec3")]
    public System.Numerics.Vector3 min;

    [NativeTypeName("struct vec3")]
    public System.Numerics.Vector3 max;
}
