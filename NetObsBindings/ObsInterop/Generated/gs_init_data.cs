namespace ObsInterop;

public partial struct gs_init_data
{
    [NativeTypeName("struct gs_window")]
    public gs_window window;

    [NativeTypeName("uint32_t")]
    public uint cx;

    [NativeTypeName("uint32_t")]
    public uint cy;

    [NativeTypeName("uint32_t")]
    public uint num_backbuffers;

    [NativeTypeName("enum gs_color_format")]
    public gs_color_format format;

    [NativeTypeName("enum gs_zstencil_format")]
    public gs_zstencil_format zsformat;

    [NativeTypeName("uint32_t")]
    public uint adapter;
}
