namespace ObsInterop;

public enum obs_interaction_flags
{
    INTERACT_NONE = 0,
    INTERACT_CAPS_KEY = 1,
    INTERACT_SHIFT_KEY = 1 << 1,
    INTERACT_CONTROL_KEY = 1 << 2,
    INTERACT_ALT_KEY = 1 << 3,
    INTERACT_MOUSE_LEFT = 1 << 4,
    INTERACT_MOUSE_MIDDLE = 1 << 5,
    INTERACT_MOUSE_RIGHT = 1 << 6,
    INTERACT_COMMAND_KEY = 1 << 7,
    INTERACT_NUMLOCK_KEY = 1 << 8,
    INTERACT_IS_KEY_PAD = 1 << 9,
    INTERACT_IS_LEFT = 1 << 10,
    INTERACT_IS_RIGHT = 1 << 11,
}
