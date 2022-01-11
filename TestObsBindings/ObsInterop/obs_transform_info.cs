namespace ObsInterop;

public partial struct obs_transform_info
{
    [NativeTypeName("struct vec2")]
    public System.Numerics.Vector2 pos;

    public float rot;

    [NativeTypeName("struct vec2")]
    public System.Numerics.Vector2 scale;

    [NativeTypeName("uint32_t")]
    public uint alignment;

    [NativeTypeName("enum obs_bounds_type")]
    public obs_bounds_type bounds_type;

    [NativeTypeName("uint32_t")]
    public uint bounds_alignment;

    [NativeTypeName("struct vec2")]
    public System.Numerics.Vector2 bounds;
}
