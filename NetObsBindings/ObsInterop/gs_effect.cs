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

    [NativeTypeName("union (anonymous union at ./obs-studio/libobs/graphics/effect.h:155:2)")]
    public _params_e__Union @params;

    [NativeTypeName("union (anonymous union at ./obs-studio/libobs/graphics/effect.h:156:2)")]
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
    public unsafe partial struct _params_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("gs_effect::(anonymous struct at ./obs-studio/libobs/graphics/effect.h:155:2)")]
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

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _techniques_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("gs_effect::(anonymous struct at ./obs-studio/libobs/graphics/effect.h:156:2)")]
        public _Anonymous_e__Struct Anonymous;

        public ref gs_effect_technique* array
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
            [NativeTypeName("struct gs_effect_technique *")]
            public gs_effect_technique* array;

            [NativeTypeName("size_t")]
            public nuint num;

            [NativeTypeName("size_t")]
            public nuint capacity;
        }
    }
}
