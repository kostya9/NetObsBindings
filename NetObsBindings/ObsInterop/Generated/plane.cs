namespace ObsInterop;

public partial struct plane
{
    [NativeTypeName("struct vec3")]
    public System.Numerics.Vector3 dir;

    public float dist;
}
