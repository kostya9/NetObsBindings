using System;
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

    [NativeTypeName("#define S__LINE__ STRINGIFY_(__LINE__)")]
    public static ReadOnlySpan<byte> S__LINE__ => new byte[] { 0x37, 0x00 };

    [NativeTypeName("#define INT_CUR_LINE __LINE__")]
    public const int INT_CUR_LINE = 9;

    [NativeTypeName("#define FILE_LINE __FILE__ \" (\" S__LINE__ \"): \"")]
    public static ReadOnlySpan<byte> FILE_LINE => new byte[] { 0x2E, 0x5C, 0x67, 0x65, 0x6E, 0x65, 0x72, 0x61, 0x74, 0x65, 0x5C, 0x75, 0x74, 0x69, 0x6C, 0x5C, 0x6F, 0x62, 0x73, 0x2D, 0x75, 0x74, 0x69, 0x6C, 0x2E, 0x68, 0x20, 0x28, 0x31, 0x31, 0x29, 0x3A, 0x20, 0x00 };
}
