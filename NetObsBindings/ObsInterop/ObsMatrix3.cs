using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsMatrix3
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix3_from_quat([NativeTypeName("struct matrix3 *")] matrix3* dst, [NativeTypeName("const struct quat *")] System.Numerics.Quaternion* q);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix3_from_axisang([NativeTypeName("struct matrix3 *")] matrix3* dst, [NativeTypeName("const struct axisang *")] axisang* aa);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix3_from_matrix4([NativeTypeName("struct matrix3 *")] matrix3* dst, [NativeTypeName("const struct matrix4 *")] matrix4* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix3_mul([NativeTypeName("struct matrix3 *")] matrix3* dst, [NativeTypeName("const struct matrix3 *")] matrix3* m1, [NativeTypeName("const struct matrix3 *")] matrix3* m2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix3_rotate([NativeTypeName("struct matrix3 *")] matrix3* dst, [NativeTypeName("const struct matrix3 *")] matrix3* m, [NativeTypeName("const struct quat *")] System.Numerics.Quaternion* q);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix3_rotate_aa([NativeTypeName("struct matrix3 *")] matrix3* dst, [NativeTypeName("const struct matrix3 *")] matrix3* m, [NativeTypeName("const struct axisang *")] axisang* aa);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix3_scale([NativeTypeName("struct matrix3 *")] matrix3* dst, [NativeTypeName("const struct matrix3 *")] matrix3* m, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix3_transpose([NativeTypeName("struct matrix3 *")] matrix3* dst, [NativeTypeName("const struct matrix3 *")] matrix3* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix3_inv([NativeTypeName("struct matrix3 *")] matrix3* dst, [NativeTypeName("const struct matrix3 *")] matrix3* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix3_mirror([NativeTypeName("struct matrix3 *")] matrix3* dst, [NativeTypeName("const struct matrix3 *")] matrix3* m, [NativeTypeName("const struct plane *")] plane* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix3_mirrorv([NativeTypeName("struct matrix3 *")] matrix3* dst, [NativeTypeName("const struct matrix3 *")] matrix3* m, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v);
}
