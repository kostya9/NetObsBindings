using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace ObsInterop;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct profiler_time_entries_t
{
    [FieldOffset(0)]
    [NativeTypeName("struct darray")]
    public darray da;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_profiler_L64_C9")]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref profiler_time_entry* array
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
        [NativeTypeName("profiler_time_entry_t *")]
        public profiler_time_entry* array;

        [NativeTypeName("size_t")]
        public nuint num;

        [NativeTypeName("size_t")]
        public nuint capacity;
    }
}
