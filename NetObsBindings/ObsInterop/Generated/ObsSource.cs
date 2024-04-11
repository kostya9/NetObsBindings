using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsSource
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void obs_register_source_s([NativeTypeName("const struct obs_source_info *")] obs_source_info* info, [NativeTypeName("size_t")] nuint size);

    [NativeTypeName("#define OBS_SOURCE_VIDEO (1 << 0)")]
    public const int OBS_SOURCE_VIDEO = (1 << 0);

    [NativeTypeName("#define OBS_SOURCE_AUDIO (1 << 1)")]
    public const int OBS_SOURCE_AUDIO = (1 << 1);

    [NativeTypeName("#define OBS_SOURCE_ASYNC (1 << 2)")]
    public const int OBS_SOURCE_ASYNC = (1 << 2);

    [NativeTypeName("#define OBS_SOURCE_ASYNC_VIDEO (OBS_SOURCE_ASYNC | OBS_SOURCE_VIDEO)")]
    public const int OBS_SOURCE_ASYNC_VIDEO = ((1 << 2) | (1 << 0));

    [NativeTypeName("#define OBS_SOURCE_CUSTOM_DRAW (1 << 3)")]
    public const int OBS_SOURCE_CUSTOM_DRAW = (1 << 3);

    [NativeTypeName("#define OBS_SOURCE_INTERACTION (1 << 5)")]
    public const int OBS_SOURCE_INTERACTION = (1 << 5);

    [NativeTypeName("#define OBS_SOURCE_COMPOSITE (1 << 6)")]
    public const int OBS_SOURCE_COMPOSITE = (1 << 6);

    [NativeTypeName("#define OBS_SOURCE_DO_NOT_DUPLICATE (1 << 7)")]
    public const int OBS_SOURCE_DO_NOT_DUPLICATE = (1 << 7);

    [NativeTypeName("#define OBS_SOURCE_DEPRECATED (1 << 8)")]
    public const int OBS_SOURCE_DEPRECATED = (1 << 8);

    [NativeTypeName("#define OBS_SOURCE_DO_NOT_SELF_MONITOR (1 << 9)")]
    public const int OBS_SOURCE_DO_NOT_SELF_MONITOR = (1 << 9);

    [NativeTypeName("#define OBS_SOURCE_CAP_DISABLED (1 << 10)")]
    public const int OBS_SOURCE_CAP_DISABLED = (1 << 10);

    [NativeTypeName("#define OBS_SOURCE_CAP_OBSOLETE OBS_SOURCE_CAP_DISABLED")]
    public const int OBS_SOURCE_CAP_OBSOLETE = (1 << 10);

    [NativeTypeName("#define OBS_SOURCE_MONITOR_BY_DEFAULT (1 << 11)")]
    public const int OBS_SOURCE_MONITOR_BY_DEFAULT = (1 << 11);

    [NativeTypeName("#define OBS_SOURCE_SUBMIX (1 << 12)")]
    public const int OBS_SOURCE_SUBMIX = (1 << 12);

    [NativeTypeName("#define OBS_SOURCE_CONTROLLABLE_MEDIA (1 << 13)")]
    public const int OBS_SOURCE_CONTROLLABLE_MEDIA = (1 << 13);

    [NativeTypeName("#define OBS_SOURCE_CEA_708 (1 << 14)")]
    public const int OBS_SOURCE_CEA_708 = (1 << 14);

    [NativeTypeName("#define OBS_SOURCE_SRGB (1 << 15)")]
    public const int OBS_SOURCE_SRGB = (1 << 15);

    [NativeTypeName("#define OBS_SOURCE_CAP_DONT_SHOW_PROPERTIES (1 << 16)")]
    public const int OBS_SOURCE_CAP_DONT_SHOW_PROPERTIES = (1 << 16);
}
