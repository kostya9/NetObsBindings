using System.Diagnostics.CodeAnalysis;
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

    [NativeTypeName("__AnonymousRecord_effect_L133_C2")]
    public _passes_e__Union passes;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _passes_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_effect_L133_C2")]
        public _Anonymous_e__Struct Anonymous;

        [UnscopedRef]
        public ref gs_effect_pass* array
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
            [NativeTypeName("struct gs_effect_pass *")]
            public gs_effect_pass* array;

            [NativeTypeName("size_t")]
            public nuint num;

            [NativeTypeName("size_t")]
            public nuint capacity;
        }
    }
}
