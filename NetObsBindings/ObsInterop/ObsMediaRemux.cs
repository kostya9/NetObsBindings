using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsMediaRemux
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte media_remux_job_create([NativeTypeName("media_remux_job_t *")] media_remux_job** job, [NativeTypeName("const char *")] sbyte* in_filename, [NativeTypeName("const char *")] sbyte* out_filename);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte media_remux_job_process([NativeTypeName("media_remux_job_t")] media_remux_job* job, [NativeTypeName("media_remux_progress_callback")] delegate* unmanaged[Cdecl]<void*, float, byte> callback, void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void media_remux_job_destroy([NativeTypeName("media_remux_job_t")] media_remux_job* job);
}
