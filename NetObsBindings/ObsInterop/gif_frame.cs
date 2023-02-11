namespace ObsInterop;

public partial struct gif_frame
{
    [NativeTypeName("bool")]
    public byte display;

    [NativeTypeName("unsigned int")]
    public uint frame_delay;

    [NativeTypeName("unsigned int")]
    public uint frame_pointer;

    [NativeTypeName("bool")]
    public byte virgin;

    [NativeTypeName("bool")]
    public byte opaque;

    [NativeTypeName("bool")]
    public byte redraw_required;

    [NativeTypeName("unsigned char")]
    public byte disposal_method;

    [NativeTypeName("bool")]
    public byte transparency;

    [NativeTypeName("unsigned char")]
    public byte transparency_index;

    [NativeTypeName("unsigned int")]
    public uint redraw_x;

    [NativeTypeName("unsigned int")]
    public uint redraw_y;

    [NativeTypeName("unsigned int")]
    public uint redraw_width;

    [NativeTypeName("unsigned int")]
    public uint redraw_height;
}
