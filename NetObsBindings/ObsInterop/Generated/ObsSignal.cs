using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsSignal
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("signal_handler_t *")]
    public static extern signal_handler* signal_handler_create();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void signal_handler_destroy([NativeTypeName("signal_handler_t *")] signal_handler* handler);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte signal_handler_add([NativeTypeName("signal_handler_t *")] signal_handler* handler, [NativeTypeName("const char *")] sbyte* signal_decl);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void signal_handler_connect([NativeTypeName("signal_handler_t *")] signal_handler* handler, [NativeTypeName("const char *")] sbyte* signal, [NativeTypeName("signal_callback_t")] delegate* unmanaged[Cdecl]<void*, calldata*, void> callback, void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void signal_handler_connect_ref([NativeTypeName("signal_handler_t *")] signal_handler* handler, [NativeTypeName("const char *")] sbyte* signal, [NativeTypeName("signal_callback_t")] delegate* unmanaged[Cdecl]<void*, calldata*, void> callback, void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void signal_handler_disconnect([NativeTypeName("signal_handler_t *")] signal_handler* handler, [NativeTypeName("const char *")] sbyte* signal, [NativeTypeName("signal_callback_t")] delegate* unmanaged[Cdecl]<void*, calldata*, void> callback, void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void signal_handler_connect_global([NativeTypeName("signal_handler_t *")] signal_handler* handler, [NativeTypeName("global_signal_callback_t")] delegate* unmanaged[Cdecl]<void*, sbyte*, calldata*, void> callback, void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void signal_handler_disconnect_global([NativeTypeName("signal_handler_t *")] signal_handler* handler, [NativeTypeName("global_signal_callback_t")] delegate* unmanaged[Cdecl]<void*, sbyte*, calldata*, void> callback, void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void signal_handler_remove_current();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void signal_handler_signal([NativeTypeName("signal_handler_t *")] signal_handler* handler, [NativeTypeName("const char *")] sbyte* signal, [NativeTypeName("calldata_t *")] calldata* @params);
}
