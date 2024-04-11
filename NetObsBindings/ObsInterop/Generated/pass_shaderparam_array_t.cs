using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace ObsInterop;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct pass_shaderparam_array_t
{
    [FieldOffset(0)]
    [NativeTypeName("struct darray")]
    public darray da;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_effect_L28_C9")]
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
