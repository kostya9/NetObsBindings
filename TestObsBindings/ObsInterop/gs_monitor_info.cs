namespace ObsInterop;

public partial struct gs_monitor_info
{
    public int rotation_degrees;

    [NativeTypeName("long")]
    public int x;

    [NativeTypeName("long")]
    public int y;

    [NativeTypeName("long")]
    public int cx;

    [NativeTypeName("long")]
    public int cy;
}
