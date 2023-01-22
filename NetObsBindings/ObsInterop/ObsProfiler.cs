using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsProfiler
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profile_register_root([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint64_t")] ulong expected_time_between_calls);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profile_start([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profile_end([NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profile_reenable_thread();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profiler_start();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profiler_stop();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profiler_print([NativeTypeName("profiler_snapshot_t *")] profiler_snapshot* snap);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profiler_print_time_between_calls([NativeTypeName("profiler_snapshot_t *")] profiler_snapshot* snap);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profiler_free();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("profiler_name_store_t *")]
    public static extern profiler_name_store* profiler_name_store_create();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profiler_name_store_free([NativeTypeName("profiler_name_store_t *")] profiler_name_store* store);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* profile_store_name([NativeTypeName("profiler_name_store_t *")] profiler_name_store* store, [NativeTypeName("const char *")] sbyte* format, __arglist);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("profiler_snapshot_t *")]
    public static extern profiler_snapshot* profile_snapshot_create();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profile_snapshot_free([NativeTypeName("profiler_snapshot_t *")] profiler_snapshot* snap);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte profiler_snapshot_dump_csv([NativeTypeName("const profiler_snapshot_t *")] profiler_snapshot* snap, [NativeTypeName("const char *")] sbyte* filename);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte profiler_snapshot_dump_csv_gz([NativeTypeName("const profiler_snapshot_t *")] profiler_snapshot* snap, [NativeTypeName("const char *")] sbyte* filename);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint profiler_snapshot_num_roots([NativeTypeName("profiler_snapshot_t *")] profiler_snapshot* snap);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profiler_snapshot_enumerate_roots([NativeTypeName("profiler_snapshot_t *")] profiler_snapshot* snap, [NativeTypeName("profiler_entry_enum_func")] delegate* unmanaged[Cdecl]<void*, profiler_snapshot_entry*, byte> func, void* context);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profiler_snapshot_filter_roots([NativeTypeName("profiler_snapshot_t *")] profiler_snapshot* snap, [NativeTypeName("profiler_name_filter_func")] delegate* unmanaged[Cdecl]<void*, sbyte*, bool*, byte> func, void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint profiler_snapshot_num_children([NativeTypeName("profiler_snapshot_entry_t *")] profiler_snapshot_entry* entry);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void profiler_snapshot_enumerate_children([NativeTypeName("profiler_snapshot_entry_t *")] profiler_snapshot_entry* entry, [NativeTypeName("profiler_entry_enum_func")] delegate* unmanaged[Cdecl]<void*, profiler_snapshot_entry*, byte> func, void* context);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* profiler_snapshot_entry_name([NativeTypeName("profiler_snapshot_entry_t *")] profiler_snapshot_entry* entry);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern profiler_time_entries_t* profiler_snapshot_entry_times([NativeTypeName("profiler_snapshot_entry_t *")] profiler_snapshot_entry* entry);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong profiler_snapshot_entry_min_time([NativeTypeName("profiler_snapshot_entry_t *")] profiler_snapshot_entry* entry);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong profiler_snapshot_entry_max_time([NativeTypeName("profiler_snapshot_entry_t *")] profiler_snapshot_entry* entry);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong profiler_snapshot_entry_overall_count([NativeTypeName("profiler_snapshot_entry_t *")] profiler_snapshot_entry* entry);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern profiler_time_entries_t* profiler_snapshot_entry_times_between_calls([NativeTypeName("profiler_snapshot_entry_t *")] profiler_snapshot_entry* entry);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong profiler_snapshot_entry_expected_time_between_calls([NativeTypeName("profiler_snapshot_entry_t *")] profiler_snapshot_entry* entry);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong profiler_snapshot_entry_min_time_between_calls([NativeTypeName("profiler_snapshot_entry_t *")] profiler_snapshot_entry* entry);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong profiler_snapshot_entry_max_time_between_calls([NativeTypeName("profiler_snapshot_entry_t *")] profiler_snapshot_entry* entry);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong profiler_snapshot_entry_overall_between_calls_count([NativeTypeName("profiler_snapshot_entry_t *")] profiler_snapshot_entry* entry);
}
