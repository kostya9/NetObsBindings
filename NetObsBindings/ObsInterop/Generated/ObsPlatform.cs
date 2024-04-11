using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsPlatform
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FILE *")]
    public static extern nint os_wfopen([NativeTypeName("const wchar_t *")] ushort* path, [NativeTypeName("const char *")] sbyte* mode);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FILE *")]
    public static extern nint os_fopen([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* mode);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int64_t")]
    public static extern long os_fgetsize([NativeTypeName("FILE *")] nint file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_stat([NativeTypeName("const char *")] sbyte* file, [NativeTypeName("struct stat *")] nint st);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_fseeki64([NativeTypeName("FILE *")] nint file, [NativeTypeName("int64_t")] long offset, int origin);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int64_t")]
    public static extern long os_ftelli64([NativeTypeName("FILE *")] nint file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint os_fread_mbs([NativeTypeName("FILE *")] nint file, [NativeTypeName("char **")] sbyte** pstr);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint os_fread_utf8([NativeTypeName("FILE *")] nint file, [NativeTypeName("char **")] sbyte** pstr);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* os_quick_read_utf8_file([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte os_quick_write_utf8_file([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint len, [NativeTypeName("bool")] byte marker);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte os_quick_write_utf8_file_safe([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint len, [NativeTypeName("bool")] byte marker, [NativeTypeName("const char *")] sbyte* temp_ext, [NativeTypeName("const char *")] sbyte* backup_ext);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* os_quick_read_mbs_file([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte os_quick_write_mbs_file([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint len);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int64_t")]
    public static extern long os_get_file_size([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int64_t")]
    public static extern long os_get_free_space([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint os_mbs_to_wcs([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint str_len, [NativeTypeName("wchar_t *")] ushort* dst, [NativeTypeName("size_t")] nuint dst_size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint os_utf8_to_wcs([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint len, [NativeTypeName("wchar_t *")] ushort* dst, [NativeTypeName("size_t")] nuint dst_size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint os_wcs_to_mbs([NativeTypeName("const wchar_t *")] ushort* str, [NativeTypeName("size_t")] nuint len, [NativeTypeName("char *")] sbyte* dst, [NativeTypeName("size_t")] nuint dst_size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint os_wcs_to_utf8([NativeTypeName("const wchar_t *")] ushort* str, [NativeTypeName("size_t")] nuint len, [NativeTypeName("char *")] sbyte* dst, [NativeTypeName("size_t")] nuint dst_size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint os_mbs_to_wcs_ptr([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint len, [NativeTypeName("wchar_t **")] ushort** pstr);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint os_utf8_to_wcs_ptr([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint len, [NativeTypeName("wchar_t **")] ushort** pstr);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint os_wcs_to_mbs_ptr([NativeTypeName("const wchar_t *")] ushort* str, [NativeTypeName("size_t")] nuint len, [NativeTypeName("char **")] sbyte** pstr);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint os_wcs_to_utf8_ptr([NativeTypeName("const wchar_t *")] ushort* str, [NativeTypeName("size_t")] nuint len, [NativeTypeName("char **")] sbyte** pstr);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint os_utf8_to_mbs_ptr([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint len, [NativeTypeName("char **")] sbyte** pstr);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint os_mbs_to_utf8_ptr([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint len, [NativeTypeName("char **")] sbyte** pstr);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double os_strtod([NativeTypeName("const char *")] sbyte* str);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_dtostr(double value, [NativeTypeName("char *")] sbyte* dst, [NativeTypeName("size_t")] nuint size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* os_dlopen([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* os_dlsym(void* module, [NativeTypeName("const char *")] sbyte* func);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void os_dlclose(void* module);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte os_is_obs_plugin([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("os_cpu_usage_info_t *")]
    public static extern os_cpu_usage_info* os_cpu_usage_info_start();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double os_cpu_usage_info_query([NativeTypeName("os_cpu_usage_info_t *")] os_cpu_usage_info* info);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void os_cpu_usage_info_destroy([NativeTypeName("os_cpu_usage_info_t *")] os_cpu_usage_info* info);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("os_performance_token_t *")]
    public static extern void* os_request_high_performance([NativeTypeName("const char *")] sbyte* reason);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void os_end_high_performance([NativeTypeName("os_performance_token_t *")] void* param0);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte os_sleepto_ns([NativeTypeName("uint64_t")] ulong time_target);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte os_sleepto_ns_fast([NativeTypeName("uint64_t")] ulong time_target);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void os_sleep_ms([NativeTypeName("uint32_t")] uint duration);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong os_gettime_ns();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_get_config_path([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("size_t")] nuint size, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* os_get_config_path_ptr([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_get_program_data_path([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("size_t")] nuint size, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* os_get_program_data_path_ptr([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* os_get_executable_path_ptr([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte os_file_exists([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint os_get_abs_path([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("char *")] sbyte* abspath, [NativeTypeName("size_t")] nuint size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* os_get_abs_path_ptr([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* os_get_path_extension([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte os_get_emulation_status();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("os_dir_t *")]
    public static extern os_dir* os_opendir([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("struct os_dirent *")]
    public static extern os_dirent* os_readdir([NativeTypeName("os_dir_t *")] os_dir* dir);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void os_closedir([NativeTypeName("os_dir_t *")] os_dir* dir);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_glob([NativeTypeName("const char *")] sbyte* pattern, int flags, [NativeTypeName("os_glob_t **")] os_glob_info** pglob);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void os_globfree([NativeTypeName("os_glob_t *")] os_glob_info* pglob);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_unlink([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_rmdir([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* os_getcwd([NativeTypeName("char *")] sbyte* path, [NativeTypeName("size_t")] nuint size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_chdir([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong os_get_free_disk_space([NativeTypeName("const char *")] sbyte* dir);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_mkdir([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_mkdirs([NativeTypeName("const char *")] sbyte* path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_rename([NativeTypeName("const char *")] sbyte* old_path, [NativeTypeName("const char *")] sbyte* new_path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_copyfile([NativeTypeName("const char *")] sbyte* file_in, [NativeTypeName("const char *")] sbyte* file_out);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_safe_replace([NativeTypeName("const char *")] sbyte* target_path, [NativeTypeName("const char *")] sbyte* from_path, [NativeTypeName("const char *")] sbyte* backup_path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* os_generate_formatted_filename([NativeTypeName("const char *")] sbyte* extension, [NativeTypeName("bool")] byte space, [NativeTypeName("const char *")] sbyte* format);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("os_inhibit_t *")]
    public static extern os_inhibit_info* os_inhibit_sleep_create([NativeTypeName("const char *")] sbyte* reason);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte os_inhibit_sleep_set_active([NativeTypeName("os_inhibit_t *")] os_inhibit_info* info, [NativeTypeName("bool")] byte active);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void os_inhibit_sleep_destroy([NativeTypeName("os_inhibit_t *")] os_inhibit_info* info);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void os_breakpoint();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_get_physical_cores();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int os_get_logical_cores();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong os_get_sys_free_size();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong os_get_sys_total_size();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte os_get_proc_memory_usage([NativeTypeName("os_proc_memory_usage_t *")] os_proc_memory_usage* usage);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong os_get_proc_resident_size();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong os_get_proc_virtual_size();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* os_generate_uuid();

    [NativeTypeName("#define MKDIR_EXISTS 1")]
    public const int MKDIR_EXISTS = 1;

    [NativeTypeName("#define MKDIR_SUCCESS 0")]
    public const int MKDIR_SUCCESS = 0;

    [NativeTypeName("#define MKDIR_ERROR -1")]
    public const int MKDIR_ERROR = -1;

    [NativeTypeName("#define UUID_STR_LENGTH 36")]
    public const int UUID_STR_LENGTH = 36;
}
