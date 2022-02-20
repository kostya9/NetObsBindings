using System;
using System.Runtime.InteropServices;

namespace ObsInterop;

public partial struct obs_source_audio_mix
{
    [NativeTypeName("struct audio_output_data [6]")]
    public _output_e__FixedBuffer output;

    public partial struct _output_e__FixedBuffer
    {
        public audio_output_data e0;
        public audio_output_data e1;
        public audio_output_data e2;
        public audio_output_data e3;
        public audio_output_data e4;
        public audio_output_data e5;

        public ref audio_output_data this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        public Span<audio_output_data> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 6);
    }
}
