using System;
using System.Runtime.InteropServices;

namespace ObsInterop;

public unsafe partial struct axisang
{
    [NativeTypeName("axisang::(anonymous union at ./obs-studio/libobs/graphics/axisang.h:29:2)")]
    public _Anonymous_e__Union Anonymous;

    public ref float x
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.x, 1));
        }
    }

    public ref float y
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.y, 1));
        }
    }

    public ref float z
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.z, 1));
        }
    }

    public ref float w
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.w, 1));
        }
    }

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
        [NativeTypeName("axisang::(anonymous struct at ./obs-studio/libobs/graphics/axisang.h:30:3)")]
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
