using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsEffect
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void effect_param_parse_property([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("const char *")] sbyte* property);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void effect_upload_params([NativeTypeName("gs_effect_t *")] gs_effect* effect, [NativeTypeName("bool")] byte changed_only);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void effect_upload_shader_params([NativeTypeName("gs_effect_t *")] gs_effect* effect, [NativeTypeName("gs_shader_t *")] gs_shader* shader, [NativeTypeName("struct darray *")] darray* pass_params, [NativeTypeName("bool")] byte changed_only);
}
