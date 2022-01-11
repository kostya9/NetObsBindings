namespace ObsInterop;

public unsafe partial struct obs_cmdline_args
{
    public int argc;

    [NativeTypeName("char **")]
    public sbyte** argv;
}
