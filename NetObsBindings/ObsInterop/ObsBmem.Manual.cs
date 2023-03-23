using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsBmem
{
    /// <summary>
    /// Allocates a chunk of unmanaged OBS memory with size=<see cref="Marshal.SizeOf{T}()"/>
    /// </summary>
    public static T* bzalloc<T>()
        where T: unmanaged
    {
        var size = Marshal.SizeOf<T>();
        return (T*) bzalloc((nuint) size);
    }

    public static void* bzalloc(nuint size)
    {
        var mem = bmalloc(size);
        
        if (mem != null)
        {
            var span = new Span<byte>(mem, (int)size);
            span.Clear();
        }

        return mem;
    }

    public static sbyte* bstrdup_n(sbyte* str, nuint n)
    {
        if (str == null)
            return null;

        var dup = (sbyte *)bmemdup(str, n + 1);
        dup[n] = 0;

        return dup;
    }

    public static sbyte *bstrdup(sbyte *str)
    {
        if (str == null)
            return null;

        return bstrdup_n(str, strlen(str));
    }

    private static nuint strlen(sbyte* str)
    {
        sbyte *searchCharacter;

        for (searchCharacter = str; *searchCharacter != 0; ++searchCharacter) ;

        return (nuint) (searchCharacter - str);
    }
}