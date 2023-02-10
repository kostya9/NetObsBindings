using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsVideoFrame
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?video_frame_init@@YAXPEAUvideo_frame@@W4video_format@@II@Z", ExactSpelling = true)]
    public static extern void video_frame_init([NativeTypeName("struct video_frame *")] video_frame* frame, [NativeTypeName("enum video_format")] video_format format, [NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height);

    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?video_frame_copy@@YAXPEAUvideo_frame@@PEBU1@W4video_format@@I@Z", ExactSpelling = true)]
    public static extern void video_frame_copy([NativeTypeName("struct video_frame *")] video_frame* dst, [NativeTypeName("const struct video_frame *")] video_frame* src, [NativeTypeName("enum video_format")] video_format format, [NativeTypeName("uint32_t")] uint height);
}
