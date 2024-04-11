using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace ObsInterop;

public partial struct obs_frontend_source_list
{
    [NativeTypeName("__AnonymousRecord_obs-frontend-api_L72_C2")]
    public _sources_e__Union sources;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _sources_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_obs-frontend-api_L72_C2")]
        public _Anonymous_e__Struct Anonymous;

        [UnscopedRef]
        public ref obs_source** array
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
            [NativeTypeName("obs_source_t **")]
            public obs_source** array;

            [NativeTypeName("size_t")]
            public nuint num;

            [NativeTypeName("size_t")]
            public nuint capacity;
        }
    }
}
