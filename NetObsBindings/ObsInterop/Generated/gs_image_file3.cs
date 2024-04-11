namespace ObsInterop;

public partial struct gs_image_file3
{
    [NativeTypeName("struct gs_image_file2")]
    public gs_image_file2 image2;

    [NativeTypeName("enum gs_image_alpha_mode")]
    public gs_image_alpha_mode alpha_mode;
}
