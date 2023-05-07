namespace ObsInterop;

public unsafe partial struct obs_output_info
{
    [NativeTypeName("const char *")]
    public sbyte* id;

    [NativeTypeName("uint32_t")]
    public uint flags;

    [NativeTypeName("const char *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, sbyte*> get_name;

    [NativeTypeName("void *(*)(obs_data_t *, obs_output_t *)")]
    public delegate* unmanaged[Cdecl]<obs_data*, obs_output*, void*> create;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> destroy;

    [NativeTypeName("bool (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, byte> start;

    [NativeTypeName("void (*)(void *, uint64_t)")]
    public delegate* unmanaged[Cdecl]<void*, ulong, void> stop;

    [NativeTypeName("void (*)(void *, struct video_data *)")]
    public delegate* unmanaged[Cdecl]<void*, video_data*, void> raw_video;

    [NativeTypeName("void (*)(void *, struct audio_data *)")]
    public delegate* unmanaged[Cdecl]<void*, audio_data*, void> raw_audio;

    [NativeTypeName("void (*)(void *, struct encoder_packet *)")]
    public delegate* unmanaged[Cdecl]<void*, encoder_packet*, void> encoded_packet;

    [NativeTypeName("void (*)(void *, obs_data_t *)")]
    public delegate* unmanaged[Cdecl]<void*, obs_data*, void> update;

    [NativeTypeName("void (*)(obs_data_t *)")]
    public delegate* unmanaged[Cdecl]<obs_data*, void> get_defaults;

    [NativeTypeName("obs_properties_t *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, obs_properties*> get_properties;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> unused1;

    [NativeTypeName("uint64_t (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, ulong> get_total_bytes;

    [NativeTypeName("int (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, int> get_dropped_frames;

    public void* type_data;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> free_type_data;

    [NativeTypeName("float (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, float> get_congestion;

    [NativeTypeName("int (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, int> get_connect_time_ms;

    [NativeTypeName("const char *")]
    public sbyte* encoded_video_codecs;

    [NativeTypeName("const char *")]
    public sbyte* encoded_audio_codecs;

    [NativeTypeName("void (*)(void *, size_t, struct audio_data *)")]
    public delegate* unmanaged[Cdecl]<void*, nuint, audio_data*, void> raw_audio2;

    [NativeTypeName("const char *")]
    public sbyte* protocols;
}
