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

    [NativeTypeName("union (anonymous union at ./obs-studio/libobs/graphics/effect.h:57:2)")]
    public _cur_val_e__Union cur_val;

    [NativeTypeName("union (anonymous union at ./obs-studio/libobs/graphics/effect.h:58:2)")]
    public _default_val_e__Union default_val;

    [NativeTypeName("gs_effect_t *")]
    public gs_effect* effect;

    [NativeTypeName("gs_samplerstate_t *")]
    public gs_sampler_state* next_sampler;

    [NativeTypeName("union (anonymous union at ./obs-studio/libobs/graphics/effect.h:65:2)")]
    public _annotations_e__Union annotations;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _cur_val_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("gs_effect_param::(anonymous struct at ./obs-studio/libobs/graphics/effect.h:57:2)")]
        public _Anonymous_e__Struct Anonymous;

        public ref byte* array
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
        [NativeTypeName("gs_effect_param::(anonymous struct at ./obs-studio/libobs/graphics/effect.h:58:2)")]
        public _Anonymous_e__Struct Anonymous;

        public ref byte* array
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
        [NativeTypeName("gs_effect_param::(anonymous struct at ./obs-studio/libobs/graphics/effect.h:65:2)")]
        public _Anonymous_e__Struct Anonymous;

        public ref gs_effect_param* array
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
            [NativeTypeName("struct gs_effect_param *")]
            public gs_effect_param* array;

            [NativeTypeName("size_t")]
            public nuint num;

            [NativeTypeName("size_t")]
            public nuint capacity;
        }
    }
}
