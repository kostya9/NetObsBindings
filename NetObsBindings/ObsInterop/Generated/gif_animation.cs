using System.Runtime.CompilerServices;

namespace ObsInterop;

public unsafe partial struct gif_animation
{
    public gif_bitmap_callback_vt bitmap_callbacks;

    [NativeTypeName("unsigned char *")]
    public byte* gif_data;

    [NativeTypeName("unsigned int")]
    public uint width;

    [NativeTypeName("unsigned int")]
    public uint height;

    [NativeTypeName("unsigned int")]
    public uint frame_count;

    [NativeTypeName("unsigned int")]
    public uint frame_count_partial;

    public gif_frame* frames;

    public int decoded_frame;

    public void* frame_image;

    public int loop_count;

    public gif_result current_error;

    [NativeTypeName("unsigned int")]
    public uint buffer_position;

    [NativeTypeName("unsigned int")]
    public uint buffer_size;

    [NativeTypeName("unsigned int")]
    public uint frame_holders;

    [NativeTypeName("unsigned int")]
    public uint background_index;

    [NativeTypeName("unsigned int")]
    public uint aspect_ratio;

    [NativeTypeName("unsigned int")]
    public uint colour_table_size;

    [NativeTypeName("bool")]
    public byte global_colours;

    [NativeTypeName("unsigned int *")]
    public uint* global_colour_table;

    [NativeTypeName("unsigned int *")]
    public uint* local_colour_table;

    [NativeTypeName("unsigned char[4]")]
    public _buf_e__FixedBuffer buf;

    [NativeTypeName("unsigned char *")]
    public byte* direct;

    [NativeTypeName("int[2][4096]")]
    public _table_e__FixedBuffer table;

    [NativeTypeName("unsigned char[8192]")]
    public _stack_e__FixedBuffer stack;

    [NativeTypeName("unsigned char *")]
    public byte* stack_pointer;

    public int code_size;

    public int set_code_size;

    public int max_code;

    public int max_code_size;

    public int clear_code;

    public int end_code;

    public int curbit;

    public int lastbit;

    public int last_byte;

    public int firstcode;

    public int oldcode;

    [NativeTypeName("bool")]
    public byte zero_data_block;

    [NativeTypeName("bool")]
    public byte get_done;

    [NativeTypeName("bool")]
    public byte clear_image;

    [InlineArray(4)]
    public partial struct _buf_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2 * 4096)]
    public partial struct _table_e__FixedBuffer
    {
        public int e0_0;
    }

    [InlineArray(8192)]
    public partial struct _stack_e__FixedBuffer
    {
        public byte e0;
    }
}
