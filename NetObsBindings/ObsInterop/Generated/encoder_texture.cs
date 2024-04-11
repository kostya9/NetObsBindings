namespace ObsInterop;

public partial struct encoder_texture
{
    [NativeTypeName("uint32_t")]
    public uint handle;

    [NativeTypeName("struct gs_texture *[4]")]
    public _tex_e__FixedBuffer tex;

    public unsafe partial struct _tex_e__FixedBuffer
    {
        public gs_texture* e0;
        public gs_texture* e1;
        public gs_texture* e2;
        public gs_texture* e3;

        public ref gs_texture* this[int index]
        {
            get
            {
                fixed (gs_texture** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
