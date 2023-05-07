using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsOutput
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_register_output_s([NativeTypeName("const struct obs_output_info *")] obs_output_info* info, [NativeTypeName("size_t")] nuint size);

    [NativeTypeName("#define OBS_OUTPUT_VIDEO (1 << 0)")]
    public const int OBS_OUTPUT_VIDEO = (1 << 0);

    [NativeTypeName("#define OBS_OUTPUT_AUDIO (1 << 1)")]
    public const int OBS_OUTPUT_AUDIO = (1 << 1);

    [NativeTypeName("#define OBS_OUTPUT_AV (OBS_OUTPUT_VIDEO | OBS_OUTPUT_AUDIO)")]
    public const int OBS_OUTPUT_AV = ((1 << 0) | (1 << 1));

    [NativeTypeName("#define OBS_OUTPUT_ENCODED (1 << 2)")]
    public const int OBS_OUTPUT_ENCODED = (1 << 2);

    [NativeTypeName("#define OBS_OUTPUT_SERVICE (1 << 3)")]
    public const int OBS_OUTPUT_SERVICE = (1 << 3);

    [NativeTypeName("#define OBS_OUTPUT_MULTI_TRACK (1 << 4)")]
    public const int OBS_OUTPUT_MULTI_TRACK = (1 << 4);

    [NativeTypeName("#define OBS_OUTPUT_CAN_PAUSE (1 << 5)")]
    public const int OBS_OUTPUT_CAN_PAUSE = (1 << 5);

    [NativeTypeName("#define MAX_OUTPUT_AUDIO_ENCODERS 6")]
    public const int MAX_OUTPUT_AUDIO_ENCODERS = 6;
}
