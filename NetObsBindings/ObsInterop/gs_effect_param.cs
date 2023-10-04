using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace ObsInterop;

public unsafe partial struct gs_effect_param
{
    [NativeTypeName("char *")]
    public sbyte* name;

    [NativeTypeName("enum effect_section")]
    public effect_section section;

    [NativeTypeName("enum gs_shader_param_type")]
    public gs_shader_param_type type;

    [NativeTypeName("bool")]
    public byte changed;

    [NativeTypeName("__AnonymousRecord_effect_L57_C2")]
    public _cur_val_e__Union cur_val;

    [NativeTypeName("__AnonymousRecord_effect_L58_C2")]
    public _default_val_e__Union default_val;

    [NativeTypeName("gs_effect_t *")]
    public gs_effect* effect;

    [NativeTypeName("gs_samplerstate_t *")]
    public gs_sampler_state* next_sampler;

    [NativeTypeName("__AnonymousRecord_effect_L65_C2")]
    public _annotations_e__Union annotations;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _cur_val_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_effect_L57_C2")]
        public _Anonymous_e__Struct Anonymous;

        [UnscopedRef]
        public ref byte* array
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
            [NativeTypeName("uint8_t *")]
            public byte* array;

            [NativeTypeName("size_t")]
            public nuint num;

            [NativeTypeName("size_t")]
            public nuint capacity;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _default_val_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_effect_L58_C2")]
        public _Anonymous_e__Struct Anonymous;

        [UnscopedRef]
        public ref byte* array
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
            [NativeTypeName("uint8_t *")]
            public byte* array;

            [NativeTypeName("size_t")]
            public nuint num;

            [NativeTypeName("size_t")]
            public nuint capacity;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _annotations_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_effect_L65_C2")]
        public _Anonymous_e__Struct Anonymous;

        [UnscopedRef]
        public ref gs_effect_param* array
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
            [NativeTypeName("struct gs_effect_param *")]
            public gs_effect_param* array;

            [NativeTypeName("size_t")]
            public nuint num;

            [NativeTypeName("size_t")]
            public nuint capacity;
        }
    }
}
