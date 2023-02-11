using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsMatrix4
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_from_matrix3([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct matrix3 *")] matrix3* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_from_quat([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct quat *")] System.Numerics.Quaternion* q);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_from_axisang([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct axisang *")] axisang* aa);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_mul([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct matrix4 *")] matrix4* m1, [NativeTypeName("const struct matrix4 *")] matrix4* m2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float matrix4_determinant([NativeTypeName("const struct matrix4 *")] matrix4* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_translate3v([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct matrix4 *")] matrix4* m, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_translate4v([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct matrix4 *")] matrix4* m, [NativeTypeName("const struct vec4 *")] System.Numerics.Vector4* v);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_rotate([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct matrix4 *")] matrix4* m, [NativeTypeName("const struct quat *")] System.Numerics.Quaternion* q);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_rotate_aa([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct matrix4 *")] matrix4* m, [NativeTypeName("const struct axisang *")] axisang* aa);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_scale([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct matrix4 *")] matrix4* m, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte matrix4_inv([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct matrix4 *")] matrix4* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_transpose([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct matrix4 *")] matrix4* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_translate3v_i([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v, [NativeTypeName("const struct matrix4 *")] matrix4* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_translate4v_i([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct vec4 *")] System.Numerics.Vector4* v, [NativeTypeName("const struct matrix4 *")] matrix4* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_rotate_i([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct quat *")] System.Numerics.Quaternion* q, [NativeTypeName("const struct matrix4 *")] matrix4* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_rotate_aa_i([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct axisang *")] axisang* aa, [NativeTypeName("const struct matrix4 *")] matrix4* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void matrix4_scale_i([NativeTypeName("struct matrix4 *")] matrix4* dst, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v, [NativeTypeName("const struct matrix4 *")] matrix4* m);
}
