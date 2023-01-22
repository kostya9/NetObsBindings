using System.Runtime.InteropServices;

namespace ObsInterop;

public static unsafe partial class ObsInput
{
    [DllImport("obs", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int input_getbuttonstate([NativeTypeName("input_t *")] input_subsystem* input, [NativeTypeName("uint32_t")] uint button);

    [NativeTypeName("#define KBC_ESCAPE 0x0")]
    public const int KBC_ESCAPE = 0x0;

    [NativeTypeName("#define KBC_1 0x1")]
    public const int KBC_1 = 0x1;

    [NativeTypeName("#define KBC_2 0x2")]
    public const int KBC_2 = 0x2;

    [NativeTypeName("#define KBC_3 0x3")]
    public const int KBC_3 = 0x3;

    [NativeTypeName("#define KBC_4 0x4")]
    public const int KBC_4 = 0x4;

    [NativeTypeName("#define KBC_5 0x5")]
    public const int KBC_5 = 0x5;

    [NativeTypeName("#define KBC_6 0x6")]
    public const int KBC_6 = 0x6;

    [NativeTypeName("#define KBC_7 0x7")]
    public const int KBC_7 = 0x7;

    [NativeTypeName("#define KBC_8 0x8")]
    public const int KBC_8 = 0x8;

    [NativeTypeName("#define KBC_9 0x9")]
    public const int KBC_9 = 0x9;

    [NativeTypeName("#define KBC_0 0xA")]
    public const int KBC_0 = 0xA;

    [NativeTypeName("#define KBC_MINUS 0xB")]
    public const int KBC_MINUS = 0xB;

    [NativeTypeName("#define KBC_EQUALS 0xC")]
    public const int KBC_EQUALS = 0xC;

    [NativeTypeName("#define KBC_BACK 0xD")]
    public const int KBC_BACK = 0xD;

    [NativeTypeName("#define KBC_TAB 0xE")]
    public const int KBC_TAB = 0xE;

    [NativeTypeName("#define KBC_Q 0xF")]
    public const int KBC_Q = 0xF;

    [NativeTypeName("#define KBC_W 0x10")]
    public const int KBC_W = 0x10;

    [NativeTypeName("#define KBC_E 0x11")]
    public const int KBC_E = 0x11;

    [NativeTypeName("#define KBC_R 0x12")]
    public const int KBC_R = 0x12;

    [NativeTypeName("#define KBC_T 0x13")]
    public const int KBC_T = 0x13;

    [NativeTypeName("#define KBC_Y 0x14")]
    public const int KBC_Y = 0x14;

    [NativeTypeName("#define KBC_U 0x15")]
    public const int KBC_U = 0x15;

    [NativeTypeName("#define KBC_I 0x16")]
    public const int KBC_I = 0x16;

    [NativeTypeName("#define KBC_O 0x17")]
    public const int KBC_O = 0x17;

    [NativeTypeName("#define KBC_P 0x18")]
    public const int KBC_P = 0x18;

    [NativeTypeName("#define KBC_LBRACKET 0x19")]
    public const int KBC_LBRACKET = 0x19;

    [NativeTypeName("#define KBC_RBRACKET 0x1A")]
    public const int KBC_RBRACKET = 0x1A;

    [NativeTypeName("#define KBC_RETURN 0x1B")]
    public const int KBC_RETURN = 0x1B;

    [NativeTypeName("#define KBC_LCONTROL 0x1C")]
    public const int KBC_LCONTROL = 0x1C;

    [NativeTypeName("#define KBC_A 0x1D")]
    public const int KBC_A = 0x1D;

    [NativeTypeName("#define KBC_S 0x1E")]
    public const int KBC_S = 0x1E;

    [NativeTypeName("#define KBC_D 0x1F")]
    public const int KBC_D = 0x1F;

    [NativeTypeName("#define KBC_F 0x20")]
    public const int KBC_F = 0x20;

    [NativeTypeName("#define KBC_G 0x21")]
    public const int KBC_G = 0x21;

    [NativeTypeName("#define KBC_H 0x22")]
    public const int KBC_H = 0x22;

    [NativeTypeName("#define KBC_J 0x23")]
    public const int KBC_J = 0x23;

    [NativeTypeName("#define KBC_K 0x24")]
    public const int KBC_K = 0x24;

    [NativeTypeName("#define KBC_L 0x25")]
    public const int KBC_L = 0x25;

    [NativeTypeName("#define KBC_SEMICOLON 0x26")]
    public const int KBC_SEMICOLON = 0x26;

    [NativeTypeName("#define KBC_APOSTROPHE 0x27")]
    public const int KBC_APOSTROPHE = 0x27;

    [NativeTypeName("#define KBC_TILDE 0x28")]
    public const int KBC_TILDE = 0x28;

    [NativeTypeName("#define KBC_LSHIFT 0x29")]
    public const int KBC_LSHIFT = 0x29;

    [NativeTypeName("#define KBC_BACKSLASH 0x2A")]
    public const int KBC_BACKSLASH = 0x2A;

    [NativeTypeName("#define KBC_Z 0x2B")]
    public const int KBC_Z = 0x2B;

    [NativeTypeName("#define KBC_X 0x2C")]
    public const int KBC_X = 0x2C;

    [NativeTypeName("#define KBC_C 0x2D")]
    public const int KBC_C = 0x2D;

    [NativeTypeName("#define KBC_V 0x2E")]
    public const int KBC_V = 0x2E;

    [NativeTypeName("#define KBC_B 0x2F")]
    public const int KBC_B = 0x2F;

    [NativeTypeName("#define KBC_N 0x30")]
    public const int KBC_N = 0x30;

    [NativeTypeName("#define KBC_M 0x31")]
    public const int KBC_M = 0x31;

    [NativeTypeName("#define KBC_COMMA 0x32")]
    public const int KBC_COMMA = 0x32;

    [NativeTypeName("#define KBC_PERIOD 0x33")]
    public const int KBC_PERIOD = 0x33;

    [NativeTypeName("#define KBC_SLASH 0x34")]
    public const int KBC_SLASH = 0x34;

    [NativeTypeName("#define KBC_RSHIFT 0x35")]
    public const int KBC_RSHIFT = 0x35;

    [NativeTypeName("#define KBC_MULTIPLY 0x36")]
    public const int KBC_MULTIPLY = 0x36;

    [NativeTypeName("#define KBC_LALT 0x37")]
    public const int KBC_LALT = 0x37;

    [NativeTypeName("#define KBC_SPACE 0x38")]
    public const int KBC_SPACE = 0x38;

    [NativeTypeName("#define KBC_CAPSLOCK 0x39")]
    public const int KBC_CAPSLOCK = 0x39;

    [NativeTypeName("#define KBC_F1 0x3A")]
    public const int KBC_F1 = 0x3A;

    [NativeTypeName("#define KBC_F2 0x3B")]
    public const int KBC_F2 = 0x3B;

    [NativeTypeName("#define KBC_F3 0x3C")]
    public const int KBC_F3 = 0x3C;

    [NativeTypeName("#define KBC_F4 0x3D")]
    public const int KBC_F4 = 0x3D;

    [NativeTypeName("#define KBC_F5 0x3E")]
    public const int KBC_F5 = 0x3E;

    [NativeTypeName("#define KBC_F6 0x3F")]
    public const int KBC_F6 = 0x3F;

    [NativeTypeName("#define KBC_F7 0x40")]
    public const int KBC_F7 = 0x40;

    [NativeTypeName("#define KBC_F8 0x41")]
    public const int KBC_F8 = 0x41;

    [NativeTypeName("#define KBC_F9 0x42")]
    public const int KBC_F9 = 0x42;

    [NativeTypeName("#define KBC_F10 0x43")]
    public const int KBC_F10 = 0x43;

    [NativeTypeName("#define KBC_NUMLOCK 0x44")]
    public const int KBC_NUMLOCK = 0x44;

    [NativeTypeName("#define KBC_SCROLLLOCK 0x45")]
    public const int KBC_SCROLLLOCK = 0x45;

    [NativeTypeName("#define KBC_NUMPAD7 0x46")]
    public const int KBC_NUMPAD7 = 0x46;

    [NativeTypeName("#define KBC_NUMPAD8 0x47")]
    public const int KBC_NUMPAD8 = 0x47;

    [NativeTypeName("#define KBC_NUMPAD9 0x48")]
    public const int KBC_NUMPAD9 = 0x48;

    [NativeTypeName("#define KBC_SUBTRACT 0x49")]
    public const int KBC_SUBTRACT = 0x49;

    [NativeTypeName("#define KBC_NUMPAD4 0x4A")]
    public const int KBC_NUMPAD4 = 0x4A;

    [NativeTypeName("#define KBC_NUMPAD5 0x4B")]
    public const int KBC_NUMPAD5 = 0x4B;

    [NativeTypeName("#define KBC_NUMPAD6 0x4C")]
    public const int KBC_NUMPAD6 = 0x4C;

    [NativeTypeName("#define KBC_ADD 0x4D")]
    public const int KBC_ADD = 0x4D;

    [NativeTypeName("#define KBC_NUMPAD1 0x4E")]
    public const int KBC_NUMPAD1 = 0x4E;

    [NativeTypeName("#define KBC_NUMPAD2 0x4F")]
    public const int KBC_NUMPAD2 = 0x4F;

    [NativeTypeName("#define KBC_NUMPAD3 0x50")]
    public const int KBC_NUMPAD3 = 0x50;

    [NativeTypeName("#define KBC_NUMPAD0 0x51")]
    public const int KBC_NUMPAD0 = 0x51;

    [NativeTypeName("#define KBC_DECIMAL 0x52")]
    public const int KBC_DECIMAL = 0x52;

    [NativeTypeName("#define KBC_F11 0x53")]
    public const int KBC_F11 = 0x53;

    [NativeTypeName("#define KBC_F12 0x54")]
    public const int KBC_F12 = 0x54;

    [NativeTypeName("#define KBC_NUMPADENTER 0x55")]
    public const int KBC_NUMPADENTER = 0x55;

    [NativeTypeName("#define KBC_RCONTROL 0x56")]
    public const int KBC_RCONTROL = 0x56;

    [NativeTypeName("#define KBC_DIVIDE 0x57")]
    public const int KBC_DIVIDE = 0x57;

    [NativeTypeName("#define KBC_SYSRQ 0x58")]
    public const int KBC_SYSRQ = 0x58;

    [NativeTypeName("#define KBC_RALT 0x59")]
    public const int KBC_RALT = 0x59;

    [NativeTypeName("#define KBC_PAUSE 0x5A")]
    public const int KBC_PAUSE = 0x5A;

    [NativeTypeName("#define KBC_HOME 0x5B")]
    public const int KBC_HOME = 0x5B;

    [NativeTypeName("#define KBC_UP 0x5C")]
    public const int KBC_UP = 0x5C;

    [NativeTypeName("#define KBC_PAGEDOWN 0x5D")]
    public const int KBC_PAGEDOWN = 0x5D;

    [NativeTypeName("#define KBC_LEFT 0x5E")]
    public const int KBC_LEFT = 0x5E;

    [NativeTypeName("#define KBC_RIGHT 0x5F")]
    public const int KBC_RIGHT = 0x5F;

    [NativeTypeName("#define KBC_END 0x60")]
    public const int KBC_END = 0x60;

    [NativeTypeName("#define KBC_DOWN 0x61")]
    public const int KBC_DOWN = 0x61;

    [NativeTypeName("#define KBC_PAGEUP 0x62")]
    public const int KBC_PAGEUP = 0x62;

    [NativeTypeName("#define KBC_INSERT 0x63")]
    public const int KBC_INSERT = 0x63;

    [NativeTypeName("#define KBC_DELETE 0x64")]
    public const int KBC_DELETE = 0x64;

    [NativeTypeName("#define MOUSE_LEFTBUTTON 0x65")]
    public const int MOUSE_LEFTBUTTON = 0x65;

    [NativeTypeName("#define MOUSE_MIDDLEBUTTON 0x66")]
    public const int MOUSE_MIDDLEBUTTON = 0x66;

    [NativeTypeName("#define MOUSE_RIGHTBUTTON 0x67")]
    public const int MOUSE_RIGHTBUTTON = 0x67;

    [NativeTypeName("#define MOUSE_WHEEL 0x68")]
    public const int MOUSE_WHEEL = 0x68;

    [NativeTypeName("#define MOUSE_MOVE 0x69")]
    public const int MOUSE_MOVE = 0x69;

    [NativeTypeName("#define KBC_CONTROL 0xFFFFFFFE")]
    public const uint KBC_CONTROL = 0xFFFFFFFE;

    [NativeTypeName("#define KBC_ALT 0xFFFFFFFD")]
    public const uint KBC_ALT = 0xFFFFFFFD;

    [NativeTypeName("#define KBC_SHIFT 0xFFFFFFFC")]
    public const uint KBC_SHIFT = 0xFFFFFFFC;

    [NativeTypeName("#define STATE_LBUTTONDOWN (1 << 0)")]
    public const int STATE_LBUTTONDOWN = (1 << 0);

    [NativeTypeName("#define STATE_RBUTTONDOWN (1 << 1)")]
    public const int STATE_RBUTTONDOWN = (1 << 1);

    [NativeTypeName("#define STATE_MBUTTONDOWN (1 << 2)")]
    public const int STATE_MBUTTONDOWN = (1 << 2);

    [NativeTypeName("#define STATE_X4BUTTONDOWN (1 << 3)")]
    public const int STATE_X4BUTTONDOWN = (1 << 3);

    [NativeTypeName("#define STATE_X5BUTTONDOWN (1 << 4)")]
    public const int STATE_X5BUTTONDOWN = (1 << 4);
}
