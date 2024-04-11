namespace ObsInterop;

public unsafe partial struct base_allocator
{
    [NativeTypeName("void *(*)(size_t)")]
    public delegate* unmanaged[Cdecl]<nuint, void*> malloc;

    [NativeTypeName("void *(*)(void *, size_t)")]
    public delegate* unmanaged[Cdecl]<void*, nuint, void*> realloc;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> free;
}
