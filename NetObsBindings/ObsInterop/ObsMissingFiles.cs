using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsMissingFiles
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_missing_files_t *")]
    public static extern obs_missing_files* obs_missing_files_create();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_missing_file_t *")]
    public static extern obs_missing_file* obs_missing_file_create([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("obs_missing_file_cb")] delegate* unmanaged[Cdecl]<void*, sbyte*, void*, void> callback, int src_type, void* src, void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_missing_files_add_file([NativeTypeName("obs_missing_files_t *")] obs_missing_files* files, [NativeTypeName("obs_missing_file_t *")] obs_missing_file* file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint obs_missing_files_count([NativeTypeName("obs_missing_files_t *")] obs_missing_files* files);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("obs_missing_file_t *")]
    public static extern obs_missing_file* obs_missing_files_get_file([NativeTypeName("obs_missing_files_t *")] obs_missing_files* files, int idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_missing_files_destroy([NativeTypeName("obs_missing_files_t *")] obs_missing_files* files);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_missing_files_append([NativeTypeName("obs_missing_files_t *")] obs_missing_files* dst, [NativeTypeName("obs_missing_files_t *")] obs_missing_files* src);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_missing_file_issue_callback([NativeTypeName("obs_missing_file_t *")] obs_missing_file* file, [NativeTypeName("const char *")] sbyte* new_path);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_missing_file_get_path([NativeTypeName("obs_missing_file_t *")] obs_missing_file* file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* obs_missing_file_get_source_name([NativeTypeName("obs_missing_file_t *")] obs_missing_file* file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_missing_file_release([NativeTypeName("obs_missing_file_t *")] obs_missing_file* file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_missing_file_destroy([NativeTypeName("obs_missing_file_t *")] obs_missing_file* file);
}
