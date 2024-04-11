namespace ObsInterop;

public enum gif_result
{
    GIF_WORKING = 1,
    GIF_OK = 0,
    GIF_INSUFFICIENT_FRAME_DATA = -1,
    GIF_FRAME_DATA_ERROR = -2,
    GIF_INSUFFICIENT_DATA = -3,
    GIF_DATA_ERROR = -4,
    GIF_INSUFFICIENT_MEMORY = -5,
    GIF_FRAME_NO_DISPLAY = -6,
    GIF_END_OF_FRAME = -7,
}
