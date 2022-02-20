namespace ObsInterop;

public unsafe partial struct obs_sceneitem_order_info
{
    [NativeTypeName("obs_sceneitem_t *")]
    public obs_scene_item* group;

    [NativeTypeName("obs_sceneitem_t *")]
    public obs_scene_item* item;
}
