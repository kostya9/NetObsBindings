namespace ObsInterop;

public unsafe partial struct obs_source_info
{
    [NativeTypeName("const char *")]
    public sbyte* id;

    [NativeTypeName("enum obs_source_type")]
    public obs_source_type type;

    [NativeTypeName("uint32_t")]
    public uint output_flags;

    [NativeTypeName("const char *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, sbyte*> get_name;

    [NativeTypeName("void *(*)(obs_data_t *, obs_source_t *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void*> create;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> destroy;

    [NativeTypeName("uint32_t (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, uint> get_width;

    [NativeTypeName("uint32_t (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, uint> get_height;

    [NativeTypeName("void (*)(obs_data_t *)")]
    public delegate* unmanaged[Cdecl]<void*, void> get_defaults;

    [NativeTypeName("obs_properties_t *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void*> get_properties;

    [NativeTypeName("void (*)(void *, obs_data_t *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void> update;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> activate;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> deactivate;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> show;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> hide;

    [NativeTypeName("void (*)(void *, float)")]
    public delegate* unmanaged[Cdecl]<void*, float, void> video_tick;

    [NativeTypeName("void (*)(void *, gs_effect_t *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void> video_render;

    [NativeTypeName("struct obs_source_frame *(*)(void *, struct obs_source_frame *)")]
    public delegate* unmanaged[Cdecl]<void*, obs_source_frame*, obs_source_frame*> filter_video;

    [NativeTypeName("struct obs_audio_data *(*)(void *, struct obs_audio_data *)")]
    public delegate* unmanaged[Cdecl]<void*, obs_audio_data*, obs_audio_data*> filter_audio;

    [NativeTypeName("void (*)(void *, obs_source_enum_proc_t, void *)")]
    public delegate* unmanaged[Cdecl]<void*, delegate* unmanaged[Cdecl]<void*, void*, void*, void>, void*, void> enum_active_sources;

    [NativeTypeName("void (*)(void *, obs_data_t *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void> save;

    [NativeTypeName("void (*)(void *, obs_data_t *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void> load;

    [NativeTypeName("void (*)(void *, const struct obs_mouse_event *, int32_t, bool, uint32_t)")]
    public delegate* unmanaged[Cdecl]<void*, obs_mouse_event*, int, byte, uint, void> mouse_click;

    [NativeTypeName("void (*)(void *, const struct obs_mouse_event *, bool)")]
    public delegate* unmanaged[Cdecl]<void*, obs_mouse_event*, byte, void> mouse_move;

    [NativeTypeName("void (*)(void *, const struct obs_mouse_event *, int, int)")]
    public delegate* unmanaged[Cdecl]<void*, obs_mouse_event*, int, int, void> mouse_wheel;

    [NativeTypeName("void (*)(void *, bool)")]
    public delegate* unmanaged[Cdecl]<void*, byte, void> focus;

    [NativeTypeName("void (*)(void *, const struct obs_key_event *, bool)")]
    public delegate* unmanaged[Cdecl]<void*, obs_key_event*, byte, void> key_click;

    [NativeTypeName("void (*)(void *, obs_source_t *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void> filter_remove;

    public void* type_data;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> free_type_data;

    [NativeTypeName("bool (*)(void *, uint64_t *, struct obs_source_audio_mix *, uint32_t, size_t, size_t)")]
    public delegate* unmanaged[Cdecl]<void*, ulong*, obs_source_audio_mix*, uint, nuint, nuint, byte> audio_render;

    [NativeTypeName("void (*)(void *, obs_source_enum_proc_t, void *)")]
    public delegate* unmanaged[Cdecl]<void*, delegate* unmanaged[Cdecl]<void*, void*, void*, void>, void*, void> enum_all_sources;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> transition_start;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> transition_stop;

    [NativeTypeName("void (*)(void *, obs_data_t *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void> get_defaults2;

    [NativeTypeName("obs_properties_t *(*)(void *, void *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void*> get_properties2;

    [NativeTypeName("bool (*)(void *, uint64_t *, struct audio_output_data *, size_t, size_t)")]
    public delegate* unmanaged[Cdecl]<void*, ulong*, audio_output_data*, nuint, nuint, byte> audio_mix;

    [NativeTypeName("enum obs_icon_type")]
    public obs_icon_type icon_type;

    [NativeTypeName("void (*)(void *, bool)")]
    public delegate* unmanaged[Cdecl]<void*, byte, void> media_play_pause;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> media_restart;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> media_stop;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> media_next;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> media_previous;

    [NativeTypeName("int64_t (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, long> media_get_duration;

    [NativeTypeName("int64_t (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, long> media_get_time;

    [NativeTypeName("void (*)(void *, int64_t)")]
    public delegate* unmanaged[Cdecl]<void*, long, void> media_set_time;

    [NativeTypeName("enum obs_media_state (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, obs_media_state> media_get_state;

    [NativeTypeName("uint32_t")]
    public uint version;

    [NativeTypeName("const char *")]
    public sbyte* unversioned_id;

    [NativeTypeName("obs_missing_files_t *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void*> missing_files;
}
