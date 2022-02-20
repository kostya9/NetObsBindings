using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsEncoder
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_register_encoder_s([NativeTypeName("const struct obs_encoder_info *")] obs_encoder_info* info, [NativeTypeName("size_t")] nuint size);

    [NativeTypeName("#define OBS_ENCODER_CAP_DEPRECATED (1 << 0)")]
    public const int OBS_ENCODER_CAP_DEPRECATED = (1 << 0);

    [NativeTypeName("#define OBS_ENCODER_CAP_PASS_TEXTURE (1 << 1)")]
    public const int OBS_ENCODER_CAP_PASS_TEXTURE = (1 << 1);

    [NativeTypeName("#define OBS_ENCODER_CAP_DYN_BITRATE (1 << 2)")]
    public const int OBS_ENCODER_CAP_DYN_BITRATE = (1 << 2);

    [NativeTypeName("#define OBS_ENCODER_CAP_INTERNAL (1 << 3)")]
    public const int OBS_ENCODER_CAP_INTERNAL = (1 << 3);
}
