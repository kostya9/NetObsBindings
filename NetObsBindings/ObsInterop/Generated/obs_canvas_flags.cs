namespace ObsInterop;

public enum obs_canvas_flags
{
    MAIN = 1 << 0,
    ACTIVATE = 1 << 1,
    MIX_AUDIO = 1 << 2,
    SCENE_REF = 1 << 3,
    EPHEMERAL = 1 << 4,
    PROGRAM = ACTIVATE | MIX_AUDIO | SCENE_REF,
    PREVIEW = EPHEMERAL,
    DEVICE = ACTIVATE | EPHEMERAL,
}
