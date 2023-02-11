using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsMathExtra
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void polar_to_cart([NativeTypeName("struct vec3 *")] System.Numerics.Vector3* dst, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void cart_to_polar([NativeTypeName("struct vec3 *")] System.Numerics.Vector3* dst, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void norm_to_polar([NativeTypeName("struct vec2 *")] System.Numerics.Vector2* dst, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* norm);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void polar_to_norm([NativeTypeName("struct vec3 *")] System.Numerics.Vector3* dst, [NativeTypeName("const struct vec2 *")] System.Numerics.Vector2* polar);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float calc_torquef(float val1, float val2, float torque, float min_adjust, float t);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void calc_torque([NativeTypeName("struct vec3 *")] System.Numerics.Vector3* dst, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v1, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v2, float torque, float min_adjust, float t);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float rand_float(int positive_only);
}
