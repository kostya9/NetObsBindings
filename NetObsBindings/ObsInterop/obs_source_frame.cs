namespace ObsInterop;

public unsafe partial struct obs_source_frame
{
    [NativeTypeName("uint8_t *[8]")]
    public _data_e__FixedBuffer data;

    [NativeTypeName("uint32_t [8]")]
    public fixed uint linesize[8];

    [NativeTypeName("uint32_t")]
    public uint width;

    [NativeTypeName("uint32_t")]
    public uint height;

    [NativeTypeName("uint64_t")]
    public ulong timestamp;

    [NativeTypeName("enum video_format")]
    public video_format format;

    [NativeTypeName("float [16]")]
    public fixed float color_matrix[16];

    public bool full_range;

    [NativeTypeName("float [3]")]
    public fixed float color_range_min[3];

    [NativeTypeName("float [3]")]
    public fixed float color_range_max[3];

    public bool flip;

    [NativeTypeName("uint8_t")]
    public byte flags;

    [NativeTypeName("volatile long")]
    public int refs;

    public bool prev_frame;

    public unsafe partial struct _data_e__FixedBuffer
    {
        public byte* e0;
        public byte* e1;
        public byte* e2;
        public byte* e3;
        public byte* e4;
        public byte* e5;
        public byte* e6;
        public byte* e7;

        public ref byte* this[int index]
        {
            get
            {
                fixed (byte** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
