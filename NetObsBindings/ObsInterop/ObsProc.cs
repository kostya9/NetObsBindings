using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsProc
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("proc_handler_t *")]
    public static extern proc_handler* proc_handler_create();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void proc_handler_destroy([NativeTypeName("proc_handler_t *")] proc_handler* handler);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void proc_handler_add([NativeTypeName("proc_handler_t *")] proc_handler* handler, [NativeTypeName("const char *")] sbyte* decl_string, [NativeTypeName("proc_handler_proc_t")] delegate* unmanaged[Cdecl]<void*, calldata*, void> proc, void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte proc_handler_call([NativeTypeName("proc_handler_t *")] proc_handler* handler, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("calldata_t *")] calldata* @params);
}
