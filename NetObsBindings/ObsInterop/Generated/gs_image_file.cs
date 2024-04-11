namespace ObsInterop;

public unsafe partial struct gs_image_file
{
    [NativeTypeName("gs_texture_t *")]
    public gs_texture* texture;

    [NativeTypeName("enum gs_color_format")]
    public gs_color_format format;

    [NativeTypeName("uint32_t")]
    public uint cx;

    [NativeTypeName("uint32_t")]
    public uint cy;

    [NativeTypeName("bool")]
    public byte is_animated_gif;

    [NativeTypeName("bool")]
    public byte frame_updated;

    [NativeTypeName("bool")]
    public byte loaded;

    public gif_animation gif;

    [NativeTypeName("uint8_t *")]
    public byte* gif_data;

    [NativeTypeName("uint8_t **")]
    public byte** animation_frame_cache;

    [NativeTypeName("uint8_t *")]
    public byte* animation_frame_data;

    [NativeTypeName("uint64_t")]
    public ulong cur_time;

    public int cur_frame;

    public int cur_loop;

    public int last_decoded_frame;

    [NativeTypeName("uint8_t *")]
    public byte* texture_data;

    public gif_bitmap_callback_vt bitmap_callbacks;
}
