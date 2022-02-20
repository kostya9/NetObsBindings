using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsGraphics
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_destroy([NativeTypeName("gs_shader_t *")] gs_shader* shader);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int gs_shader_get_num_params([NativeTypeName("const gs_shader_t *")] gs_shader* shader);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_sparam_t *")]
    public static extern gs_shader_param* gs_shader_get_param_by_idx([NativeTypeName("gs_shader_t *")] gs_shader* shader, [NativeTypeName("uint32_t")] uint param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_sparam_t *")]
    public static extern gs_shader_param* gs_shader_get_param_by_name([NativeTypeName("gs_shader_t *")] gs_shader* shader, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_sparam_t *")]
    public static extern gs_shader_param* gs_shader_get_viewproj_matrix([NativeTypeName("const gs_shader_t *")] gs_shader* shader);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_sparam_t *")]
    public static extern gs_shader_param* gs_shader_get_world_matrix([NativeTypeName("const gs_shader_t *")] gs_shader* shader);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_get_param_info([NativeTypeName("const gs_sparam_t *")] gs_shader_param* param0, [NativeTypeName("struct gs_shader_param_info *")] gs_shader_param_info* info);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_set_bool([NativeTypeName("gs_sparam_t *")] gs_shader_param* param0, [NativeTypeName("bool")] byte val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_set_float([NativeTypeName("gs_sparam_t *")] gs_shader_param* param0, float val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_set_int([NativeTypeName("gs_sparam_t *")] gs_shader_param* param0, int val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_set_matrix3([NativeTypeName("gs_sparam_t *")] gs_shader_param* param0, [NativeTypeName("const struct matrix3 *")] matrix3* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_set_matrix4([NativeTypeName("gs_sparam_t *")] gs_shader_param* param0, [NativeTypeName("const struct matrix4 *")] matrix4* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_set_vec2([NativeTypeName("gs_sparam_t *")] gs_shader_param* param0, [NativeTypeName("const struct vec2 *")] System.Numerics.Vector2* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_set_vec3([NativeTypeName("gs_sparam_t *")] gs_shader_param* param0, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_set_vec4([NativeTypeName("gs_sparam_t *")] gs_shader_param* param0, [NativeTypeName("const struct vec4 *")] System.Numerics.Vector4* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_set_texture([NativeTypeName("gs_sparam_t *")] gs_shader_param* param0, [NativeTypeName("gs_texture_t *")] void* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_set_val([NativeTypeName("gs_sparam_t *")] gs_shader_param* param0, [NativeTypeName("const void *")] void* val, [NativeTypeName("size_t")] nuint size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_set_default([NativeTypeName("gs_sparam_t *")] gs_shader_param* param0);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_shader_set_next_sampler([NativeTypeName("gs_sparam_t *")] gs_shader_param* param0, [NativeTypeName("gs_samplerstate_t *")] gs_sampler_state* sampler);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_destroy([NativeTypeName("gs_effect_t *")] void* effect);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_technique_t *")]
    public static extern gs_effect_technique* gs_effect_get_technique([NativeTypeName("const gs_effect_t *")] void* effect, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_technique_t *")]
    public static extern gs_effect_technique* gs_effect_get_current_technique([NativeTypeName("const gs_effect_t *")] void* effect);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint gs_technique_begin([NativeTypeName("gs_technique_t *")] gs_effect_technique* technique);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_technique_end([NativeTypeName("gs_technique_t *")] gs_effect_technique* technique);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_technique_begin_pass([NativeTypeName("gs_technique_t *")] gs_effect_technique* technique, [NativeTypeName("size_t")] nuint pass);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_technique_begin_pass_by_name([NativeTypeName("gs_technique_t *")] gs_effect_technique* technique, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_technique_end_pass([NativeTypeName("gs_technique_t *")] gs_effect_technique* technique);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_epass_t *")]
    public static extern gs_effect_pass* gs_technique_get_pass_by_idx([NativeTypeName("const gs_technique_t *")] gs_effect_technique* technique, [NativeTypeName("size_t")] nuint pass);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_epass_t *")]
    public static extern gs_effect_pass* gs_technique_get_pass_by_name([NativeTypeName("const gs_technique_t *")] gs_effect_technique* technique, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint gs_effect_get_num_params([NativeTypeName("const gs_effect_t *")] void* effect);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_eparam_t *")]
    public static extern gs_effect_param* gs_effect_get_param_by_idx([NativeTypeName("const gs_effect_t *")] void* effect, [NativeTypeName("size_t")] nuint param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_eparam_t *")]
    public static extern gs_effect_param* gs_effect_get_param_by_name([NativeTypeName("const gs_effect_t *")] void* effect, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint gs_param_get_num_annotations([NativeTypeName("const gs_eparam_t *")] gs_effect_param* param0);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_eparam_t *")]
    public static extern gs_effect_param* gs_param_get_annotation_by_idx([NativeTypeName("const gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("size_t")] nuint annotation);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_eparam_t *")]
    public static extern gs_effect_param* gs_param_get_annotation_by_name([NativeTypeName("const gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_effect_loop([NativeTypeName("gs_effect_t *")] void* effect, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_update_params([NativeTypeName("gs_effect_t *")] void* effect);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_eparam_t *")]
    public static extern gs_effect_param* gs_effect_get_viewproj_matrix([NativeTypeName("const gs_effect_t *")] void* effect);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_eparam_t *")]
    public static extern gs_effect_param* gs_effect_get_world_matrix([NativeTypeName("const gs_effect_t *")] void* effect);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_get_param_info([NativeTypeName("const gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("struct gs_effect_param_info *")] gs_effect_param_info* info);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_set_bool([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("bool")] byte val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_set_float([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, float val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_set_int([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, int val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_set_matrix4([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("const struct matrix4 *")] matrix4* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_set_vec2([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("const struct vec2 *")] System.Numerics.Vector2* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_set_vec3([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_set_vec4([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("const struct vec4 *")] System.Numerics.Vector4* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_set_texture([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("gs_texture_t *")] void* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_set_texture_srgb([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("gs_texture_t *")] void* val);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_set_val([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("const void *")] void* val, [NativeTypeName("size_t")] nuint size);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_set_default([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint gs_effect_get_val_size([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* gs_effect_get_val([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint gs_effect_get_default_val_size([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* gs_effect_get_default_val([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_set_next_sampler([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("gs_samplerstate_t *")] gs_sampler_state* sampler);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_effect_set_color([NativeTypeName("gs_eparam_t *")] gs_effect_param* param0, [NativeTypeName("uint32_t")] uint argb);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texrender_t *")]
    public static extern gs_texture_render* gs_texrender_create([NativeTypeName("enum gs_color_format")] gs_color_format format, [NativeTypeName("enum gs_zstencil_format")] gs_zstencil_format zsformat);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_texrender_destroy([NativeTypeName("gs_texrender_t *")] gs_texture_render* texrender);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_texrender_begin([NativeTypeName("gs_texrender_t *")] gs_texture_render* texrender, [NativeTypeName("uint32_t")] uint cx, [NativeTypeName("uint32_t")] uint cy);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_texrender_end([NativeTypeName("gs_texrender_t *")] gs_texture_render* texrender);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_texrender_reset([NativeTypeName("gs_texrender_t *")] gs_texture_render* texrender);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern void* gs_texrender_get_texture([NativeTypeName("const gs_texrender_t *")] gs_texture_render* texrender);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* gs_get_device_name();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int gs_get_device_type();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_enum_adapters([NativeTypeName("bool (*)(void *, const char *, uint32_t)")] delegate* unmanaged[Cdecl]<void*, sbyte*, uint, byte> callback, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int gs_create([NativeTypeName("graphics_t **")] graphics_subsystem** graphics, [NativeTypeName("const char *")] sbyte* module, [NativeTypeName("uint32_t")] uint adapter);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_destroy([NativeTypeName("graphics_t *")] graphics_subsystem* graphics);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_enter_context([NativeTypeName("graphics_t *")] graphics_subsystem* graphics);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_leave_context();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("graphics_t *")]
    public static extern graphics_subsystem* gs_get_context();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* gs_get_device_obj();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_push();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_pop();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_identity();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_transpose();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_set([NativeTypeName("const struct matrix4 *")] matrix4* matrix);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_get([NativeTypeName("struct matrix4 *")] matrix4* dst);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_mul([NativeTypeName("const struct matrix4 *")] matrix4* matrix);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_rotquat([NativeTypeName("const struct quat *")] quat* rot);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_rotaa([NativeTypeName("const struct axisang *")] axisang* rot);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_translate([NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* pos);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_scale([NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* scale);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_rotaa4f(float x, float y, float z, float angle);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_translate3f(float x, float y, float z);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_matrix_scale3f(float x, float y, float z);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_render_start([NativeTypeName("bool")] byte b_new);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_render_stop([NativeTypeName("enum gs_draw_mode")] gs_draw_mode mode);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_vertbuffer_t *")]
    public static extern gs_vertex_buffer* gs_render_save();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_vertex2f(float x, float y);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_vertex3f(float x, float y, float z);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_normal3f(float x, float y, float z);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_color([NativeTypeName("uint32_t")] uint color);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_texcoord(float x, float y, int unit);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_vertex2v([NativeTypeName("const struct vec2 *")] System.Numerics.Vector2* v);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_vertex3v([NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_normal3v([NativeTypeName("const struct vec3 *")] System.Numerics.Vector3* v);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_color4v([NativeTypeName("const struct vec4 *")] System.Numerics.Vector4* v);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_texcoord2v([NativeTypeName("const struct vec2 *")] System.Numerics.Vector2* v, int unit);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("input_t *")]
    public static extern void* gs_get_input();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_effect_t *")]
    public static extern void* gs_get_effect();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_effect_t *")]
    public static extern void* gs_effect_create_from_file([NativeTypeName("const char *")] sbyte* file, [NativeTypeName("char **")] sbyte** error_string);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_effect_t *")]
    public static extern void* gs_effect_create([NativeTypeName("const char *")] sbyte* effect_string, [NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("char **")] sbyte** error_string);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_shader_t *")]
    public static extern gs_shader* gs_vertexshader_create_from_file([NativeTypeName("const char *")] sbyte* file, [NativeTypeName("char **")] sbyte** error_string);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_shader_t *")]
    public static extern gs_shader* gs_pixelshader_create_from_file([NativeTypeName("const char *")] sbyte* file, [NativeTypeName("char **")] sbyte** error_string);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern void* gs_texture_create_from_file([NativeTypeName("const char *")] sbyte* file);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* gs_create_texture_file_data([NativeTypeName("const char *")] sbyte* file, [NativeTypeName("enum gs_color_format *")] gs_color_format* format, [NativeTypeName("uint32_t *")] uint* cx, [NativeTypeName("uint32_t *")] uint* cy);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* gs_create_texture_file_data2([NativeTypeName("const char *")] sbyte* file, [NativeTypeName("enum gs_image_alpha_mode")] gs_image_alpha_mode alpha_mode, [NativeTypeName("enum gs_color_format *")] gs_color_format* format, [NativeTypeName("uint32_t *")] uint* cx, [NativeTypeName("uint32_t *")] uint* cy);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_draw_sprite([NativeTypeName("gs_texture_t *")] void* tex, [NativeTypeName("uint32_t")] uint flip, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_draw_sprite_subregion([NativeTypeName("gs_texture_t *")] void* tex, [NativeTypeName("uint32_t")] uint flip, [NativeTypeName("uint32_t")] uint x, [NativeTypeName("uint32_t")] uint y, [NativeTypeName("uint32_t")] uint cx, [NativeTypeName("uint32_t")] uint cy);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_draw_cube_backdrop([NativeTypeName("gs_texture_t *")] void* cubetex, [NativeTypeName("const struct quat *")] quat* rot, float left, float right, float top, float bottom, float znear);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_reset_viewport();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_set_2d_mode();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_set_3d_mode(double fovy, double znear, double zvar);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_viewport_push();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_viewport_pop();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_texture_set_image([NativeTypeName("gs_texture_t *")] void* tex, [NativeTypeName("const uint8_t *")] byte* data, [NativeTypeName("uint32_t")] uint linesize, [NativeTypeName("bool")] byte invert);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_cubetexture_set_image([NativeTypeName("gs_texture_t *")] void* cubetex, [NativeTypeName("uint32_t")] uint side, [NativeTypeName("const void *")] void* data, [NativeTypeName("uint32_t")] uint linesize, [NativeTypeName("bool")] byte invert);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_perspective(float fovy, float aspect, float znear, float zfar);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_blend_state_push();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_blend_state_pop();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_reset_blend_state();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_swapchain_t *")]
    public static extern gs_swap_chain* gs_swapchain_create([NativeTypeName("const struct gs_init_data *")] gs_init_data* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_resize([NativeTypeName("uint32_t")] uint x, [NativeTypeName("uint32_t")] uint y);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_get_size([NativeTypeName("uint32_t *")] uint* x, [NativeTypeName("uint32_t *")] uint* y);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint gs_get_width();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint gs_get_height();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern void* gs_texture_create([NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("enum gs_color_format")] gs_color_format color_format, [NativeTypeName("uint32_t")] uint levels, [NativeTypeName("const uint8_t **")] byte** data, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern void* gs_cubetexture_create([NativeTypeName("uint32_t")] uint size, [NativeTypeName("enum gs_color_format")] gs_color_format color_format, [NativeTypeName("uint32_t")] uint levels, [NativeTypeName("const uint8_t **")] byte** data, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern void* gs_voltexture_create([NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth, [NativeTypeName("enum gs_color_format")] gs_color_format color_format, [NativeTypeName("uint32_t")] uint levels, [NativeTypeName("const uint8_t **")] byte** data, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_zstencil_t *")]
    public static extern gs_zstencil_buffer* gs_zstencil_create([NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("enum gs_zstencil_format")] gs_zstencil_format format);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_stagesurf_t *")]
    public static extern gs_stage_surface* gs_stagesurface_create([NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("enum gs_color_format")] gs_color_format color_format);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_samplerstate_t *")]
    public static extern gs_sampler_state* gs_samplerstate_create([NativeTypeName("const struct gs_sampler_info *")] gs_sampler_info* info);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_shader_t *")]
    public static extern gs_shader* gs_vertexshader_create([NativeTypeName("const char *")] sbyte* shader, [NativeTypeName("const char *")] sbyte* file, [NativeTypeName("char **")] sbyte** error_string);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_shader_t *")]
    public static extern gs_shader* gs_pixelshader_create([NativeTypeName("const char *")] sbyte* shader, [NativeTypeName("const char *")] sbyte* file, [NativeTypeName("char **")] sbyte** error_string);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_vertbuffer_t *")]
    public static extern gs_vertex_buffer* gs_vertexbuffer_create([NativeTypeName("struct gs_vb_data *")] gs_vb_data* data, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_indexbuffer_t *")]
    public static extern gs_index_buffer* gs_indexbuffer_create([NativeTypeName("enum gs_index_type")] gs_index_type type, void* indices, [NativeTypeName("size_t")] nuint num, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_timer_t *")]
    public static extern gs_timer* gs_timer_create();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_timer_range_t *")]
    public static extern gs_timer_range* gs_timer_range_create();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum gs_texture_type")]
    public static extern gs_texture_type gs_get_texture_type([NativeTypeName("const gs_texture_t *")] void* texture);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_load_vertexbuffer([NativeTypeName("gs_vertbuffer_t *")] gs_vertex_buffer* vertbuffer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_load_indexbuffer([NativeTypeName("gs_indexbuffer_t *")] gs_index_buffer* indexbuffer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_load_texture([NativeTypeName("gs_texture_t *")] void* tex, int unit);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_load_samplerstate([NativeTypeName("gs_samplerstate_t *")] gs_sampler_state* samplerstate, int unit);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_load_vertexshader([NativeTypeName("gs_shader_t *")] gs_shader* vertshader);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_load_pixelshader([NativeTypeName("gs_shader_t *")] gs_shader* pixelshader);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_load_default_samplerstate([NativeTypeName("bool")] byte b_3d, int unit);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_shader_t *")]
    public static extern gs_shader* gs_get_vertex_shader();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_shader_t *")]
    public static extern gs_shader* gs_get_pixel_shader();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern void* gs_get_render_target();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_zstencil_t *")]
    public static extern gs_zstencil_buffer* gs_get_zstencil_target();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_set_render_target([NativeTypeName("gs_texture_t *")] void* tex, [NativeTypeName("gs_zstencil_t *")] gs_zstencil_buffer* zstencil);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_set_cube_render_target([NativeTypeName("gs_texture_t *")] void* cubetex, int side, [NativeTypeName("gs_zstencil_t *")] gs_zstencil_buffer* zstencil);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_enable_framebuffer_srgb([NativeTypeName("bool")] byte enable);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_framebuffer_srgb_enabled();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_get_linear_srgb();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_set_linear_srgb([NativeTypeName("bool")] byte linear_srgb);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_copy_texture([NativeTypeName("gs_texture_t *")] void* dst, [NativeTypeName("gs_texture_t *")] void* src);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_copy_texture_region([NativeTypeName("gs_texture_t *")] void* dst, [NativeTypeName("uint32_t")] uint dst_x, [NativeTypeName("uint32_t")] uint dst_y, [NativeTypeName("gs_texture_t *")] void* src, [NativeTypeName("uint32_t")] uint src_x, [NativeTypeName("uint32_t")] uint src_y, [NativeTypeName("uint32_t")] uint src_w, [NativeTypeName("uint32_t")] uint src_h);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_stage_texture([NativeTypeName("gs_stagesurf_t *")] gs_stage_surface* dst, [NativeTypeName("gs_texture_t *")] void* src);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_begin_frame();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_begin_scene();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_draw([NativeTypeName("enum gs_draw_mode")] gs_draw_mode draw_mode, [NativeTypeName("uint32_t")] uint start_vert, [NativeTypeName("uint32_t")] uint num_verts);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_end_scene();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_load_swapchain([NativeTypeName("gs_swapchain_t *")] gs_swap_chain* swapchain);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_clear([NativeTypeName("uint32_t")] uint clear_flags, [NativeTypeName("const struct vec4 *")] System.Numerics.Vector4* color, float depth, [NativeTypeName("uint8_t")] byte stencil);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_present();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_flush();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_set_cull_mode([NativeTypeName("enum gs_cull_mode")] gs_cull_mode mode);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum gs_cull_mode")]
    public static extern gs_cull_mode gs_get_cull_mode();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_enable_blending([NativeTypeName("bool")] byte enable);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_enable_depth_test([NativeTypeName("bool")] byte enable);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_enable_stencil_test([NativeTypeName("bool")] byte enable);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_enable_stencil_write([NativeTypeName("bool")] byte enable);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_enable_color([NativeTypeName("bool")] byte red, [NativeTypeName("bool")] byte green, [NativeTypeName("bool")] byte blue, [NativeTypeName("bool")] byte alpha);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_blend_function([NativeTypeName("enum gs_blend_type")] gs_blend_type src, [NativeTypeName("enum gs_blend_type")] gs_blend_type dest);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_blend_function_separate([NativeTypeName("enum gs_blend_type")] gs_blend_type src_c, [NativeTypeName("enum gs_blend_type")] gs_blend_type dest_c, [NativeTypeName("enum gs_blend_type")] gs_blend_type src_a, [NativeTypeName("enum gs_blend_type")] gs_blend_type dest_a);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_blend_op([NativeTypeName("enum gs_blend_op_type")] gs_blend_op_type op);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_depth_function([NativeTypeName("enum gs_depth_test")] gs_depth_test test);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_stencil_function([NativeTypeName("enum gs_stencil_side")] gs_stencil_side side, [NativeTypeName("enum gs_depth_test")] gs_depth_test test);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_stencil_op([NativeTypeName("enum gs_stencil_side")] gs_stencil_side side, [NativeTypeName("enum gs_stencil_op_type")] gs_stencil_op_type fail, [NativeTypeName("enum gs_stencil_op_type")] gs_stencil_op_type zfail, [NativeTypeName("enum gs_stencil_op_type")] gs_stencil_op_type zpass);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_set_viewport(int x, int y, int width, int height);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_get_viewport([NativeTypeName("struct gs_rect *")] gs_rect* rect);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_set_scissor_rect([NativeTypeName("const struct gs_rect *")] gs_rect* rect);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_ortho(float left, float right, float top, float bottom, float znear, float zfar);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_frustum(float left, float right, float top, float bottom, float znear, float zfar);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_projection_push();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_projection_pop();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_swapchain_destroy([NativeTypeName("gs_swapchain_t *")] gs_swap_chain* swapchain);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_texture_destroy([NativeTypeName("gs_texture_t *")] void* tex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint gs_texture_get_width([NativeTypeName("const gs_texture_t *")] void* tex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint gs_texture_get_height([NativeTypeName("const gs_texture_t *")] void* tex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum gs_color_format")]
    public static extern gs_color_format gs_texture_get_color_format([NativeTypeName("const gs_texture_t *")] void* tex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_texture_map([NativeTypeName("gs_texture_t *")] void* tex, [NativeTypeName("uint8_t **")] byte** ptr, [NativeTypeName("uint32_t *")] uint* linesize);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_texture_unmap([NativeTypeName("gs_texture_t *")] void* tex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_texture_is_rect([NativeTypeName("const gs_texture_t *")] void* tex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* gs_texture_get_obj([NativeTypeName("gs_texture_t *")] void* tex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_cubetexture_destroy([NativeTypeName("gs_texture_t *")] void* cubetex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint gs_cubetexture_get_size([NativeTypeName("const gs_texture_t *")] void* cubetex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum gs_color_format")]
    public static extern gs_color_format gs_cubetexture_get_color_format([NativeTypeName("const gs_texture_t *")] void* cubetex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_voltexture_destroy([NativeTypeName("gs_texture_t *")] void* voltex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint gs_voltexture_get_width([NativeTypeName("const gs_texture_t *")] void* voltex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint gs_voltexture_get_height([NativeTypeName("const gs_texture_t *")] void* voltex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint gs_voltexture_get_depth([NativeTypeName("const gs_texture_t *")] void* voltex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum gs_color_format")]
    public static extern gs_color_format gs_voltexture_get_color_format([NativeTypeName("const gs_texture_t *")] void* voltex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_stagesurface_destroy([NativeTypeName("gs_stagesurf_t *")] gs_stage_surface* stagesurf);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint gs_stagesurface_get_width([NativeTypeName("const gs_stagesurf_t *")] gs_stage_surface* stagesurf);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint gs_stagesurface_get_height([NativeTypeName("const gs_stagesurf_t *")] gs_stage_surface* stagesurf);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum gs_color_format")]
    public static extern gs_color_format gs_stagesurface_get_color_format([NativeTypeName("const gs_stagesurf_t *")] gs_stage_surface* stagesurf);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_stagesurface_map([NativeTypeName("gs_stagesurf_t *")] gs_stage_surface* stagesurf, [NativeTypeName("uint8_t **")] byte** data, [NativeTypeName("uint32_t *")] uint* linesize);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_stagesurface_unmap([NativeTypeName("gs_stagesurf_t *")] gs_stage_surface* stagesurf);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_zstencil_destroy([NativeTypeName("gs_zstencil_t *")] gs_zstencil_buffer* zstencil);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_samplerstate_destroy([NativeTypeName("gs_samplerstate_t *")] gs_sampler_state* samplerstate);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_vertexbuffer_destroy([NativeTypeName("gs_vertbuffer_t *")] gs_vertex_buffer* vertbuffer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_vertexbuffer_flush([NativeTypeName("gs_vertbuffer_t *")] gs_vertex_buffer* vertbuffer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_vertexbuffer_flush_direct([NativeTypeName("gs_vertbuffer_t *")] gs_vertex_buffer* vertbuffer, [NativeTypeName("const struct gs_vb_data *")] gs_vb_data* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("struct gs_vb_data *")]
    public static extern gs_vb_data* gs_vertexbuffer_get_data([NativeTypeName("const gs_vertbuffer_t *")] gs_vertex_buffer* vertbuffer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_indexbuffer_destroy([NativeTypeName("gs_indexbuffer_t *")] gs_index_buffer* indexbuffer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_indexbuffer_flush([NativeTypeName("gs_indexbuffer_t *")] gs_index_buffer* indexbuffer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_indexbuffer_flush_direct([NativeTypeName("gs_indexbuffer_t *")] gs_index_buffer* indexbuffer, [NativeTypeName("const void *")] void* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* gs_indexbuffer_get_data([NativeTypeName("const gs_indexbuffer_t *")] gs_index_buffer* indexbuffer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint gs_indexbuffer_get_num_indices([NativeTypeName("const gs_indexbuffer_t *")] gs_index_buffer* indexbuffer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum gs_index_type")]
    public static extern gs_index_type gs_indexbuffer_get_type([NativeTypeName("const gs_indexbuffer_t *")] gs_index_buffer* indexbuffer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_timer_destroy([NativeTypeName("gs_timer_t *")] gs_timer* timer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_timer_begin([NativeTypeName("gs_timer_t *")] gs_timer* timer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_timer_end([NativeTypeName("gs_timer_t *")] gs_timer* timer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_timer_get_data([NativeTypeName("gs_timer_t *")] gs_timer* timer, [NativeTypeName("uint64_t *")] ulong* ticks);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_timer_range_destroy([NativeTypeName("gs_timer_range_t *")] gs_timer_range* timer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_timer_range_begin([NativeTypeName("gs_timer_range_t *")] gs_timer_range* range);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_timer_range_end([NativeTypeName("gs_timer_range_t *")] gs_timer_range* range);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_timer_range_get_data([NativeTypeName("gs_timer_range_t *")] gs_timer_range* range, bool* disjoint, [NativeTypeName("uint64_t *")] ulong* frequency);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_nv12_available();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_debug_marker_begin([NativeTypeName("const float [4]")] float* color, [NativeTypeName("const char *")] sbyte* markername);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_debug_marker_begin_format([NativeTypeName("const float [4]")] float* color, [NativeTypeName("const char *")] sbyte* format);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_debug_marker_end();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_gdi_texture_available();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_shared_texture_available();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_get_duplicator_monitor_info(int monitor_idx, [NativeTypeName("struct gs_monitor_info *")] gs_monitor_info* monitor_info);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int gs_duplicator_get_monitor_index(void* monitor);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_duplicator_t *")]
    public static extern gs_duplicator* gs_duplicator_create(int monitor_idx);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_duplicator_destroy([NativeTypeName("gs_duplicator_t *")] gs_duplicator* duplicator);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_duplicator_update_frame([NativeTypeName("gs_duplicator_t *")] gs_duplicator* duplicator);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern void* gs_duplicator_get_texture([NativeTypeName("gs_duplicator_t *")] gs_duplicator* duplicator);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint gs_get_adapter_count();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern void* gs_texture_create_gdi([NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* gs_texture_get_dc([NativeTypeName("gs_texture_t *")] void* gdi_tex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_texture_release_dc([NativeTypeName("gs_texture_t *")] void* gdi_tex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern void* gs_texture_open_shared([NativeTypeName("uint32_t")] uint handle);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern void* gs_texture_open_nt_shared([NativeTypeName("uint32_t")] uint handle);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint gs_texture_get_shared_handle([NativeTypeName("gs_texture_t *")] void* tex);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern void* gs_texture_wrap_obj(void* obj);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int gs_texture_acquire_sync([NativeTypeName("gs_texture_t *")] void* tex, [NativeTypeName("uint64_t")] ulong key, [NativeTypeName("uint32_t")] uint ms);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int gs_texture_release_sync([NativeTypeName("gs_texture_t *")] void* tex, [NativeTypeName("uint64_t")] ulong key);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte gs_texture_create_nv12([NativeTypeName("gs_texture_t **")] void** tex_y, [NativeTypeName("gs_texture_t **")] void** tex_uv, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_stagesurf_t *")]
    public static extern gs_stage_surface* gs_stagesurface_create_nv12([NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_register_loss_callbacks([NativeTypeName("const struct gs_device_loss *")] gs_device_loss* callbacks);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void gs_unregister_loss_callbacks(void* data);
}
