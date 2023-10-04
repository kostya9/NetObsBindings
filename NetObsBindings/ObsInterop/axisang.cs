using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace ObsInterop;

public unsafe partial struct axisang
{
    [NativeTypeName("__AnonymousRecord_axisang_L29_C2")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref float x
    {
        get
        {
            return ref Anonymous.Anonymous.x;
        }
    }

    [UnscopedRef]
    public ref float y
    {
        get
        {
            return ref Anonymous.Anonymous.y;
        }
    }

    [UnscopedRef]
    public ref float z
    {
        get
        {
            return ref Anonymous.Anonymous.z;
        }
    }

    [UnscopedRef]
    public ref float w
    {
        get
        {
            return ref Anonymous.Anonymous.w;
        }
    }

    [UnscopedRef]
    public Span<float> ptr
    {
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.ptr[0], 4);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_axisang_L30_C3")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("float[4]")]
        public fixed float ptr[4];

        public partial struct _Anonymous_e__Struct
        {
            public float x;

            public float y;

            public float z;

            public float w;
        }
    }
}
