using System;
using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class Obs
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* obs_find_data_file([NativeTypeName("const char *")] sbyte* file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_add_data_path([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_remove_data_path([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_startup([NativeTypeName("const char *")] sbyte* locale, [NativeTypeName("const char *")] sbyte* module_config_path, [NativeTypeName("profiler_name_store_t *")] void* store);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_shutdown();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_initialized();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_get_version();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_get_version_string();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_set_cmdline_args(int argc, [NativeTypeName("const char *const *")] sbyte** argv);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("struct obs_cmdline_args")]
    public static extern obs_cmdline_args obs_get_cmdline_args();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_set_locale([NativeTypeName("const char *")] sbyte* locale);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_get_locale();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_init_win32_crash_handler();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("profiler_name_store_t *")]
    public static extern void* obs_get_profiler_name_store();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int obs_reset_video([NativeTypeName("struct obs_video_info *")] obs_video_info* ovi);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_reset_audio([NativeTypeName("const struct obs_audio_info *")] obs_audio_info* oai);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_reset_audio2([NativeTypeName("const struct obs_audio_info2 *")] obs_audio_info2* oai);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_get_video_info([NativeTypeName("struct obs_video_info *")] obs_video_info* ovi);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float obs_get_video_sdr_white_level();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float obs_get_video_hdr_nominal_peak_level();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_set_video_levels(float sdr_white_level, float hdr_nominal_peak_level);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_get_audio_info([NativeTypeName("struct obs_audio_info *")] obs_audio_info* oai);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int obs_open_module([NativeTypeName("obs_module_t **")] obs_module** module, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* data_path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_init_module([NativeTypeName("obs_module_t *")] obs_module* module);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_module_t *")]
    public static extern obs_module* obs_get_module([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* obs_get_module_lib([NativeTypeName("obs_module_t *")] obs_module* module);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_module_get_locale_string([NativeTypeName("const obs_module_t *")] obs_module* mod, [NativeTypeName("const char *")] sbyte* lookup_string, [NativeTypeName("const char **")] sbyte** translated_string);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_module_get_locale_text([NativeTypeName("const obs_module_t *")] obs_module* mod, [NativeTypeName("const char *")] sbyte* text);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_log_loaded_modules();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_get_module_file_name([NativeTypeName("obs_module_t *")] obs_module* module);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_get_module_name([NativeTypeName("obs_module_t *")] obs_module* module);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_get_module_author([NativeTypeName("obs_module_t *")] obs_module* module);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_get_module_description([NativeTypeName("obs_module_t *")] obs_module* module);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_get_module_binary_path([NativeTypeName("obs_module_t *")] obs_module* module);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_get_module_data_path([NativeTypeName("obs_module_t *")] obs_module* module);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_add_module_path([NativeTypeName("const char *")] sbyte* bin, [NativeTypeName("const char *")] sbyte* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_load_all_modules();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_module_failure_info_free([NativeTypeName("struct obs_module_failure_info *")] obs_module_failure_info* mfi);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_load_all_modules2([NativeTypeName("struct obs_module_failure_info *")] obs_module_failure_info* mfi);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_post_load_modules();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_find_modules([NativeTypeName("obs_find_module_callback_t")] delegate* unmanaged[Cdecl]<void*, obs_module_info*, void> callback, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_find_modules2([NativeTypeName("obs_find_module_callback2_t")] delegate* unmanaged[Cdecl]<void*, obs_module_info2*, void> callback, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_enum_modules([NativeTypeName("obs_enum_module_callback_t")] delegate* unmanaged[Cdecl]<void*, obs_module*, void> callback, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lookup_t *")]
    public static extern void* obs_module_load_locale([NativeTypeName("obs_module_t *")] obs_module* module, [NativeTypeName("const char *")] sbyte* default_locale, [NativeTypeName("const char *")] sbyte* locale);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* obs_find_module_file([NativeTypeName("obs_module_t *")] obs_module* module, [NativeTypeName("const char *")] sbyte* file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* obs_module_get_config_path([NativeTypeName("obs_module_t *")] obs_module* module, [NativeTypeName("const char *")] sbyte* file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_enum_source_types([NativeTypeName("size_t")] nuint idx, [NativeTypeName("const char **")] sbyte** id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_enum_input_types([NativeTypeName("size_t")] nuint idx, [NativeTypeName("const char **")] sbyte** id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_enum_input_types2([NativeTypeName("size_t")] nuint idx, [NativeTypeName("const char **")] sbyte** id, [NativeTypeName("const char **")] sbyte** unversioned_id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_get_latest_input_type_id([NativeTypeName("const char *")] sbyte* unversioned_id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_enum_filter_types([NativeTypeName("size_t")] nuint idx, [NativeTypeName("const char **")] sbyte** id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_enum_transition_types([NativeTypeName("size_t")] nuint idx, [NativeTypeName("const char **")] sbyte** id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_enum_output_types([NativeTypeName("size_t")] nuint idx, [NativeTypeName("const char **")] sbyte** id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_enum_encoder_types([NativeTypeName("size_t")] nuint idx, [NativeTypeName("const char **")] sbyte** id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_enum_service_types([NativeTypeName("size_t")] nuint idx, [NativeTypeName("const char **")] sbyte** id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_enter_graphics();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_leave_graphics();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("audio_t *")]
    public static extern audio_output* obs_get_audio();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("video_t *")]
    public static extern video_output* obs_get_video();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_video_active();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_set_output_source([NativeTypeName("uint32_t")] uint channel, [NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_get_output_source([NativeTypeName("uint32_t")] uint channel);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_enum_sources([NativeTypeName("bool (*)(void *, obs_source_t *)")] delegate* unmanaged[Cdecl]<void*, void*, byte> enum_proc, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_enum_scenes([NativeTypeName("bool (*)(void *, obs_source_t *)")] delegate* unmanaged[Cdecl]<void*, void*, byte> enum_proc, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_enum_all_sources([NativeTypeName("bool (*)(void *, obs_source_t *)")] delegate* unmanaged[Cdecl]<void*, void*, byte> enum_proc, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_enum_outputs([NativeTypeName("bool (*)(void *, obs_output_t *)")] delegate* unmanaged[Cdecl]<void*, obs_output*, byte> enum_proc, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_enum_encoders([NativeTypeName("bool (*)(void *, obs_encoder_t *)")] delegate* unmanaged[Cdecl]<void*, obs_encoder*, byte> enum_proc, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_enum_services([NativeTypeName("bool (*)(void *, obs_service_t *)")] delegate* unmanaged[Cdecl]<void*, obs_service*, byte> enum_proc, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_get_source_by_name([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_get_transition_by_name([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_output_t *")]
    public static extern obs_output* obs_get_output_by_name([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_encoder_t *")]
    public static extern obs_encoder* obs_get_encoder_by_name([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_service_t *")]
    public static extern obs_service* obs_get_service_by_name([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_effect_t *")]
    public static extern void* obs_get_base_effect([NativeTypeName("enum obs_base_effect")] obs_base_effect effect);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_effect_t *")]
    [Obsolete]
    public static extern void* obs_get_default_rect_effect();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("signal_handler_t *")]
    public static extern void* obs_get_signal_handler();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("proc_handler_t *")]
    public static extern void* obs_get_proc_handler();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [Obsolete]
    public static extern void obs_render_main_view();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_render_main_texture();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_render_main_texture_src_color_only();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern gs_texture* obs_get_main_texture();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_set_master_volume(float volume);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float obs_get_master_volume();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_save_source([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_load_source([NativeTypeName("obs_data_t *")] void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_load_private_source([NativeTypeName("obs_data_t *")] void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_save([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_load([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_load2([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_load_sources([NativeTypeName("obs_data_array_t *")] void* array, [NativeTypeName("obs_load_source_cb")] delegate* unmanaged[Cdecl]<void*, void*, void> cb, void* private_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_array_t *")]
    public static extern void* obs_save_sources();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_array_t *")]
    public static extern void* obs_save_sources_filtered([NativeTypeName("obs_save_source_filter_cb")] delegate* unmanaged[Cdecl]<void*, void*, byte> cb, void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_obj_type")]
    public static extern obs_obj_type obs_obj_get_type(void* obj);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_obj_get_id(void* obj);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_obj_invalid(void* obj);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* obs_obj_get_data(void* obj);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_obj_is_private(void* obj);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_audio_monitoring_available();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_enum_audio_monitoring_devices([NativeTypeName("obs_enum_audio_device_cb")] delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, byte> cb, void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_set_audio_monitoring_device([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_get_audio_monitoring_device([NativeTypeName("const char **")] sbyte** name, [NativeTypeName("const char **")] sbyte** id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_add_tick_callback([NativeTypeName("void (*)(void *, float)")] delegate* unmanaged[Cdecl]<void*, float, void> tick, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_remove_tick_callback([NativeTypeName("void (*)(void *, float)")] delegate* unmanaged[Cdecl]<void*, float, void> tick, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_add_main_render_callback([NativeTypeName("void (*)(void *, uint32_t, uint32_t)")] delegate* unmanaged[Cdecl]<void*, uint, uint, void> draw, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_remove_main_render_callback([NativeTypeName("void (*)(void *, uint32_t, uint32_t)")] delegate* unmanaged[Cdecl]<void*, uint, uint, void> draw, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_add_raw_video_callback([NativeTypeName("const struct video_scale_info *")] video_scale_info* conversion, [NativeTypeName("void (*)(void *, struct video_data *)")] delegate* unmanaged[Cdecl]<void*, video_data*, void> callback, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_remove_raw_video_callback([NativeTypeName("void (*)(void *, struct video_data *)")] delegate* unmanaged[Cdecl]<void*, video_data*, void> callback, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_add_raw_audio_callback([NativeTypeName("size_t")] nuint mix_idx, [NativeTypeName("const struct audio_convert_info *")] audio_convert_info* conversion, [NativeTypeName("audio_output_callback_t")] delegate* unmanaged[Cdecl]<void*, nuint, audio_data*, void> callback, void* param3);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_remove_raw_audio_callback([NativeTypeName("size_t")] nuint mix_idx, [NativeTypeName("audio_output_callback_t")] delegate* unmanaged[Cdecl]<void*, nuint, audio_data*, void> callback, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong obs_get_video_frame_time();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double obs_get_active_fps();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong obs_get_average_frame_time_ns();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong obs_get_frame_interval_ns();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_get_total_frames();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_get_lagged_frames();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_nv12_tex_active();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_p010_tex_active();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_apply_private_data([NativeTypeName("obs_data_t *")] void* settings);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_set_private_data([NativeTypeName("obs_data_t *")] void* settings);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_get_private_data();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_queue_task([NativeTypeName("enum obs_task_type")] obs_task_type type, [NativeTypeName("obs_task_t")] delegate* unmanaged[Cdecl]<void*, void> task, void* param2, [NativeTypeName("bool")] byte wait);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_in_task_thread([NativeTypeName("enum obs_task_type")] obs_task_type type);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_wait_for_destroy_queue();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_set_ui_task_handler([NativeTypeName("obs_task_handler_t")] delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<void*, void>, void*, byte, void> handler);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_object_t *")]
    public static extern obs_context_data* obs_object_get_ref([NativeTypeName("obs_object_t *")] obs_context_data* @object);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_object_release([NativeTypeName("obs_object_t *")] obs_context_data* @object);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_weak_object_addref([NativeTypeName("obs_weak_object_t *")] obs_weak_object* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_weak_object_release([NativeTypeName("obs_weak_object_t *")] obs_weak_object* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_weak_object_t *")]
    public static extern obs_weak_object* obs_object_get_weak_object([NativeTypeName("obs_object_t *")] obs_context_data* @object);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_object_t *")]
    public static extern obs_context_data* obs_weak_object_get_object([NativeTypeName("obs_weak_object_t *")] obs_weak_object* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_weak_object_expired([NativeTypeName("obs_weak_object_t *")] obs_weak_object* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_weak_object_references_object([NativeTypeName("obs_weak_object_t *")] obs_weak_object* weak, [NativeTypeName("obs_object_t *")] obs_context_data* @object);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_view_t *")]
    public static extern obs_view* obs_view_create();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_view_destroy([NativeTypeName("obs_view_t *")] obs_view* view);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_view_set_source([NativeTypeName("obs_view_t *")] obs_view* view, [NativeTypeName("uint32_t")] uint channel, [NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_view_get_source([NativeTypeName("obs_view_t *")] obs_view* view, [NativeTypeName("uint32_t")] uint channel);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_view_render([NativeTypeName("obs_view_t *")] obs_view* view);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_display_t *")]
    public static extern obs_display* obs_display_create([NativeTypeName("const struct gs_init_data *")] gs_init_data* graphics_data, [NativeTypeName("uint32_t")] uint backround_color);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_display_destroy([NativeTypeName("obs_display_t *")] obs_display* display);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_display_resize([NativeTypeName("obs_display_t *")] obs_display* display, [NativeTypeName("uint32_t")] uint cx, [NativeTypeName("uint32_t")] uint cy);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_display_update_color_space([NativeTypeName("obs_display_t *")] obs_display* display);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_display_add_draw_callback([NativeTypeName("obs_display_t *")] obs_display* display, [NativeTypeName("void (*)(void *, uint32_t, uint32_t)")] delegate* unmanaged[Cdecl]<void*, uint, uint, void> draw, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_display_remove_draw_callback([NativeTypeName("obs_display_t *")] obs_display* display, [NativeTypeName("void (*)(void *, uint32_t, uint32_t)")] delegate* unmanaged[Cdecl]<void*, uint, uint, void> draw, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_display_set_enabled([NativeTypeName("obs_display_t *")] obs_display* display, [NativeTypeName("bool")] byte enable);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_display_enabled([NativeTypeName("obs_display_t *")] obs_display* display);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_display_set_background_color([NativeTypeName("obs_display_t *")] obs_display* display, [NativeTypeName("uint32_t")] uint color);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_display_size([NativeTypeName("obs_display_t *")] obs_display* display, [NativeTypeName("uint32_t *")] uint* width, [NativeTypeName("uint32_t *")] uint* height);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_source_get_display_name([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_source_create([NativeTypeName("const char *")] sbyte* id, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_data_t *")] void* settings, [NativeTypeName("obs_data_t *")] void* hotkey_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_source_create_private([NativeTypeName("const char *")] sbyte* id, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_data_t *")] void* settings);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_source_duplicate([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const char *")] sbyte* desired_name, [NativeTypeName("bool")] byte create_private);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [Obsolete]
    public static extern void obs_source_addref([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_release([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_weak_source_addref([NativeTypeName("obs_weak_source_t *")] obs_weak_source* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_weak_source_release([NativeTypeName("obs_weak_source_t *")] obs_weak_source* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_source_get_ref([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_weak_source_t *")]
    public static extern obs_weak_source* obs_source_get_weak_source([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_weak_source_get_source([NativeTypeName("obs_weak_source_t *")] obs_weak_source* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_weak_source_expired([NativeTypeName("obs_weak_source_t *")] obs_weak_source* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_weak_source_references_source([NativeTypeName("obs_weak_source_t *")] obs_weak_source* weak, [NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_remove([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_removed([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_hidden([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("bool")] byte hidden);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_is_hidden([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_source_get_output_flags([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_get_source_output_flags([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_get_source_defaults([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_properties_t *")]
    public static extern void* obs_get_source_properties([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_missing_files_t *")]
    public static extern void* obs_source_get_missing_files([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_replace_missing_file([NativeTypeName("obs_missing_file_cb")] delegate* unmanaged[Cdecl]<void*, sbyte*, void*, void> cb, [NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const char *")] sbyte* new_path, void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_is_source_configurable([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_configurable([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_properties_t *")]
    public static extern void* obs_source_properties([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_update([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_data_t *")] void* settings);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_reset_settings([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_data_t *")] void* settings);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_video_render([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_source_get_width([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_source_get_height([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum gs_color_space")]
    public static extern gs_color_space obs_source_get_color_space([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("size_t")] nuint count, [NativeTypeName("const enum gs_color_space *")] gs_color_space* preferred_spaces);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_get_texcoords_centered([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_filter_get_parent([NativeTypeName("const obs_source_t *")] void* filter);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_filter_get_target([NativeTypeName("const obs_source_t *")] void* filter);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_default_render([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_filter_add([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_source_t *")] void* filter);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_filter_remove([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_source_t *")] void* filter);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_filter_set_order([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_source_t *")] void* filter, [NativeTypeName("enum obs_order_movement")] obs_order_movement movement);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_source_get_settings([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_source_get_name([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_name([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_source_type")]
    public static extern obs_source_type obs_source_get_type([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_source_get_id([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_source_get_unversioned_id([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("signal_handler_t *")]
    public static extern void* obs_source_get_signal_handler([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("proc_handler_t *")]
    public static extern void* obs_source_get_proc_handler([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_volume([NativeTypeName("obs_source_t *")] void* source, float volume);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float obs_source_get_volume([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum speaker_layout")]
    public static extern speaker_layout obs_source_get_speaker_layout([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_balance_value([NativeTypeName("obs_source_t *")] void* source, float balance);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float obs_source_get_balance_value([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_sync_offset([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("int64_t")] long offset);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int64_t")]
    public static extern long obs_source_get_sync_offset([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_enum_active_sources([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_source_enum_proc_t")] delegate* unmanaged[Cdecl]<void*, void*, void*, void> enum_callback, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_enum_active_tree([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_source_enum_proc_t")] delegate* unmanaged[Cdecl]<void*, void*, void*, void> enum_callback, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_enum_full_tree([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_source_enum_proc_t")] delegate* unmanaged[Cdecl]<void*, void*, void*, void> enum_callback, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_active([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_showing([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_flags([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_source_get_flags([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_audio_mixers([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("uint32_t")] uint mixers);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_source_get_audio_mixers([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_inc_showing([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_inc_active([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_dec_showing([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_dec_active([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_enum_filters([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_source_enum_proc_t")] delegate* unmanaged[Cdecl]<void*, void*, void*, void> callback, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_source_get_filter_by_name([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_source_filter_count([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_copy_filters([NativeTypeName("obs_source_t *")] void* dst, [NativeTypeName("obs_source_t *")] void* src);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_copy_single_filter([NativeTypeName("obs_source_t *")] void* dst, [NativeTypeName("obs_source_t *")] void* filter);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_enabled([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_enabled([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("bool")] byte enabled);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_muted([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_muted([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("bool")] byte muted);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_push_to_mute_enabled([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_enable_push_to_mute([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("bool")] byte enabled);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong obs_source_get_push_to_mute_delay([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_push_to_mute_delay([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("uint64_t")] ulong delay);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_push_to_talk_enabled([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_enable_push_to_talk([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("bool")] byte enabled);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong obs_source_get_push_to_talk_delay([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_push_to_talk_delay([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("uint64_t")] ulong delay);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_add_audio_capture_callback([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_source_audio_capture_t")] delegate* unmanaged[Cdecl]<void*, void*, audio_data*, byte, void> callback, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_remove_audio_capture_callback([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_source_audio_capture_t")] delegate* unmanaged[Cdecl]<void*, void*, audio_data*, byte, void> callback, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_add_caption_callback([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_source_caption_t")] delegate* unmanaged[Cdecl]<void*, void*, obs_source_cea_708*, void> callback, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_remove_caption_callback([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_source_caption_t")] delegate* unmanaged[Cdecl]<void*, void*, obs_source_cea_708*, void> callback, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_deinterlace_mode([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("enum obs_deinterlace_mode")] obs_deinterlace_mode mode);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_deinterlace_mode")]
    public static extern obs_deinterlace_mode obs_source_get_deinterlace_mode([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_deinterlace_field_order([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("enum obs_deinterlace_field_order")] obs_deinterlace_field_order field_order);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_deinterlace_field_order")]
    public static extern obs_deinterlace_field_order obs_source_get_deinterlace_field_order([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_monitoring_type([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("enum obs_monitoring_type")] obs_monitoring_type type);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_monitoring_type")]
    public static extern obs_monitoring_type obs_source_get_monitoring_type([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_source_get_private_settings([NativeTypeName("obs_source_t *")] void* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_array_t *")]
    public static extern void* obs_source_backup_filters([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_restore_filters([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("obs_data_array_t *")] void* array);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* obs_source_get_type_data([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_draw_set_color_matrix([NativeTypeName("const struct matrix4 *")] matrix4* color_matrix, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* color_range_min, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* color_range_max);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_draw([NativeTypeName("gs_texture_t *")] gs_texture* image, int x, int y, [NativeTypeName("uint32_t")] uint cx, [NativeTypeName("uint32_t")] uint cy, [NativeTypeName("bool")] byte flip);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_output_video([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const struct obs_source_frame *")] obs_source_frame* frame);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_output_video2([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const struct obs_source_frame2 *")] obs_source_frame2* frame);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_async_rotation([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("long")] int rotation);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_output_cea708([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const struct obs_source_cea_708 *")] obs_source_cea_708* captions);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_preload_video([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const struct obs_source_frame *")] obs_source_frame* frame);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_preload_video2([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const struct obs_source_frame2 *")] obs_source_frame2* frame);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_show_preloaded_video([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_video_frame([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const struct obs_source_frame *")] obs_source_frame* frame);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_video_frame2([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const struct obs_source_frame2 *")] obs_source_frame2* frame);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_output_audio([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const struct obs_source_audio *")] obs_source_audio* audio);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_update_properties([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("struct obs_source_frame *")]
    public static extern obs_source_frame* obs_source_get_frame([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_release_frame([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("struct obs_source_frame *")] obs_source_frame* frame);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_process_filter_begin([NativeTypeName("obs_source_t *")] void* filter, [NativeTypeName("enum gs_color_format")] gs_color_format format, [NativeTypeName("enum obs_allow_direct_render")] obs_allow_direct_render allow_direct);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_process_filter_begin_with_color_space([NativeTypeName("obs_source_t *")] void* filter, [NativeTypeName("enum gs_color_format")] gs_color_format format, [NativeTypeName("enum gs_color_space")] gs_color_space space, [NativeTypeName("enum obs_allow_direct_render")] obs_allow_direct_render allow_direct);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_process_filter_end([NativeTypeName("obs_source_t *")] void* filter, [NativeTypeName("gs_effect_t *")] void* effect, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_process_filter_tech_end([NativeTypeName("obs_source_t *")] void* filter, [NativeTypeName("gs_effect_t *")] void* effect, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("const char *")] sbyte* tech_name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_skip_video_filter([NativeTypeName("obs_source_t *")] void* filter);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_add_active_child([NativeTypeName("obs_source_t *")] void* parent, [NativeTypeName("obs_source_t *")] void* child);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_remove_active_child([NativeTypeName("obs_source_t *")] void* parent, [NativeTypeName("obs_source_t *")] void* child);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_send_mouse_click([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const struct obs_mouse_event *")] obs_mouse_event* @event, [NativeTypeName("int32_t")] int type, [NativeTypeName("bool")] byte mouse_up, [NativeTypeName("uint32_t")] uint click_count);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_send_mouse_move([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const struct obs_mouse_event *")] obs_mouse_event* @event, [NativeTypeName("bool")] byte mouse_leave);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_send_mouse_wheel([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const struct obs_mouse_event *")] obs_mouse_event* @event, int x_delta, int y_delta);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_send_focus([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("bool")] byte focus);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_send_key_click([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("const struct obs_key_event *")] obs_key_event* @event, [NativeTypeName("bool")] byte key_up);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_default_flags([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_source_get_base_width([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_source_get_base_height([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_audio_pending([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong obs_source_get_audio_timestamp([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_get_audio_mix([NativeTypeName("const obs_source_t *")] void* source, [NativeTypeName("struct obs_source_audio_mix *")] obs_source_audio_mix* audio);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_async_unbuffered([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("bool")] byte unbuffered);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_async_unbuffered([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_async_decoupled([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("bool")] byte decouple);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_async_decoupled([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_set_audio_active([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("bool")] byte show);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_audio_active([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_source_get_last_obs_version([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_media_play_pause([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("bool")] byte pause);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_media_restart([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_media_stop([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_media_next([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_media_previous([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int64_t")]
    public static extern long obs_source_media_get_duration([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int64_t")]
    public static extern long obs_source_media_get_time([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_media_set_time([NativeTypeName("obs_source_t *")] void* source, [NativeTypeName("int64_t")] long ms);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_media_state")]
    public static extern obs_media_state obs_source_media_get_state([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_media_started([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_media_ended([NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_transition_get_source([NativeTypeName("obs_source_t *")] void* transition, [NativeTypeName("enum obs_transition_target")] obs_transition_target target);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_clear([NativeTypeName("obs_source_t *")] void* transition);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_transition_get_active_source([NativeTypeName("obs_source_t *")] void* transition);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_transition_start([NativeTypeName("obs_source_t *")] void* transition, [NativeTypeName("enum obs_transition_mode")] obs_transition_mode mode, [NativeTypeName("uint32_t")] uint duration_ms, [NativeTypeName("obs_source_t *")] void* dest);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_set([NativeTypeName("obs_source_t *")] void* transition, [NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_set_manual_time([NativeTypeName("obs_source_t *")] void* transition, float t);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_set_manual_torque([NativeTypeName("obs_source_t *")] void* transition, float torque, float clamp);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_set_scale_type([NativeTypeName("obs_source_t *")] void* transition, [NativeTypeName("enum obs_transition_scale_type")] obs_transition_scale_type type);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_transition_scale_type")]
    public static extern obs_transition_scale_type obs_transition_get_scale_type([NativeTypeName("const obs_source_t *")] void* transition);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_set_alignment([NativeTypeName("obs_source_t *")] void* transition, [NativeTypeName("uint32_t")] uint alignment);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_transition_get_alignment([NativeTypeName("const obs_source_t *")] void* transition);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_set_size([NativeTypeName("obs_source_t *")] void* transition, [NativeTypeName("uint32_t")] uint cx, [NativeTypeName("uint32_t")] uint cy);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_get_size([NativeTypeName("const obs_source_t *")] void* transition, [NativeTypeName("uint32_t *")] uint* cx, [NativeTypeName("uint32_t *")] uint* cy);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_enable_fixed([NativeTypeName("obs_source_t *")] void* transition, [NativeTypeName("bool")] byte enable, [NativeTypeName("uint32_t")] uint duration_ms);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_transition_fixed([NativeTypeName("obs_source_t *")] void* transition);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float obs_transition_get_time([NativeTypeName("obs_source_t *")] void* transition);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_force_stop([NativeTypeName("obs_source_t *")] void* transition);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_video_render([NativeTypeName("obs_source_t *")] void* transition, [NativeTypeName("obs_transition_video_render_callback_t")] delegate* unmanaged[Cdecl]<void*, gs_texture*, gs_texture*, float, uint, uint, void> callback);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_video_render2([NativeTypeName("obs_source_t *")] void* transition, [NativeTypeName("obs_transition_video_render_callback_t")] delegate* unmanaged[Cdecl]<void*, gs_texture*, gs_texture*, float, uint, uint, void> callback, [NativeTypeName("gs_texture_t *")] gs_texture* placeholder_texture);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum gs_color_space")]
    public static extern gs_color_space obs_transition_video_get_color_space([NativeTypeName("obs_source_t *")] void* transition);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_transition_video_render_direct([NativeTypeName("obs_source_t *")] void* transition, [NativeTypeName("enum obs_transition_target")] obs_transition_target target);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_transition_audio_render([NativeTypeName("obs_source_t *")] void* transition, [NativeTypeName("uint64_t *")] ulong* ts_out, [NativeTypeName("struct obs_source_audio_mix *")] obs_source_audio_mix* audio, [NativeTypeName("uint32_t")] uint mixers, [NativeTypeName("size_t")] nuint channels, [NativeTypeName("size_t")] nuint sample_rate, [NativeTypeName("obs_transition_audio_mix_callback_t")] delegate* unmanaged[Cdecl]<void*, float, float> mix_a_callback, [NativeTypeName("obs_transition_audio_mix_callback_t")] delegate* unmanaged[Cdecl]<void*, float, float> mix_b_callback);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_swap_begin([NativeTypeName("obs_source_t *")] void* tr_dest, [NativeTypeName("obs_source_t *")] void* tr_source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_transition_swap_end([NativeTypeName("obs_source_t *")] void* tr_dest, [NativeTypeName("obs_source_t *")] void* tr_source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_scene_t *")]
    public static extern obs_scene* obs_scene_create([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_scene_t *")]
    public static extern obs_scene* obs_scene_create_private([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_scene_t *")]
    public static extern obs_scene* obs_scene_duplicate([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("enum obs_scene_duplicate_type")] obs_scene_duplicate_type type);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [Obsolete]
    public static extern void obs_scene_addref([NativeTypeName("obs_scene_t *")] obs_scene* scene);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_scene_release([NativeTypeName("obs_scene_t *")] obs_scene* scene);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_scene_t *")]
    public static extern obs_scene* obs_scene_get_ref([NativeTypeName("obs_scene_t *")] obs_scene* scene);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_scene_get_source([NativeTypeName("const obs_scene_t *")] obs_scene* scene);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_scene_t *")]
    public static extern obs_scene* obs_scene_from_source([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_sceneitem_t *")]
    public static extern obs_scene_item* obs_scene_find_source([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_sceneitem_t *")]
    public static extern obs_scene_item* obs_scene_find_source_recursive([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_sceneitem_t *")]
    public static extern obs_scene_item* obs_scene_find_sceneitem_by_id([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("int64_t")] long id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_scene_enum_items([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("bool (*)(obs_scene_t *, obs_sceneitem_t *, void *)")] delegate* unmanaged[Cdecl]<obs_scene*, obs_scene_item*, void*, byte> callback, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_scene_reorder_items([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("obs_sceneitem_t *const *")] obs_scene_item** item_order, [NativeTypeName("size_t")] nuint item_order_size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_scene_reorder_items2([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("struct obs_sceneitem_order_info *")] obs_sceneitem_order_info* item_order, [NativeTypeName("size_t")] nuint item_order_size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_is_scene([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_sceneitem_t *")]
    public static extern obs_scene_item* obs_scene_add([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_scene_atomic_update([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("obs_scene_atomic_update_func")] delegate* unmanaged[Cdecl]<void*, obs_scene*, void> func, void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_addref([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_release([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_remove([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitems_add([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("obs_data_array_t *")] void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_save([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("obs_data_array_t *")] void* arr);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_id([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* sceneitem, [NativeTypeName("int64_t")] long id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_sceneitem_t *")]
    public static extern obs_scene_item* obs_scene_sceneitem_from_source([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_scene_save_transform_states([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("bool")] byte all_items);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_scene_load_transform_states([NativeTypeName("const char *")] sbyte* state);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int obs_sceneitem_get_order_position([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_scene_t *")]
    public static extern obs_scene* obs_sceneitem_get_scene([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_sceneitem_get_source([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_select([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("bool")] byte select);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_sceneitem_selected([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_sceneitem_locked([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_sceneitem_set_locked([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("bool")] byte @lock);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_pos([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("const struct vec2 *")] System.Numerics.Vector2* pos);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_rot([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, float rot_deg);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_scale([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("const struct vec2 *")] System.Numerics.Vector2* scale);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_alignment([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("uint32_t")] uint alignment);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_order([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("enum obs_order_movement")] obs_order_movement movement);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_order_position([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, int position);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_bounds_type([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("enum obs_bounds_type")] obs_bounds_type type);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_bounds_alignment([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("uint32_t")] uint alignment);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_bounds([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("const struct vec2 *")] System.Numerics.Vector2* bounds);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int64_t")]
    public static extern long obs_sceneitem_get_id([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_get_pos([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("struct vec2 *")] System.Numerics.Vector2* pos);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float obs_sceneitem_get_rot([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_get_scale([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("struct vec2 *")] System.Numerics.Vector2* scale);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_sceneitem_get_alignment([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_bounds_type")]
    public static extern obs_bounds_type obs_sceneitem_get_bounds_type([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_sceneitem_get_bounds_alignment([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_get_bounds([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("struct vec2 *")] System.Numerics.Vector2* bounds);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_get_info([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("struct obs_transform_info *")] obs_transform_info* info);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_info([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("const struct obs_transform_info *")] obs_transform_info* info);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_get_draw_transform([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("struct matrix4 *")] matrix4* transform);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_get_box_transform([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("struct matrix4 *")] matrix4* transform);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_get_box_scale([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("struct vec2 *")] System.Numerics.Vector2* scale);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_sceneitem_visible([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_sceneitem_set_visible([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("bool")] byte visible);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_crop([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("const struct obs_sceneitem_crop *")] obs_sceneitem_crop* crop);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_get_crop([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("struct obs_sceneitem_crop *")] obs_sceneitem_crop* crop);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_scale_filter([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("enum obs_scale_type")] obs_scale_type filter);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_scale_type")]
    public static extern obs_scale_type obs_sceneitem_get_scale_filter([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_blending_method([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("enum obs_blending_method")] obs_blending_method method);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_blending_method")]
    public static extern obs_blending_method obs_sceneitem_get_blending_method([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_blending_mode([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("enum obs_blending_type")] obs_blending_type type);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_blending_type")]
    public static extern obs_blending_type obs_sceneitem_get_blending_mode([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_force_update_transform([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_defer_update_begin([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_defer_update_end([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_sceneitem_get_private_settings([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_sceneitem_t *")]
    public static extern obs_scene_item* obs_scene_add_group([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_sceneitem_t *")]
    public static extern obs_scene_item* obs_scene_insert_group([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_sceneitem_t **")] obs_scene_item** items, [NativeTypeName("size_t")] nuint count);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_sceneitem_t *")]
    public static extern obs_scene_item* obs_scene_add_group2([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("bool")] byte signal);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_sceneitem_t *")]
    public static extern obs_scene_item* obs_scene_insert_group2([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_sceneitem_t **")] obs_scene_item** items, [NativeTypeName("size_t")] nuint count, [NativeTypeName("bool")] byte signal);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_sceneitem_t *")]
    public static extern obs_scene_item* obs_scene_get_group([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_sceneitem_is_group([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_scene_t *")]
    public static extern obs_scene* obs_sceneitem_group_get_scene([NativeTypeName("const obs_sceneitem_t *")] obs_scene_item* group);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_group_ungroup([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* group);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_group_ungroup2([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* group, [NativeTypeName("bool")] byte signal);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_group_add_item([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* group, [NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_group_remove_item([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* group, [NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_sceneitem_t *")]
    public static extern obs_scene_item* obs_sceneitem_get_group([NativeTypeName("obs_scene_t *")] obs_scene* scene, [NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_source_is_group([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_scene_is_group([NativeTypeName("const obs_scene_t *")] obs_scene* scene);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_group_enum_items([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* group, [NativeTypeName("bool (*)(obs_scene_t *, obs_sceneitem_t *, void *)")] delegate* unmanaged[Cdecl]<obs_scene*, obs_scene_item*, void*, byte> callback, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_scene_t *")]
    public static extern obs_scene* obs_group_from_source([NativeTypeName("const obs_source_t *")] void* source);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_defer_group_resize_begin([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_defer_group_resize_end([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_show_transition([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("obs_source_t *")] void* transition);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_show_transition_duration([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("uint32_t")] uint duration_ms);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    [Obsolete]
    public static extern void* obs_sceneitem_get_show_transition([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    [Obsolete]
    public static extern uint obs_sceneitem_get_show_transition_duration([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [Obsolete]
    public static extern void obs_sceneitem_set_hide_transition([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("obs_source_t *")] void* transition);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [Obsolete]
    public static extern void obs_sceneitem_set_hide_transition_duration([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("uint32_t")] uint duration_ms);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    [Obsolete]
    public static extern void* obs_sceneitem_get_hide_transition([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    [Obsolete]
    public static extern uint obs_sceneitem_get_hide_transition_duration([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_transition([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("bool")] byte show, [NativeTypeName("obs_source_t *")] void* transition);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_source_t *")]
    public static extern void* obs_sceneitem_get_transition([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("bool")] byte show);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_set_transition_duration([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("bool")] byte show, [NativeTypeName("uint32_t")] uint duration_ms);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_sceneitem_get_transition_duration([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("bool")] byte show);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_do_transition([NativeTypeName("obs_sceneitem_t *")] obs_scene_item* item, [NativeTypeName("bool")] byte visible);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_sceneitem_transition_load([NativeTypeName("struct obs_scene_item *")] obs_scene_item* item, [NativeTypeName("obs_data_t *")] void* data, [NativeTypeName("bool")] byte show);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_sceneitem_transition_save([NativeTypeName("struct obs_scene_item *")] obs_scene_item* item, [NativeTypeName("bool")] byte show);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_scene_prune_sources([NativeTypeName("obs_scene_t *")] obs_scene* scene);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_output_get_display_name([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_output_t *")]
    public static extern obs_output* obs_output_create([NativeTypeName("const char *")] sbyte* id, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_data_t *")] void* settings, [NativeTypeName("obs_data_t *")] void* hotkey_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [Obsolete]
    public static extern void obs_output_addref([NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_release([NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_weak_output_addref([NativeTypeName("obs_weak_output_t *")] obs_weak_output* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_weak_output_release([NativeTypeName("obs_weak_output_t *")] obs_weak_output* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_output_t *")]
    public static extern obs_output* obs_output_get_ref([NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_weak_output_t *")]
    public static extern obs_weak_output* obs_output_get_weak_output([NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_output_t *")]
    public static extern obs_output* obs_weak_output_get_output([NativeTypeName("obs_weak_output_t *")] obs_weak_output* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_weak_output_references_output([NativeTypeName("obs_weak_output_t *")] obs_weak_output* weak, [NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_output_get_name([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_output_start([NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_stop([NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_set_delay([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("uint32_t")] uint delay_sec, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_output_get_delay([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_output_get_active_delay([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_force_stop([NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_output_active([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_output_get_flags([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_get_output_flags([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_output_defaults([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_properties_t *")]
    public static extern void* obs_get_output_properties([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_properties_t *")]
    public static extern void* obs_output_properties([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_update([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("obs_data_t *")] void* settings);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_output_can_pause([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_output_pause([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("bool")] byte pause);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_output_paused([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_output_get_settings([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("signal_handler_t *")]
    public static extern void* obs_output_get_signal_handler([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("proc_handler_t *")]
    public static extern void* obs_output_get_proc_handler([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_set_media([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("video_t *")] video_output* video, [NativeTypeName("audio_t *")] audio_output* audio);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("video_t *")]
    public static extern video_output* obs_output_video([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("audio_t *")]
    public static extern audio_output* obs_output_audio([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_set_mixer([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("size_t")] nuint mixer_idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_output_get_mixer([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_set_mixers([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("size_t")] nuint mixers);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_output_get_mixers([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_set_video_encoder([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_set_audio_encoder([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("obs_encoder_t *")] obs_encoder* encoder, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_encoder_t *")]
    public static extern obs_encoder* obs_output_get_video_encoder([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_encoder_t *")]
    public static extern obs_encoder* obs_output_get_audio_encoder([NativeTypeName("const obs_output_t *")] obs_output* output, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_set_service([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_service_t *")]
    public static extern obs_service* obs_output_get_service([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_set_reconnect_settings([NativeTypeName("obs_output_t *")] obs_output* output, int retry_count, int retry_sec);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong obs_output_get_total_bytes([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int obs_output_get_frames_dropped([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int obs_output_get_total_frames([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_set_preferred_size([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_output_get_width([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_output_get_height([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_output_get_id([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_caption([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("const struct obs_source_cea_708 *")] obs_source_cea_708* captions);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_output_caption_text1([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("const char *")] sbyte* text);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_output_caption_text2([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("const char *")] sbyte* text, double display_duration);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float obs_output_get_congestion([NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int obs_output_get_connect_time_ms([NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_output_reconnecting([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_set_last_error([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("const char *")] sbyte* message);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_output_get_last_error([NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_output_get_supported_video_codecs([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_output_get_supported_audio_codecs([NativeTypeName("const obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* obs_output_get_type_data([NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_set_video_conversion([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("const struct video_scale_info *")] video_scale_info* conversion);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_set_audio_conversion([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("const struct audio_convert_info *")] audio_convert_info* conversion);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_output_can_begin_data_capture([NativeTypeName("const obs_output_t *")] obs_output* output, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_output_initialize_encoders([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_output_begin_data_capture([NativeTypeName("obs_output_t *")] obs_output* output, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_end_data_capture([NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_output_signal_stop([NativeTypeName("obs_output_t *")] obs_output* output, int code);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong obs_output_get_pause_offset([NativeTypeName("obs_output_t *")] obs_output* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_encoder_get_display_name([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_encoder_t *")]
    public static extern obs_encoder* obs_video_encoder_create([NativeTypeName("const char *")] sbyte* id, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_data_t *")] void* settings, [NativeTypeName("obs_data_t *")] void* hotkey_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_encoder_t *")]
    public static extern obs_encoder* obs_audio_encoder_create([NativeTypeName("const char *")] sbyte* id, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_data_t *")] void* settings, [NativeTypeName("size_t")] nuint mixer_idx, [NativeTypeName("obs_data_t *")] void* hotkey_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [Obsolete]
    public static extern void obs_encoder_addref([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_encoder_release([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_weak_encoder_addref([NativeTypeName("obs_weak_encoder_t *")] obs_weak_encoder* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_weak_encoder_release([NativeTypeName("obs_weak_encoder_t *")] obs_weak_encoder* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_encoder_t *")]
    public static extern obs_encoder* obs_encoder_get_ref([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_weak_encoder_t *")]
    public static extern obs_weak_encoder* obs_encoder_get_weak_encoder([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_encoder_t *")]
    public static extern obs_encoder* obs_weak_encoder_get_encoder([NativeTypeName("obs_weak_encoder_t *")] obs_weak_encoder* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_weak_encoder_references_encoder([NativeTypeName("obs_weak_encoder_t *")] obs_weak_encoder* weak, [NativeTypeName("obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_encoder_set_name([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_encoder_get_name([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_get_encoder_codec([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_encoder_type")]
    public static extern obs_encoder_type obs_get_encoder_type([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_encoder_get_codec([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_encoder_type")]
    public static extern obs_encoder_type obs_encoder_get_type([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_encoder_set_scaled_size([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_encoder_scaling_enabled([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_encoder_get_width([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_encoder_get_height([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_encoder_get_sample_rate([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_encoder_get_frame_size([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_encoder_set_preferred_video_format([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder, [NativeTypeName("enum video_format")] video_format format);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum video_format")]
    public static extern video_format obs_encoder_get_preferred_video_format([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_encoder_defaults([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_encoder_get_defaults([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_properties_t *")]
    public static extern void* obs_get_encoder_properties([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_properties_t *")]
    public static extern void* obs_encoder_properties([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_encoder_update([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder, [NativeTypeName("obs_data_t *")] void* settings);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_encoder_get_extra_data([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder, [NativeTypeName("uint8_t **")] byte** extra_data, [NativeTypeName("size_t *")] nuint* size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_encoder_get_settings([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_encoder_set_video([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder, [NativeTypeName("video_t *")] video_output* video);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_encoder_set_audio([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder, [NativeTypeName("audio_t *")] audio_output* audio);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("video_t *")]
    public static extern video_output* obs_encoder_video([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("audio_t *")]
    public static extern audio_output* obs_encoder_audio([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_encoder_active([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* obs_encoder_get_type_data([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_encoder_get_id([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_get_encoder_caps([NativeTypeName("const char *")] sbyte* encoder_id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_encoder_get_caps([NativeTypeName("const obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [Obsolete]
    public static extern void obs_duplicate_encoder_packet([NativeTypeName("struct encoder_packet *")] encoder_packet* dst, [NativeTypeName("const struct encoder_packet *")] encoder_packet* src);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [Obsolete]
    public static extern void obs_free_encoder_packet([NativeTypeName("struct encoder_packet *")] encoder_packet* packet);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_encoder_packet_ref([NativeTypeName("struct encoder_packet *")] encoder_packet* dst, [NativeTypeName("struct encoder_packet *")] encoder_packet* src);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_encoder_packet_release([NativeTypeName("struct encoder_packet *")] encoder_packet* packet);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* obs_encoder_create_rerouted([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder, [NativeTypeName("const char *")] sbyte* reroute_id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_encoder_paused([NativeTypeName("const obs_encoder_t *")] obs_encoder* output);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_encoder_get_last_error([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_encoder_set_last_error([NativeTypeName("obs_encoder_t *")] obs_encoder* encoder, [NativeTypeName("const char *")] sbyte* message);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_service_get_display_name([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_service_t *")]
    public static extern obs_service* obs_service_create([NativeTypeName("const char *")] sbyte* id, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_data_t *")] void* settings, [NativeTypeName("obs_data_t *")] void* hotkey_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_service_t *")]
    public static extern obs_service* obs_service_create_private([NativeTypeName("const char *")] sbyte* id, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_data_t *")] void* settings);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [Obsolete]
    public static extern void obs_service_addref([NativeTypeName("obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_service_release([NativeTypeName("obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_weak_service_addref([NativeTypeName("obs_weak_service_t *")] obs_weak_service* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_weak_service_release([NativeTypeName("obs_weak_service_t *")] obs_weak_service* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_service_t *")]
    public static extern obs_service* obs_service_get_ref([NativeTypeName("obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_weak_service_t *")]
    public static extern obs_weak_service* obs_service_get_weak_service([NativeTypeName("obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_service_t *")]
    public static extern obs_service* obs_weak_service_get_service([NativeTypeName("obs_weak_service_t *")] obs_weak_service* weak);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_weak_service_references_service([NativeTypeName("obs_weak_service_t *")] obs_weak_service* weak, [NativeTypeName("obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_service_get_name([NativeTypeName("const obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_service_defaults([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_properties_t *")]
    public static extern void* obs_get_service_properties([NativeTypeName("const char *")] sbyte* id);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_properties_t *")]
    public static extern void* obs_service_properties([NativeTypeName("const obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_service_get_type([NativeTypeName("const obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_service_update([NativeTypeName("obs_service_t *")] obs_service* service, [NativeTypeName("obs_data_t *")] void* settings);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern void* obs_service_get_settings([NativeTypeName("const obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_service_get_url([NativeTypeName("const obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_service_get_key([NativeTypeName("const obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_service_get_username([NativeTypeName("const obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_service_get_password([NativeTypeName("const obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_service_apply_encoder_settings([NativeTypeName("obs_service_t *")] obs_service* service, [NativeTypeName("obs_data_t *")] void* video_encoder_settings, [NativeTypeName("obs_data_t *")] void* audio_encoder_settings);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* obs_service_get_type_data([NativeTypeName("obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_service_get_id([NativeTypeName("const obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_service_get_supported_resolutions([NativeTypeName("const obs_service_t *")] obs_service* service, [NativeTypeName("struct obs_service_resolution **")] obs_service_resolution** resolutions, [NativeTypeName("size_t *")] nuint* count);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_service_get_max_fps([NativeTypeName("const obs_service_t *")] obs_service* service, int* fps);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_service_get_max_bitrate([NativeTypeName("const obs_service_t *")] obs_service* service, int* video_bitrate, int* audio_bitrate);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char **")]
    public static extern sbyte** obs_service_get_supported_video_codecs([NativeTypeName("const obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_service_get_output_type([NativeTypeName("const obs_service_t *")] obs_service* service);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_frame_init([NativeTypeName("struct obs_source_frame *")] obs_source_frame* frame, [NativeTypeName("enum video_format")] video_format format, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_source_frame_copy([NativeTypeName("struct obs_source_frame *")] obs_source_frame* dst, [NativeTypeName("const struct obs_source_frame *")] obs_source_frame* src);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_icon_type")]
    public static extern obs_icon_type obs_source_get_icon_type([NativeTypeName("const char *")] sbyte* id);

    [NativeTypeName("#define OBS_SOURCE_FRAME_LINEAR_ALPHA (1 << 0)")]
    public const int OBS_SOURCE_FRAME_LINEAR_ALPHA = (1 << 0);

    [NativeTypeName("#define OBS_SOURCE_FLAG_UNUSED_1 (1 << 0)")]
    public const int OBS_SOURCE_FLAG_UNUSED_1 = (1 << 0);

    [NativeTypeName("#define OBS_SOURCE_FLAG_FORCE_MONO (1 << 1)")]
    public const int OBS_SOURCE_FLAG_FORCE_MONO = (1 << 1);

    [NativeTypeName("#define OBS_OUTPUT_DELAY_PRESERVE (1 << 0)")]
    public const int OBS_OUTPUT_DELAY_PRESERVE = (1 << 0);
}
