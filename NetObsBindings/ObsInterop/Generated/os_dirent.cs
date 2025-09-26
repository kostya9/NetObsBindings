using System.Runtime.CompilerServices;

namespace ObsInterop;

public partial struct os_dirent
{
    [NativeTypeName("char[256]")]
    public _d_name_e__FixedBuffer d_name;

    [NativeTypeName("bool")]
    public byte directory;

    [InlineArray(256)]
    public partial struct _d_name_e__FixedBuffer
    {
        public sbyte e0;
    }
}
