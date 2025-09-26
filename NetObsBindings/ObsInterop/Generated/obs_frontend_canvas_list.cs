using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace ObsInterop;

public partial struct obs_frontend_canvas_list
{
    [NativeTypeName("__AnonymousRecord_obs-frontend-api_L87_C2")]
    public _canvases_e__Union canvases;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _canvases_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct darray")]
        public darray da;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_obs-frontend-api_L87_C2")]
        public _Anonymous_e__Struct Anonymous;

        [UnscopedRef]
        public ref obs_canvas** array
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
            [NativeTypeName("obs_canvas_t **")]
            public obs_canvas** array;

            [NativeTypeName("size_t")]
            public nuint num;

            [NativeTypeName("size_t")]
            public nuint capacity;
        }
    }
}
