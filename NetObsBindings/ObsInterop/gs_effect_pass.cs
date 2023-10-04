using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace ObsInterop;

public unsafe partial struct gs_effect_pass
{
    [NativeTypeName("char *")]
    public sbyte* name;

    [NativeTypeName("enum effect_section")]
    public effect_section section;

    [NativeTypeName("gs_shader_t *")]
    public gs_shader* vertshader;

    [NativeTypeName("gs_shader_t *")]
    public gs_shader* pixelshader;

    [NativeTypeName("__AnonymousRecord_effect_L104_C2")]
    public _vertshader_params_e__Union vertshader_params;

    [NativeTypeName("__AnonymousRecord_effect_L105_C2")]
    public _pixelshader_params_e__Union pixelshader_params;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _vertshader_params_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_effect_L104_C2")]
        public _Anonymous_e__Struct Anonymous;

        [UnscopedRef]
        public ref pass_shaderparam* array
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
            [NativeTypeName("struct pass_shaderparam *")]
            public pass_shaderparam* array;

            [NativeTypeName("size_t")]
            public nuint num;

            [NativeTypeName("size_t")]
            public nuint capacity;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _pixelshader_params_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_effect_L105_C2")]
        public _Anonymous_e__Struct Anonymous;

        [UnscopedRef]
        public ref pass_shaderparam* array
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
            [NativeTypeName("struct pass_shaderparam *")]
            public pass_shaderparam* array;

            [NativeTypeName("size_t")]
            public nuint num;

            [NativeTypeName("size_t")]
            public nuint capacity;
        }
    }
}
