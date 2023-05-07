using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsBounds
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void bounds_move([NativeTypeName("struct bounds *")] bounds* dst, [NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void bounds_scale([NativeTypeName("struct bounds *")] bounds* dst, [NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void bounds_merge([NativeTypeName("struct bounds *")] bounds* dst, [NativeTypeName("const struct bounds *")] bounds* b1, [NativeTypeName("const struct bounds *")] bounds* b2);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void bounds_merge_point([NativeTypeName("struct bounds *")] bounds* dst, [NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void bounds_get_point([NativeTypeName("struct vec3 *")] System.Numerics.Vector3* dst, [NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("unsigned int")] uint i);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void bounds_get_center([NativeTypeName("struct vec3 *")] System.Numerics.Vector3* dst, [NativeTypeName("const struct bounds *")] bounds* b);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void bounds_transform([NativeTypeName("struct bounds *")] bounds* dst, [NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("const struct matrix4 *")] matrix4* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void bounds_transform3x4([NativeTypeName("struct bounds *")] bounds* dst, [NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("const struct matrix3 *")] matrix3* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte bounds_intersection_ray([NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* orig, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* dir, float* t);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte bounds_intersection_line([NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* p1, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* p2, float* t);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte bounds_plane_test([NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("const struct plane *")] plane* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte bounds_under_plane([NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("const struct plane *")] plane* p);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte bounds_intersects([NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("const struct bounds *")] bounds* test, float epsilon);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte bounds_intersects_obb([NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("const struct bounds *")] bounds* test, [NativeTypeName("const struct matrix4 *")] matrix4* m, float epsilon);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte bounds_intersects_obb3x4([NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("const struct bounds *")] bounds* test, [NativeTypeName("const struct matrix3 *")] matrix3* m, float epsilon);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float bounds_min_dist([NativeTypeName("const struct bounds *")] bounds* b, [NativeTypeName("const struct plane *")] plane* p);

    [NativeTypeName("#define BOUNDS_OUTSIDE 1")]
    public const int BOUNDS_OUTSIDE = 1;

    [NativeTypeName("#define BOUNDS_INSIDE 2")]
    public const int BOUNDS_INSIDE = 2;

    [NativeTypeName("#define BOUNDS_PARTIAL 3")]
    public const int BOUNDS_PARTIAL = 3;
}
