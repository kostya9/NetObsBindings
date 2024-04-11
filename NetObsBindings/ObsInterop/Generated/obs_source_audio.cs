namespace ObsInterop;

public partial struct obs_source_audio
{
    [NativeTypeName("const uint8_t *[8]")]
    public _data_e__FixedBuffer data;

    [NativeTypeName("uint32_t")]
    public uint frames;

    [NativeTypeName("enum speaker_layout")]
    public speaker_layout speakers;

    [NativeTypeName("enum audio_format")]
    public audio_format format;

    [NativeTypeName("uint32_t")]
    public uint samples_per_sec;

    [NativeTypeName("uint64_t")]
    public ulong timestamp;

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
