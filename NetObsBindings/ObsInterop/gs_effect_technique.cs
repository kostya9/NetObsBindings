using System.Runtime.InteropServices;

namespace ObsInterop;

public unsafe partial struct gs_effect_technique
{
    [NativeTypeName("char *")]
    public sbyte* name;

    [NativeTypeName("enum effect_section")]
    public effect_section section;

    [NativeTypeName("struct gs_effect *")]
    public gs_effect* effect;

    [NativeTypeName("union (anonymous union at ./obs-studio/libobs/graphics/effect.h:130:2)")]
    public _passes_e__Union passes;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _passes_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("gs_effect_technique::(anonymous struct at ./obs-studio/libobs/graphics/effect.h:130:2)")]
        public _Anonymous_e__Struct Anonymous;

        public ref gs_effect_pass* array
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
            [NativeTypeName("struct gs_effect_pass *")]
            public gs_effect_pass* array;

            [NativeTypeName("size_t")]
            public nuint num;

            [NativeTypeName("size_t")]
            public nuint capacity;
        }
    }
}
