using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsBase
{
    // Due to a limitation in the .NET Runtime, there is currently no portable way to do P/Invoke with varargs in C#.
    // Until https://github.com/dotnet/runtime/issues/48796 is resolved and support is added to ClangSharp, we can only
    // provide non-varargs bindings to prevent silent portability bugs (i.e., crashes on Linux and possibly other
    // platforms).
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void blog(int log_level, [NativeTypeName("const char *")] sbyte* format);
}
