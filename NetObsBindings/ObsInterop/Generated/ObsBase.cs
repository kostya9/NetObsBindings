using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsBase
{
    public const int LOG_ERROR = 100;
    public const int LOG_WARNING = 200;
    public const int LOG_INFO = 300;
    public const int LOG_DEBUG = 400;

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void base_get_log_handler([NativeTypeName("log_handler_t *")] delegate* unmanaged[Cdecl]<int, sbyte*, sbyte*, void*, void>* handler, void** param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void base_set_log_handler([NativeTypeName("log_handler_t")] delegate* unmanaged[Cdecl]<int, sbyte*, sbyte*, void*, void> handler, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void base_set_crash_handler([NativeTypeName("void (*)(const char *, va_list, void *)")] delegate* unmanaged[Cdecl]<sbyte*, sbyte*, void*, void> handler, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void bcrash([NativeTypeName("const char *")] sbyte* format, __arglist);
}
