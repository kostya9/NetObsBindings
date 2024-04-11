using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace ObsInterop;

public unsafe partial struct gs_effect
{
    [NativeTypeName("bool")]
    public byte processing;

    [NativeTypeName("bool")]
    public byte cached;

    [NativeTypeName("char *")]
    public sbyte* effect_path;

    [NativeTypeName("char *")]
    public sbyte* effect_dir;

    public gs_effect_param_array_t @params;

    [NativeTypeName("__AnonymousRecord_effect_L159_C2")]
    public _techniques_e__Union techniques;

    [NativeTypeName("struct gs_effect_technique *")]
    public gs_effect_technique* cur_technique;

    [NativeTypeName("struct gs_effect_pass *")]
    public gs_effect_pass* cur_pass;

    [NativeTypeName("gs_eparam_t *")]
    public gs_effect_param* view_proj;

    [NativeTypeName("gs_eparam_t *")]
    public gs_effect_param* world;

    [NativeTypeName("gs_eparam_t *")]
    public gs_effect_param* scale;

    [NativeTypeName("graphics_t *")]
    public graphics_subsystem* graphics;

    [NativeTypeName("struct gs_effect *")]
    public gs_effect* next;

    [NativeTypeName("size_t")]
    public nuint loop_pass;

    [NativeTypeName("bool")]
    public byte looping;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _techniques_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_effect_L159_C2")]
        public _Anonymous_e__Struct Anonymous;

        [UnscopedRef]
        public ref gs_effect_technique* array
        {
            get
            {
                return ref Anonymous.array;
            }
        }

        [UnscopedRef]
        public ref nuint num
        {
            get
            {
                return ref Anonymous.num;
            }
        }

        [UnscopedRef]
        public ref nuint capacity
        {
            get
            {
                return ref Anonymous.capacity;
            }
        }

        public unsafe partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("struct gs_effect_technique *")]
            public gs_effect_technique* array;

            [NativeTypeName("size_t")]
            public nuint num;

            [NativeTypeName("size_t")]
            public nuint capacity;
        }
    }
}
