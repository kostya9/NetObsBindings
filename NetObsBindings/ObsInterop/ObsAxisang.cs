using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsAxisang
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void axisang_from_quat([NativeTypeName("struct axisang *")] axisang* dst, [NativeTypeName("const struct quat *")] System.Numerics.Quaternion* q);
}
