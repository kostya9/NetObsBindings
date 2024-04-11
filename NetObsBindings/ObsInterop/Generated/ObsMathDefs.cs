namespace ObsInterop;

public static partial class ObsMathDefs
{
    [NativeTypeName("#define M_PI 3.1415926535897932384626433832795f")]
    public const float M_PI = 3.1415926535897932384626433832795f;

    [NativeTypeName("#define LARGE_EPSILON 1e-2f")]
    public const float LARGE_EPSILON = 1e-2f;

    [NativeTypeName("#define EPSILON 1e-4f")]
    public const float EPSILON = 1e-4f;

    [NativeTypeName("#define TINY_EPSILON 1e-5f")]
    public const float TINY_EPSILON = 1e-5f;

    [NativeTypeName("#define M_INFINITE 3.4e38f")]
    public const float M_INFINITE = 3.4e38f;
}
