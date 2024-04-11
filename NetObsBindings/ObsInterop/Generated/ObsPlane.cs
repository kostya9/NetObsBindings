using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsPlane
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void plane_from_tri([NativeTypeName("struct plane *")] plane* dst, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v1, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v2, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v3);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void plane_transform([NativeTypeName("struct plane *")] plane* dst, [NativeTypeName("const struct plane *")] plane* p, [NativeTypeName("const struct matrix4 *")] matrix4* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void plane_transform3x4([NativeTypeName("struct plane *")] plane* dst, [NativeTypeName("const struct plane *")] plane* p, [NativeTypeName("const struct matrix3 *")] matrix3* m);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte plane_intersection_ray([NativeTypeName("const struct plane *")] plane* p, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* orig, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* dir, float* t);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte plane_intersection_line([NativeTypeName("const struct plane *")] plane* p, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v1, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v2, float* t);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte plane_tri_inside([NativeTypeName("const struct plane *")] plane* p, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v1, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v2, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v3, float precision);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte plane_line_inside([NativeTypeName("const struct plane *")] plane* p, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v1, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v2, float precision);
}
