namespace ObsInterop;

public static unsafe partial class ObsBmem
{
    public static T* bzalloc<T>()
        where T: unmanaged
    {
        var size = sizeof(T);
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

    public static char* bstrdup_n(char* str, nuint n)
    {
        if (str == null)
            return null;

        var dup = (char *)bmemdup(str, n + 1);
        dup[n] = (char) 0;

        return dup;
    }

    public static char *bstrdup(char *str)
    {
        if (str == null)
            return null;

        return bstrdup_n(str, strlen(str));
    }

    private static nuint strlen(char* str)
    {
        var initialPtr = str;
        while (*(str++) != 0)
        {
        }

        return (nuint) (str - initialPtr);
    }
}