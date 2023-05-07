using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsInput
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int input_getbuttonstate([NativeTypeName("input_t *")] input_subsystem* input, [NativeTypeName("uint32_t")] uint button);
}
