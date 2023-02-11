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

    [NativeTypeName("union (anonymous union at ./obs-studio/libobs/graphics/effect.h:104:2)")]
    public _vertshader_params_e__Union vertshader_params;

    [NativeTypeName("union (anonymous union at ./obs-studio/libobs/graphics/effect.h:105:2)")]
    public _pixelshader_params_e__Union pixelshader_params;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _vertshader_params_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("gs_effect_pass::(anonymous struct at ./obs-studio/libobs/graphics/effect.h:104:2)")]
        public _Anonymous_e__Struct Anonymous;

        public ref pass_shaderparam* array
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.array;
            }
        }

        public ref nuint num
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.num, 1));
            }
        }

        public ref nuint capacity
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.capacity, 1));
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
        [NativeTypeName("gs_effect_pass::(anonymous struct at ./obs-studio/libobs/graphics/effect.h:105:2)")]
        public _Anonymous_e__Struct Anonymous;

        public ref pass_shaderparam* array
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.array;
            }
        }

        public ref nuint num
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.num, 1));
            }
        }

        public ref nuint capacity
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.capacity, 1));
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
