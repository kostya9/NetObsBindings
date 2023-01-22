using System.Runtime.InteropServices;

namespace ObsInterop;

public partial struct obs_frontend_source_list
{
    [NativeTypeName("union (anonymous union at ./obs-studio/UI/obs-frontend-api/obs-frontend-api.h:72:2)")]
    public _sources_e__Union sources;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _sources_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("obs_frontend_source_list::(anonymous struct at ./obs-studio/UI/obs-frontend-api/obs-frontend-api.h:72:2)")]
        public _Anonymous_e__Struct Anonymous;

        public ref obs_source** array
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
            [NativeTypeName("obs_source_t **")]
            public obs_source** array;

            [NativeTypeName("size_t")]
            public nuint num;

            [NativeTypeName("size_t")]
            public nuint capacity;
        }
    }
}
