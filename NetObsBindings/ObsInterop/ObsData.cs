using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsData
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern obs_data* obs_data_create();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern obs_data* obs_data_create_from_json([NativeTypeName("const char *")] sbyte* json_string);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern obs_data* obs_data_create_from_json_file([NativeTypeName("const char *")] sbyte* json_file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern obs_data* obs_data_create_from_json_file_safe([NativeTypeName("const char *")] sbyte* json_file, [NativeTypeName("const char *")] sbyte* backup_ext);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_addref([NativeTypeName("obs_data_t *")] obs_data* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_release([NativeTypeName("obs_data_t *")] obs_data* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_data_get_json([NativeTypeName("obs_data_t *")] obs_data* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_data_get_last_json([NativeTypeName("obs_data_t *")] obs_data* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_save_json([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_save_json_safe([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* file, [NativeTypeName("const char *")] sbyte* temp_ext, [NativeTypeName("const char *")] sbyte* backup_ext);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_apply([NativeTypeName("obs_data_t *")] obs_data* target, [NativeTypeName("obs_data_t *")] obs_data* apply_data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_erase([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_clear([NativeTypeName("obs_data_t *")] obs_data* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_string([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_int([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("long long")] long val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_double([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, double val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_bool([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("bool")] byte val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_obj([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_data_t *")] obs_data* obj);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_array([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_data_array_t *")] obs_data_array* array);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern obs_data* obs_data_get_defaults([NativeTypeName("obs_data_t *")] obs_data* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_default_string([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_default_int([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("long long")] long val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_default_double([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, double val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_default_bool([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("bool")] byte val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_default_obj([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_data_t *")] obs_data* obj);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_default_array([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_data_array_t *")] obs_data_array* arr);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_autoselect_string([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_autoselect_int([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("long long")] long val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_autoselect_double([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, double val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_autoselect_bool([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("bool")] byte val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_autoselect_obj([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("obs_data_t *")] obs_data* obj);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_data_get_string([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("long long")]
    public static extern long obs_data_get_int([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double obs_data_get_double([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_get_bool([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern obs_data* obs_data_get_obj([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_array_t *")]
    public static extern obs_data_array* obs_data_get_array([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_data_get_default_string([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("long long")]
    public static extern long obs_data_get_default_int([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double obs_data_get_default_double([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_get_default_bool([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern obs_data* obs_data_get_default_obj([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_array_t *")]
    public static extern obs_data_array* obs_data_get_default_array([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_data_get_autoselect_string([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("long long")]
    public static extern long obs_data_get_autoselect_int([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double obs_data_get_autoselect_double([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_get_autoselect_bool([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern obs_data* obs_data_get_autoselect_obj([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_array_t *")]
    public static extern obs_data_array* obs_data_get_autoselect_array([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_array_t *")]
    public static extern obs_data_array* obs_data_array_create();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_array_addref([NativeTypeName("obs_data_array_t *")] obs_data_array* array);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_array_release([NativeTypeName("obs_data_array_t *")] obs_data_array* array);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_data_array_count([NativeTypeName("obs_data_array_t *")] obs_data_array* array);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern obs_data* obs_data_array_item([NativeTypeName("obs_data_array_t *")] obs_data_array* array, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_data_array_push_back([NativeTypeName("obs_data_array_t *")] obs_data_array* array, [NativeTypeName("obs_data_t *")] obs_data* obj);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_array_insert([NativeTypeName("obs_data_array_t *")] obs_data_array* array, [NativeTypeName("size_t")] nuint idx, [NativeTypeName("obs_data_t *")] obs_data* obj);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_array_push_back_array([NativeTypeName("obs_data_array_t *")] obs_data_array* array, [NativeTypeName("obs_data_array_t *")] obs_data_array* array2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_array_erase([NativeTypeName("obs_data_array_t *")] obs_data_array* array, [NativeTypeName("size_t")] nuint idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_array_enum([NativeTypeName("obs_data_array_t *")] obs_data_array* array, [NativeTypeName("void (*)(obs_data_t *, void *)")] delegate* unmanaged[Cdecl]<obs_data*, void*, void> cb, void* param2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_has_user_value([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_has_default_value([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_has_autoselect_value([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_item_has_user_value([NativeTypeName("obs_data_item_t *")] obs_data_item* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_item_has_default_value([NativeTypeName("obs_data_item_t *")] obs_data_item* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_item_has_autoselect_value([NativeTypeName("obs_data_item_t *")] obs_data_item* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_unset_user_value([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_unset_default_value([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_unset_autoselect_value([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_unset_user_value([NativeTypeName("obs_data_item_t *")] obs_data_item* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_unset_default_value([NativeTypeName("obs_data_item_t *")] obs_data_item* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_unset_autoselect_value([NativeTypeName("obs_data_item_t *")] obs_data_item* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_item_t *")]
    public static extern obs_data_item* obs_data_first([NativeTypeName("obs_data_t *")] obs_data* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_item_t *")]
    public static extern obs_data_item* obs_data_item_byname([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_item_next([NativeTypeName("obs_data_item_t **")] obs_data_item** item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_release([NativeTypeName("obs_data_item_t **")] obs_data_item** item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_remove([NativeTypeName("obs_data_item_t **")] obs_data_item** item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_data_type")]
    public static extern obs_data_type obs_data_item_gettype([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum obs_data_number_type")]
    public static extern obs_data_number_type obs_data_item_numtype([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_data_item_get_name([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_string([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("const char *")] sbyte* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_int([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("long long")] long val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_double([NativeTypeName("obs_data_item_t **")] obs_data_item** item, double val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_bool([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("bool")] byte val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_obj([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("obs_data_t *")] obs_data* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_array([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("obs_data_array_t *")] obs_data_array* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_default_string([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("const char *")] sbyte* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_default_int([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("long long")] long val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_default_double([NativeTypeName("obs_data_item_t **")] obs_data_item** item, double val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_default_bool([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("bool")] byte val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_default_obj([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("obs_data_t *")] obs_data* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_default_array([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("obs_data_array_t *")] obs_data_array* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_autoselect_string([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("const char *")] sbyte* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_autoselect_int([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("long long")] long val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_autoselect_double([NativeTypeName("obs_data_item_t **")] obs_data_item** item, double val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_autoselect_bool([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("bool")] byte val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_autoselect_obj([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("obs_data_t *")] obs_data* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_autoselect_array([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("obs_data_array_t *")] obs_data_array* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_data_item_get_string([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("long long")]
    public static extern long obs_data_item_get_int([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double obs_data_item_get_double([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_item_get_bool([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern obs_data* obs_data_item_get_obj([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_array_t *")]
    public static extern obs_data_array* obs_data_item_get_array([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_data_item_get_default_string([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("long long")]
    public static extern long obs_data_item_get_default_int([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double obs_data_item_get_default_double([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_item_get_default_bool([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern obs_data* obs_data_item_get_default_obj([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_array_t *")]
    public static extern obs_data_array* obs_data_item_get_default_array([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_data_item_get_autoselect_string([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("long long")]
    public static extern long obs_data_item_get_autoselect_int([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double obs_data_item_get_autoselect_double([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_item_get_autoselect_bool([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_t *")]
    public static extern obs_data* obs_data_item_get_autoselect_obj([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_data_array_t *")]
    public static extern obs_data_array* obs_data_item_get_autoselect_array([NativeTypeName("obs_data_item_t *")] obs_data_item* item);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_vec2([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const struct vec2 *")] System.Numerics.Vector2* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_vec3([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_vec4([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const struct vec4 *")] System.Numerics.Vector4* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_quat([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const struct quat *")] System.Numerics.Quaternion* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_default_vec2([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const struct vec2 *")] System.Numerics.Vector2* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_default_vec3([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_default_vec4([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const struct vec4 *")] System.Numerics.Vector4* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_default_quat([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const struct quat *")] System.Numerics.Quaternion* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_autoselect_vec2([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const struct vec2 *")] System.Numerics.Vector2* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_autoselect_vec3([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_autoselect_vec4([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const struct vec4 *")] System.Numerics.Vector4* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_autoselect_quat([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const struct quat *")] System.Numerics.Quaternion* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_get_vec2([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct vec2 *")] System.Numerics.Vector2* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_get_vec3([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct vec3 *")] System.Numerics.Vector3* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_get_vec4([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct vec4 *")] System.Numerics.Vector4* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_get_quat([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct quat *")] System.Numerics.Quaternion* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_get_default_vec2([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct vec2 *")] System.Numerics.Vector2* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_get_default_vec3([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct vec3 *")] System.Numerics.Vector3* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_get_default_vec4([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct vec4 *")] System.Numerics.Vector4* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_get_default_quat([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct quat *")] System.Numerics.Quaternion* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_get_autoselect_vec2([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct vec2 *")] System.Numerics.Vector2* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_get_autoselect_vec3([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct vec3 *")] System.Numerics.Vector3* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_get_autoselect_vec4([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct vec4 *")] System.Numerics.Vector4* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_get_autoselect_quat([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct quat *")] System.Numerics.Quaternion* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_frames_per_second([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct media_frames_per_second")] media_frames_per_second fps, [NativeTypeName("const char *")] sbyte* option);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_default_frames_per_second([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct media_frames_per_second")] media_frames_per_second fps, [NativeTypeName("const char *")] sbyte* option);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_set_autoselect_frames_per_second([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct media_frames_per_second")] media_frames_per_second fps, [NativeTypeName("const char *")] sbyte* option);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_get_frames_per_second([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct media_frames_per_second *")] media_frames_per_second* fps, [NativeTypeName("const char **")] sbyte** option);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_get_default_frames_per_second([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct media_frames_per_second *")] media_frames_per_second* fps, [NativeTypeName("const char **")] sbyte** option);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_get_autoselect_frames_per_second([NativeTypeName("obs_data_t *")] obs_data* data, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct media_frames_per_second *")] media_frames_per_second* fps, [NativeTypeName("const char **")] sbyte** option);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_frames_per_second([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("struct media_frames_per_second")] media_frames_per_second fps, [NativeTypeName("const char *")] sbyte* option);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_default_frames_per_second([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("struct media_frames_per_second")] media_frames_per_second fps, [NativeTypeName("const char *")] sbyte* option);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_data_item_set_autoselect_frames_per_second([NativeTypeName("obs_data_item_t **")] obs_data_item** item, [NativeTypeName("struct media_frames_per_second")] media_frames_per_second fps, [NativeTypeName("const char *")] sbyte* option);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_item_get_frames_per_second([NativeTypeName("obs_data_item_t *")] obs_data_item* item, [NativeTypeName("struct media_frames_per_second *")] media_frames_per_second* fps, [NativeTypeName("const char **")] sbyte** option);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_item_get_default_frames_per_second([NativeTypeName("obs_data_item_t *")] obs_data_item* item, [NativeTypeName("struct media_frames_per_second *")] media_frames_per_second* fps, [NativeTypeName("const char **")] sbyte** option);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte obs_data_item_get_autoselect_frames_per_second([NativeTypeName("obs_data_item_t *")] obs_data_item* item, [NativeTypeName("struct media_frames_per_second *")] media_frames_per_second* fps, [NativeTypeName("const char **")] sbyte** option);
}
