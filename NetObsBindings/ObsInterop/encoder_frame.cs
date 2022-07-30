namespace ObsInterop;

public unsafe partial struct encoder_frame
{
    [NativeTypeName("uint8_t *[8]")]
    public _data_e__FixedBuffer data;

    [NativeTypeName("uint32_t[8]")]
    public fixed uint linesize[8];

    [NativeTypeName("uint32_t")]
    public uint frames;

    [NativeTypeName("int64_t")]
    public long pts;

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
