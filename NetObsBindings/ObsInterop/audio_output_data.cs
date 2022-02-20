namespace ObsInterop;

public partial struct audio_output_data
{
    [NativeTypeName("float *[8]")]
    public _data_e__FixedBuffer data;

    public unsafe partial struct _data_e__FixedBuffer
    {
        public float* e0;
        public float* e1;
        public float* e2;
        public float* e3;
        public float* e4;
        public float* e5;
        public float* e6;
        public float* e7;

        public ref float* this[int index]
        {
            get
            {
                fixed (float** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
