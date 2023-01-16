namespace ObsInterop;

public unsafe partial struct obs_service_info
{
    [NativeTypeName("const char *")]
    public sbyte* id;

    [NativeTypeName("const char *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, sbyte*> get_name;

    [NativeTypeName("void *(*)(obs_data_t *, obs_service_t *)")]
    public delegate* unmanaged[Cdecl]<obs_data*, obs_service*, void*> create;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> destroy;

    [NativeTypeName("void (*)(void *, obs_data_t *)")]
    public delegate* unmanaged[Cdecl]<void*, obs_data*, void> activate;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> deactivate;

    [NativeTypeName("void (*)(void *, obs_data_t *)")]
    public delegate* unmanaged[Cdecl]<void*, obs_data*, void> update;

    [NativeTypeName("void (*)(obs_data_t *)")]
    public delegate* unmanaged[Cdecl]<obs_data*, void> get_defaults;

    [NativeTypeName("obs_properties_t *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, obs_properties*> get_properties;

    [NativeTypeName("bool (*)(void *, obs_output_t *)")]
    public delegate* unmanaged[Cdecl]<void*, obs_output*, byte> initialize;

    [NativeTypeName("const char *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, sbyte*> get_url;

    [NativeTypeName("const char *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, sbyte*> get_key;

    [NativeTypeName("const char *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, sbyte*> get_username;

    [NativeTypeName("const char *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, sbyte*> get_password;

    [NativeTypeName("bool (*)()")]
    public delegate* unmanaged[Cdecl]<byte> deprecated_1;

    [NativeTypeName("void (*)(void *, obs_data_t *, obs_data_t *)")]
    public delegate* unmanaged[Cdecl]<void*, obs_data*, obs_data*, void> apply_encoder_settings;

    public void* type_data;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> free_type_data;

    [NativeTypeName("const char *(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, sbyte*> get_output_type;

    [NativeTypeName("void (*)(void *, struct obs_service_resolution **, size_t *)")]
    public delegate* unmanaged[Cdecl]<void*, obs_service_resolution**, nuint*, void> get_supported_resolutions;

    [NativeTypeName("void (*)(void *, int *)")]
    public delegate* unmanaged[Cdecl]<void*, int*, void> get_max_fps;

    [NativeTypeName("void (*)(void *, int *, int *)")]
    public delegate* unmanaged[Cdecl]<void*, int*, int*, void> get_max_bitrate;

    [NativeTypeName("const char **(*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, sbyte**> get_supported_video_codecs;
}
