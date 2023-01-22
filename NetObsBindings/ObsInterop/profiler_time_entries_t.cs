using System.Runtime.InteropServices;

namespace ObsInterop;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct profiler_time_entries_t
{
    [FieldOffset(0)]
    [NativeTypeName("struct darray")]
    public darray da;

    [FieldOffset(0)]
    [NativeTypeName("profiler_time_entries_t::(anonymous struct at ./obs-studio/libobs/util/profiler.h:64:9)")]
    public _Anonymous_e__Struct Anonymous;

    public ref profiler_time_entry* array
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
        [NativeTypeName("profiler_time_entry_t *")]
        public profiler_time_entry* array;

        [NativeTypeName("size_t")]
        public nuint num;

        [NativeTypeName("size_t")]
        public nuint capacity;
    }
}
