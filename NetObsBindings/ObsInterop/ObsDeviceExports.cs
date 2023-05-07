using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsDeviceExports
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* device_get_name();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int device_get_type();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte device_enum_adapters([NativeTypeName("bool (*)(void *, const char *, uint32_t)")] delegate* unmanaged[Cdecl]<void*, sbyte*, uint, byte> callback, void* param1);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* device_preprocessor_name();

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int device_create([NativeTypeName("gs_device_t **")] gs_device** device, [NativeTypeName("uint32_t")] uint adapter);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_destroy([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_enter_context([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_leave_context([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* device_get_device_obj([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_swapchain_t *")]
    public static extern gs_swap_chain* device_swapchain_create([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("const struct gs_init_data *")] gs_init_data* data);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_resize([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("uint32_t")] uint x, [NativeTypeName("uint32_t")] uint y);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum gs_color_space")]
    public static extern gs_color_space device_get_color_space([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_update_color_space([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_get_size([NativeTypeName("const gs_device_t *")] gs_device* device, [NativeTypeName("uint32_t *")] uint* x, [NativeTypeName("uint32_t *")] uint* y);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint device_get_width([NativeTypeName("const gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint device_get_height([NativeTypeName("const gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern gs_texture* device_texture_create([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("enum gs_color_format")] gs_color_format color_format, [NativeTypeName("uint32_t")] uint levels, [NativeTypeName("const uint8_t **")] byte** data, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern gs_texture* device_cubetexture_create([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("uint32_t")] uint size, [NativeTypeName("enum gs_color_format")] gs_color_format color_format, [NativeTypeName("uint32_t")] uint levels, [NativeTypeName("const uint8_t **")] byte** data, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern gs_texture* device_voltexture_create([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth, [NativeTypeName("enum gs_color_format")] gs_color_format color_format, [NativeTypeName("uint32_t")] uint levels, [NativeTypeName("const uint8_t *const *")] byte** data, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_zstencil_t *")]
    public static extern gs_zstencil_buffer* device_zstencil_create([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("enum gs_zstencil_format")] gs_zstencil_format format);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_stagesurf_t *")]
    public static extern gs_stage_surface* device_stagesurface_create([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("enum gs_color_format")] gs_color_format color_format);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_samplerstate_t *")]
    public static extern gs_sampler_state* device_samplerstate_create([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("const struct gs_sampler_info *")] gs_sampler_info* info);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_shader_t *")]
    public static extern gs_shader* device_vertexshader_create([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("const char *")] sbyte* shader, [NativeTypeName("const char *")] sbyte* file, [NativeTypeName("char **")] sbyte** error_string);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_shader_t *")]
    public static extern gs_shader* device_pixelshader_create([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("const char *")] sbyte* shader, [NativeTypeName("const char *")] sbyte* file, [NativeTypeName("char **")] sbyte** error_string);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_vertbuffer_t *")]
    public static extern gs_vertex_buffer* device_vertexbuffer_create([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("struct gs_vb_data *")] gs_vb_data* data, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_indexbuffer_t *")]
    public static extern gs_index_buffer* device_indexbuffer_create([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("enum gs_index_type")] gs_index_type type, void* indices, [NativeTypeName("size_t")] nuint num, [NativeTypeName("uint32_t")] uint flags);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_timer_t *")]
    public static extern gs_timer* device_timer_create([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_timer_range_t *")]
    public static extern gs_timer_range* device_timer_range_create([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum gs_texture_type")]
    public static extern gs_texture_type device_get_texture_type([NativeTypeName("const gs_texture_t *")] gs_texture* texture);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_load_vertexbuffer([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_vertbuffer_t *")] gs_vertex_buffer* vertbuffer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_load_indexbuffer([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_indexbuffer_t *")] gs_index_buffer* indexbuffer);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_load_texture([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_texture_t *")] gs_texture* tex, int unit);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_load_texture_srgb([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_texture_t *")] gs_texture* tex, int unit);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_load_samplerstate([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_samplerstate_t *")] gs_sampler_state* samplerstate, int unit);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_load_vertexshader([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_shader_t *")] gs_shader* vertshader);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_load_pixelshader([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_shader_t *")] gs_shader* pixelshader);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_load_default_samplerstate([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("bool")] byte b_3d, int unit);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_shader_t *")]
    public static extern gs_shader* device_get_vertex_shader([NativeTypeName("const gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_shader_t *")]
    public static extern gs_shader* device_get_pixel_shader([NativeTypeName("const gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_texture_t *")]
    public static extern gs_texture* device_get_render_target([NativeTypeName("const gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("gs_zstencil_t *")]
    public static extern gs_zstencil_buffer* device_get_zstencil_target([NativeTypeName("const gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_set_render_target([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_texture_t *")] gs_texture* tex, [NativeTypeName("gs_zstencil_t *")] gs_zstencil_buffer* zstencil);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_set_render_target_with_color_space([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_texture_t *")] gs_texture* tex, [NativeTypeName("gs_zstencil_t *")] gs_zstencil_buffer* zstencil, [NativeTypeName("enum gs_color_space")] gs_color_space space);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_set_cube_render_target([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_texture_t *")] gs_texture* cubetex, int side, [NativeTypeName("gs_zstencil_t *")] gs_zstencil_buffer* zstencil);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_enable_framebuffer_srgb([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("bool")] byte enable);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte device_framebuffer_srgb_enabled([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_copy_texture([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_texture_t *")] gs_texture* dst, [NativeTypeName("gs_texture_t *")] gs_texture* src);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_copy_texture_region([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_texture_t *")] gs_texture* dst, [NativeTypeName("uint32_t")] uint dst_x, [NativeTypeName("uint32_t")] uint dst_y, [NativeTypeName("gs_texture_t *")] gs_texture* src, [NativeTypeName("uint32_t")] uint src_x, [NativeTypeName("uint32_t")] uint src_y, [NativeTypeName("uint32_t")] uint src_w, [NativeTypeName("uint32_t")] uint src_h);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_stage_texture([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_stagesurf_t *")] gs_stage_surface* dst, [NativeTypeName("gs_texture_t *")] gs_texture* src);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_begin_frame([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_begin_scene([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_draw([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("enum gs_draw_mode")] gs_draw_mode draw_mode, [NativeTypeName("uint32_t")] uint start_vert, [NativeTypeName("uint32_t")] uint num_verts);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_end_scene([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_load_swapchain([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("gs_swapchain_t *")] gs_swap_chain* swapchain);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_clear([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("uint32_t")] uint clear_flags, [NativeTypeName("const struct vec4 *")] System.Numerics.Vector4* color, float depth, [NativeTypeName("uint8_t")] byte stencil);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte device_is_present_ready([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_present([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_flush([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_set_cull_mode([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("enum gs_cull_mode")] gs_cull_mode mode);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("enum gs_cull_mode")]
    public static extern gs_cull_mode device_get_cull_mode([NativeTypeName("const gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_enable_blending([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("bool")] byte enable);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_enable_depth_test([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("bool")] byte enable);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_enable_stencil_test([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("bool")] byte enable);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_enable_stencil_write([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("bool")] byte enable);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_enable_color([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("bool")] byte red, [NativeTypeName("bool")] byte green, [NativeTypeName("bool")] byte blue, [NativeTypeName("bool")] byte alpha);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_blend_function([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("enum gs_blend_type")] gs_blend_type src, [NativeTypeName("enum gs_blend_type")] gs_blend_type dest);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_blend_function_separate([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("enum gs_blend_type")] gs_blend_type src_c, [NativeTypeName("enum gs_blend_type")] gs_blend_type dest_c, [NativeTypeName("enum gs_blend_type")] gs_blend_type src_a, [NativeTypeName("enum gs_blend_type")] gs_blend_type dest_a);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_blend_op([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("enum gs_blend_op_type")] gs_blend_op_type op);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_depth_function([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("enum gs_depth_test")] gs_depth_test test);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_stencil_function([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("enum gs_stencil_side")] gs_stencil_side side, [NativeTypeName("enum gs_depth_test")] gs_depth_test test);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_stencil_op([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("enum gs_stencil_side")] gs_stencil_side side, [NativeTypeName("enum gs_stencil_op_type")] gs_stencil_op_type fail, [NativeTypeName("enum gs_stencil_op_type")] gs_stencil_op_type zfail, [NativeTypeName("enum gs_stencil_op_type")] gs_stencil_op_type zpass);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_set_viewport([NativeTypeName("gs_device_t *")] gs_device* device, int x, int y, int width, int height);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_get_viewport([NativeTypeName("const gs_device_t *")] gs_device* device, [NativeTypeName("struct gs_rect *")] gs_rect* rect);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_set_scissor_rect([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("const struct gs_rect *")] gs_rect* rect);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_ortho([NativeTypeName("gs_device_t *")] gs_device* device, float left, float right, float top, float bottom, float znear, float zfar);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_frustum([NativeTypeName("gs_device_t *")] gs_device* device, float left, float right, float top, float bottom, float znear, float zfar);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_projection_push([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_projection_pop([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_debug_marker_begin([NativeTypeName("gs_device_t *")] gs_device* device, [NativeTypeName("const char *")] sbyte* markername, [NativeTypeName("const float[4]")] float* color);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void device_debug_marker_end([NativeTypeName("gs_device_t *")] gs_device* device);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte device_is_monitor_hdr([NativeTypeName("gs_device_t *")] gs_device* device, void* monitor);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte device_shared_texture_available();
}
