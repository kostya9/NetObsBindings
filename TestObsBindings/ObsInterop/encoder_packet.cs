namespace ObsInterop;

public unsafe partial struct encoder_packet
{
    [NativeTypeName("uint8_t *")]
    public byte* data;

    [NativeTypeName("size_t")]
    public nuint size;

    [NativeTypeName("int64_t")]
    public long pts;

    [NativeTypeName("int64_t")]
    public long dts;

    [NativeTypeName("int32_t")]
    public int timebase_num;

    [NativeTypeName("int32_t")]
    public int timebase_den;

    [NativeTypeName("enum obs_encoder_type")]
    public obs_encoder_type type;

    public bool keyframe;

    [NativeTypeName("int64_t")]
    public long dts_usec;

    [NativeTypeName("int64_t")]
    public long sys_dts_usec;

    public int priority;

    public int drop_priority;

    [NativeTypeName("size_t")]
    public nuint track_idx;

    [NativeTypeName("obs_encoder_t *")]
    public obs_encoder* encoder;
}
