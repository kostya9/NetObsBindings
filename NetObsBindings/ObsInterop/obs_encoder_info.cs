namespace ObsInterop;

public unsafe partial struct obs_encoder_info
{
    [NativeTypeName("const char *")]
    public sbyte* id;

    [NativeTypeName("enum obs_encoder_type")]
    public obs_encoder_type type;

    [NativeTypeName("const char *")]
    public sbyte* codec;

    [NativeTypeName("const char *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, sbyte*> get_name;

    [NativeTypeName("void *(*)(obs_data_t *, obs_encoder_t *)")]
    public delegate* unmanaged[Cdecl]<void*, obs_encoder*, void*> create;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> destroy;

    [NativeTypeName("bool (*)(void *, struct encoder_frame *, struct encoder_packet *, bool *)")]
    public delegate* unmanaged[Cdecl]<void*, encoder_frame*, encoder_packet*, bool*, byte> encode;

    [NativeTypeName("size_t (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, nuint> get_frame_size;

    [NativeTypeName("void (*)(obs_data_t *)")]
    public delegate* unmanaged[Cdecl]<void*, void> get_defaults;

    [NativeTypeName("obs_properties_t *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, obs_properties*> get_properties;

    [NativeTypeName("bool (*)(void *, obs_data_t *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, byte> update;

    [NativeTypeName("bool (*)(void *, uint8_t **, size_t *)")]
    public delegate* unmanaged[Cdecl]<void*, byte**, nuint*, byte> get_extra_data;

    [NativeTypeName("bool (*)(void *, uint8_t **, size_t *)")]
    public delegate* unmanaged[Cdecl]<void*, byte**, nuint*, byte> get_sei_data;

    [NativeTypeName("void (*)(void *, struct audio_convert_info *)")]
    public delegate* unmanaged[Cdecl]<void*, audio_convert_info*, void> get_audio_info;

    [NativeTypeName("void (*)(void *, struct video_scale_info *)")]
    public delegate* unmanaged[Cdecl]<void*, video_scale_info*, void> get_video_info;

    public void* type_data;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> free_type_data;

    [NativeTypeName("uint32_t")]
    public uint caps;

    [NativeTypeName("void (*)(obs_data_t *, void *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void> get_defaults2;

    [NativeTypeName("obs_properties_t *(*)(void *, void *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, obs_properties*> get_properties2;

    [NativeTypeName("bool (*)(void *, uint32_t, int64_t, uint64_t, uint64_t *, struct encoder_packet *, bool *)")]
    public delegate* unmanaged[Cdecl]<void*, uint, long, ulong, ulong*, encoder_packet*, bool*, byte> encode_texture;
}
