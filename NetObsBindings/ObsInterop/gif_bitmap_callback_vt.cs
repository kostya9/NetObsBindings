namespace ObsInterop;

public unsafe partial struct gif_bitmap_callback_vt
{
    [NativeTypeName("gif_bitmap_cb_create")]
    public delegate* unmanaged[Cdecl]<int, int, void*> bitmap_create;

    [NativeTypeName("gif_bitmap_cb_destroy")]
    public delegate* unmanaged[Cdecl]<void*, void> bitmap_destroy;

    [NativeTypeName("gif_bitmap_cb_get_buffer")]
    public delegate* unmanaged[Cdecl]<void*, byte*> bitmap_get_buffer;

    [NativeTypeName("gif_bitmap_cb_set_opaque")]
    public delegate* unmanaged[Cdecl]<void*, byte, void> bitmap_set_opaque;

    [NativeTypeName("gif_bitmap_cb_test_opaque")]
    public delegate* unmanaged[Cdecl]<void*, byte> bitmap_test_opaque;

    [NativeTypeName("gif_bitmap_cb_modified")]
    public delegate* unmanaged[Cdecl]<void*, void> bitmap_modified;
}
