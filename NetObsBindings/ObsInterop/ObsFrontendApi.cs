using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsFrontendApi
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* obs_frontend_get_main_window();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* obs_frontend_get_main_window_handle();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* obs_frontend_get_system_tray();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern sbyte** obs_frontend_get_scene_names();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_get_scenes([NativeTypeName("struct obs_frontend_source_list *")] obs_frontend_source_list* sources);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern obs_source* obs_frontend_get_current_scene();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_set_current_scene([NativeTypeName("obs_source_t *")] obs_source* scene);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_get_transitions([NativeTypeName("struct obs_frontend_source_list *")] obs_frontend_source_list* sources);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern obs_source* obs_frontend_get_current_transition();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_set_current_transition([NativeTypeName("obs_source_t *")] obs_source* transition);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int obs_frontend_get_transition_duration();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_set_transition_duration(int duration);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_release_tbar();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_set_tbar_position(int position);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int obs_frontend_get_tbar_position();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern sbyte** obs_frontend_get_scene_collections();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* obs_frontend_get_current_scene_collection();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_set_current_scene_collection([NativeTypeName("const char *")] sbyte* collection);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_frontend_add_scene_collection([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern sbyte** obs_frontend_get_profiles();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* obs_frontend_get_current_profile();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* obs_frontend_get_current_profile_path();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_set_current_profile([NativeTypeName("const char *")] sbyte* profile);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_create_profile([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_duplicate_profile([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_delete_profile([NativeTypeName("const char *")] sbyte* profile);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* obs_frontend_add_tools_menu_qaction([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_add_tools_menu_item([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_frontend_cb")] delegate* unmanaged[Cdecl]<void*, void> callback, void* private_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* obs_frontend_add_dock(void* dock);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_add_event_callback([NativeTypeName("obs_frontend_event_cb")] delegate* unmanaged[Cdecl]<obs_frontend_event, void*, void> callback, void* private_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_remove_event_callback([NativeTypeName("obs_frontend_event_cb")] delegate* unmanaged[Cdecl]<obs_frontend_event, void*, void> callback, void* private_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_add_save_callback([NativeTypeName("obs_frontend_save_cb")] delegate* unmanaged[Cdecl]<obs_data*, byte, void*, void> callback, void* private_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_remove_save_callback([NativeTypeName("obs_frontend_save_cb")] delegate* unmanaged[Cdecl]<obs_data*, byte, void*, void> callback, void* private_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_add_preload_callback([NativeTypeName("obs_frontend_save_cb")] delegate* unmanaged[Cdecl]<obs_data*, byte, void*, void> callback, void* private_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_remove_preload_callback([NativeTypeName("obs_frontend_save_cb")] delegate* unmanaged[Cdecl]<obs_data*, byte, void*, void> callback, void* private_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_push_ui_translation([NativeTypeName("obs_frontend_translate_ui_cb")] delegate* unmanaged[Cdecl]<sbyte*, sbyte**, byte> translate);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_pop_ui_translation();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_streaming_start();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_streaming_stop();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_frontend_streaming_active();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_recording_start();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_recording_stop();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_frontend_recording_active();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_recording_pause([NativeTypeName("bool")] byte pause);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_frontend_recording_paused();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_frontend_recording_split_file();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_replay_buffer_start();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_replay_buffer_save();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_replay_buffer_stop();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_frontend_replay_buffer_active();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_open_projector([NativeTypeName("const char *")] sbyte* type, int monitor, [NativeTypeName("const char *")] sbyte* geometry, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_save();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_defer_save_begin();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_defer_save_end();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_output_t *")]
    public static extern obs_output* obs_frontend_get_streaming_output();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_output_t *")]
    public static extern obs_output* obs_frontend_get_recording_output();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_output_t *")]
    public static extern obs_output* obs_frontend_get_replay_buffer_output();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("config_t *")]
    public static extern config_data* obs_frontend_get_profile_config();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("config_t *")]
    public static extern config_data* obs_frontend_get_global_config();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_set_streaming_service([NativeTypeName("obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_service_t *")]
    public static extern obs_service* obs_frontend_get_streaming_service();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_save_streaming_service();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_frontend_preview_program_mode_active();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_set_preview_program_mode([NativeTypeName("bool")] byte enable);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_preview_program_trigger_transition();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_set_preview_enabled([NativeTypeName("bool")] byte enable);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_frontend_preview_enabled();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern obs_source* obs_frontend_get_current_preview_scene();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_set_current_preview_scene([NativeTypeName("obs_source_t *")] obs_source* scene);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_take_screenshot();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_take_source_screenshot([NativeTypeName("obs_source_t *")] obs_source* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_output_t *")]
    public static extern obs_output* obs_frontend_get_virtualcam_output();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_start_virtualcam();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_stop_virtualcam();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_frontend_virtualcam_active();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_reset_video();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_open_source_properties([NativeTypeName("obs_source_t *")] obs_source* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_open_source_filters([NativeTypeName("obs_source_t *")] obs_source* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_frontend_open_source_interaction([NativeTypeName("obs_source_t *")] obs_source* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* obs_frontend_get_current_record_output_path();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_frontend_get_locale_string([NativeTypeName("const char *")] sbyte* @string);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_frontend_is_theme_dark();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* obs_frontend_get_last_recording();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* obs_frontend_get_last_screenshot();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* obs_frontend_get_last_replay();

    [NativeTypeName("#define DARRAY_INVALID ((size_t)-1)")]
    public static readonly nuint DARRAY_INVALID = unchecked((nuint)(-1));
}
