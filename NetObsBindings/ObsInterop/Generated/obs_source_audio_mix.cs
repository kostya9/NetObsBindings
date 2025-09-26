using System.Runtime.CompilerServices;

namespace ObsInterop;

public partial struct obs_source_audio_mix
{
    [NativeTypeName("struct audio_output_data[6]")]
    public _output_e__FixedBuffer output;

    [InlineArray(6)]
    public partial struct _output_e__FixedBuffer
    {
        public audio_output_data e0;
    }
}
