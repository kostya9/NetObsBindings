using System;
using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsProperties
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_properties_t *")]
    public static extern obs_properties* obs_properties_create();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_properties_t *")]
    public static extern obs_properties* obs_properties_create_param(void* param0, [NativeTypeName("void (*)(void *)")] delegate* unmanaged[Cdecl]<void*, void> destroy);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_properties_destroy([NativeTypeName("obs_properties_t *")] obs_properties* props);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_properties_set_flags([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint obs_properties_get_flags([NativeTypeName("obs_properties_t *")] obs_properties* props);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_properties_set_param([NativeTypeName("obs_properties_t *")] obs_properties* props, void* param1, [NativeTypeName("void (*)(void *)")] delegate* unmanaged[Cdecl]<void*, void> destroy);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* obs_properties_get_param([NativeTypeName("obs_properties_t *")] obs_properties* props);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_first([NativeTypeName("obs_properties_t *")] obs_properties* props);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_get([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* property);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_properties_t *")]
    public static extern obs_properties* obs_properties_get_parent([NativeTypeName("obs_properties_t *")] obs_properties* props);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_properties_remove_by_name([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* property);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_properties_apply_settings([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("obs_data_t *")] void* settings);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_bool([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_int([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description, int min, int max, int step);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_float([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description, double min, double max, double step);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_int_slider([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description, int min, int max, int step);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_float_slider([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description, double min, double max, double step);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_text([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description, [NativeTypeName("enum obs_text_type")] obs_text_type type);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_path([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description, [NativeTypeName("enum obs_path_type")] obs_path_type type, [NativeTypeName("const char *")] sbyte* filter, [NativeTypeName("const char *")] sbyte* default_path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_list([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description, [NativeTypeName("enum obs_combo_type")] obs_combo_type type, [NativeTypeName("enum obs_combo_format")] obs_combo_format format);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_color([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_color_alpha([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_button([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("obs_property_clicked_t")] delegate* unmanaged[Cdecl]<obs_properties*, obs_property*, void*, byte> callback);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_button2([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* text, [NativeTypeName("obs_property_clicked_t")] delegate* unmanaged[Cdecl]<obs_properties*, obs_property*, void*, byte> callback, void* priv);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_font([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_editable_list([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description, [NativeTypeName("enum obs_editable_list_type")] obs_editable_list_type type, [NativeTypeName("const char *")] sbyte* filter, [NativeTypeName("const char *")] sbyte* default_path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_frame_rate([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_property_t *")]
    public static extern obs_property* obs_properties_add_group([NativeTypeName("obs_properties_t *")] obs_properties* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description, [NativeTypeName("enum obs_group_type")] obs_group_type type, [NativeTypeName("obs_properties_t *")] obs_properties* group);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_set_modified_callback([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("obs_property_modified_t")] delegate* unmanaged[Cdecl]<obs_properties*, obs_property*, void*, byte> modified);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_set_modified_callback2([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("obs_property_modified2_t")] delegate* unmanaged[Cdecl]<void*, obs_properties*, obs_property*, void*, byte> modified, void* priv);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_property_modified([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("obs_data_t *")] void* settings);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_property_button_clicked([NativeTypeName("obs_property_t *")] obs_property* p, void* obj);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_set_visible([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("bool")] byte visible);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_set_enabled([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("bool")] byte enabled);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_set_description([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("const char *")] sbyte* description);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_set_long_description([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("const char *")] sbyte* long_description);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_name([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_description([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_long_description([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_property_type")]
    public static extern obs_property_type obs_property_get_type([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_property_enabled([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_property_visible([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_property_next([NativeTypeName("obs_property_t **")] obs_property** p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int obs_property_int_min([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int obs_property_int_max([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int obs_property_int_step([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_number_type")]
    public static extern obs_number_type obs_property_int_type([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_int_suffix([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double obs_property_float_min([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double obs_property_float_max([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double obs_property_float_step([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_number_type")]
    public static extern obs_number_type obs_property_float_type([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_float_suffix([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_text_type")]
    public static extern obs_text_type obs_property_text_type([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_property_text_monospace([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_text_info_type")]
    public static extern obs_text_info_type obs_property_text_info_type([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_property_text_info_word_wrap([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_path_type")]
    public static extern obs_path_type obs_property_path_type([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_path_filter([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_path_default_path([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_combo_type")]
    public static extern obs_combo_type obs_property_list_type([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_combo_format")]
    public static extern obs_combo_format obs_property_list_format([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_int_set_limits([NativeTypeName("obs_property_t *")] obs_property* p, int min, int max, int step);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_float_set_limits([NativeTypeName("obs_property_t *")] obs_property* p, double min, double max, double step);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_int_set_suffix([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("const char *")] sbyte* suffix);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_float_set_suffix([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("const char *")] sbyte* suffix);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_text_set_monospace([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("bool")] byte monospace);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_text_set_info_type([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("enum obs_text_info_type")] obs_text_info_type type);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_text_set_info_word_wrap([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("bool")] byte word_wrap);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_button_set_type([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("enum obs_button_type")] obs_button_type type);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_button_set_url([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("char *")] sbyte* url);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_list_clear([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_property_list_add_string([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_property_list_add_int([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("long long")] long val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_property_list_add_float([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("const char *")] sbyte* name, double val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_list_insert_string([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_list_insert_int([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("long long")] long val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_list_insert_float([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx, [NativeTypeName("const char *")] sbyte* name, double val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_list_item_disable([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx, [NativeTypeName("bool")] byte disabled);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_property_list_item_disabled([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_list_item_remove([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_property_list_item_count([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_list_item_name([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_list_item_string([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("long long")]
    public static extern long obs_property_list_item_int([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double obs_property_list_item_float([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_editable_list_type")]
    public static extern obs_editable_list_type obs_property_editable_list_type([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_editable_list_filter([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_editable_list_default_path([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_frame_rate_clear([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_frame_rate_options_clear([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_frame_rate_fps_ranges_clear([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_property_frame_rate_option_add([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_property_frame_rate_fps_range_add([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("struct media_frames_per_second")] media_frames_per_second min, [NativeTypeName("struct media_frames_per_second")] media_frames_per_second max);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_frame_rate_option_insert([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* description);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_property_frame_rate_fps_range_insert([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx, [NativeTypeName("struct media_frames_per_second")] media_frames_per_second min, [NativeTypeName("struct media_frames_per_second")] media_frames_per_second max);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_property_frame_rate_options_count([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_frame_rate_option_name([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_frame_rate_option_description([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_property_frame_rate_fps_ranges_count([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("struct media_frames_per_second")]
    public static extern media_frames_per_second obs_property_frame_rate_fps_range_min([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("struct media_frames_per_second")]
    public static extern media_frames_per_second obs_property_frame_rate_fps_range_max([NativeTypeName("obs_property_t *")] obs_property* p, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_group_type")]
    public static extern obs_group_type obs_property_group_type([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_properties_t *")]
    public static extern obs_properties* obs_property_group_content([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_button_type")]
    public static extern obs_button_type obs_property_button_type([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_property_button_url([NativeTypeName("obs_property_t *")] obs_property* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_text_type")]
    [Obsolete]
    public static extern obs_text_type obs_proprety_text_type([NativeTypeName("obs_property_t *")] obs_property* p);

    [NativeTypeName("#define OBS_PROPERTIES_DEFER_UPDATE (1 << 0)")]
    public const int OBS_PROPERTIES_DEFER_UPDATE = (1 << 0);

    [NativeTypeName("#define OBS_FONT_BOLD (1 << 0)")]
    public const int OBS_FONT_BOLD = (1 << 0);

    [NativeTypeName("#define OBS_FONT_ITALIC (1 << 1)")]
    public const int OBS_FONT_ITALIC = (1 << 1);

    [NativeTypeName("#define OBS_FONT_UNDERLINE (1 << 2)")]
    public const int OBS_FONT_UNDERLINE = (1 << 2);

    [NativeTypeName("#define OBS_FONT_STRIKEOUT (1 << 3)")]
    public const int OBS_FONT_STRIKEOUT = (1 << 3);
}
