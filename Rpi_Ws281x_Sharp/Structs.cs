/*
 * Structs.cs
 *
 * Copyright (c) 2017 Dean Fuqua <alvahdean @ gmail.com>
 *
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification, are permitted
 * provided that the following conditions are met:
 *
 *     1.  Redistributions of source code must retain the above copyright notice, this list of
 *         conditions and the following disclaimer.
 *     2.  Redistributions in binary form must reproduce the above copyright notice, this list
 *         of conditions and the following disclaimer in the documentation and/or other materials
 *         provided with the distribution.
 *     3.  Neither the name of the owner nor the names of its contributors may be used to endorse
 *         or promote products derived from this software without specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR
 * IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
 * FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER BE
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA,
 * OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT
 * OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 */


namespace RpiWs281xSharp
{
    using System;
    using System.Runtime.InteropServices;


    #region Clk
    [StructLayout(LayoutKind.Explicit)]
    public struct cm_clk_t
    {
        [FieldOffset(0)]
        UInt32 ctl;
        [FieldOffset(4)]
        UInt32 div;
    };
    //__attribute__((packed, aligned(4))) ;

    #endregion

    #region DMA

    [StructLayout(LayoutKind.Explicit)]
    public struct dma_cb_t
    {
        [FieldOffset(0)]
        public UInt32 ti;
        [FieldOffset(4)]
        public UInt32 source_ad;
        [FieldOffset(8)]
        public UInt32 dest_ad;
        [FieldOffset(12)]
        public UInt32 txfr_len;
        [FieldOffset(16)]
        public UInt32 stride;
        [FieldOffset(20)]
        public UInt32 nextconbk;
        [FieldOffset(24)]
        public UInt32[] resvd_0x18;
        [FieldOffset(24)]
        private UInt32 resvd_0x18_1;
        [FieldOffset(28)]
        private UInt32 resvd_0x18_2;
    };   //__attribute__((packed, aligned(4))) ;

    /*
	 * DMA register set
	 */
    [StructLayout(LayoutKind.Explicit)]
    public struct dma_t
    {
        [FieldOffset(0)]
        UInt32 cs;
        [FieldOffset(4)]
        UInt32 conblk_ad;
        [FieldOffset(8)]
        UInt32 ti;
        [FieldOffset(12)]
        UInt32 source_ad;
        [FieldOffset(16)]
        UInt32 dest_ad;
        [FieldOffset(20)]
        UInt32 txfr_len;
        [FieldOffset(24)]
        UInt32 stride;
        [FieldOffset(28)]
        UInt32 nextconbk;
        [FieldOffset(32)]
        UInt32 debug;
    };      //__attribute__((packed, aligned(4))) ;
    #endregion

    #region Gpio
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct gpio_t
    {
        [FieldOffset(0)]
        fixed UInt32 fsel[6];                            // GPIO Function Select
        [FieldOffset(24)]
        UInt32 resvd_0x18;
        [FieldOffset(28)]
        fixed UInt32 set[2];                             // GPIO Pin Output Set
        [FieldOffset(36)]
        UInt32 resvd_0x24;
        [FieldOffset(40)]
        fixed UInt32 clr[2];                             // GPIO Pin Output Clear
        [FieldOffset(48)]
        UInt32 resvd_0x30;
        [FieldOffset(52)]
        fixed UInt32 lev[2];                             // GPIO Pin Level
        [FieldOffset(60)]
        UInt32 resvd_0x3c;
        [FieldOffset(64)]
        fixed UInt32 eds[2];                             // GPIO Pin Event Detect Status
        [FieldOffset(72)]
        UInt32 resvd_0x48;
        [FieldOffset(76)]
        fixed UInt32 ren[2];                             // GPIO Pin Rising Edge Detect Enable
        [FieldOffset(84)]
        UInt32 resvd_0x54;
        [FieldOffset(88)]
        fixed UInt32 fen[2];                             // GPIO Pin Falling Edge Detect Enable
        [FieldOffset(96)]
        UInt32 resvd_0x60;
        [FieldOffset(100)]
        fixed UInt32 hen[2];                             // GPIO Pin High Detect Enable
        [FieldOffset(108)]
        UInt32 resvd_0x6c;
        [FieldOffset(112)]
        fixed UInt32 len[2];                             // GPIO Pin Low Detect Enable
        [FieldOffset(120)]
        UInt32 resvd_0x78;
        [FieldOffset(124)]
        fixed UInt32 aren[2];                            // GPIO Pin Async Rising Edge Detect
        [FieldOffset(132)]
        UInt32 resvd_0x84;
        [FieldOffset(136)]
        fixed UInt32 afen[2];                            // GPIO Pin Async Falling Edge Detect
        [FieldOffset(142)]
        UInt32 resvd_0x90;
        [FieldOffset(146)]
        UInt32 pud;                                // GPIO Pin Pull up/down Enable
        [FieldOffset(150)]
        fixed UInt32 pudclk[2];                          // GPIO Pin Pull up/down Enable Clock
        [FieldOffset(158)]
        fixed UInt32 resvd_0xa0[4];
        [FieldOffset(174)]
        UInt32 test;
    }                                  //__attribute__((packed, aligned(4))) 
    #endregion

    #region
    #endregion

    #region
    #endregion

    #region
    #endregion


    #region Pcm
    #endregion

    #region Pwm
    /*
    * Pin mappint of alternate pin configuration for PWM
    *
    * GPIO    ALT PWM0   ALT PWM1
    *
    *  12        0
    *  13                   0
    *  18        5
    *  19                   5
    *  40        0
    *  41                   0
    *  45                   0
    *  52        1
    *  53                   1
    *
    */

    public struct pwm_t
    {

        UInt32 ctl;

        UInt32 sta;

        UInt32 dmac;

        UInt32 resvd_0x0c;
        UInt32 rng1;
        UInt32 dat1;
        UInt32 fif1;
        UInt32 resvd_0x1c;
        UInt32 rng2;
        UInt32 dat2;
    }
    //__attribute__((packed, aligned(4))) ;







    [StructLayout(LayoutKind.Explicit)]
    public struct pcm_t
    {
        [FieldOffset(0)]
        UInt32 cs;

        [FieldOffset(4)]
        UInt32 fifo;

        [FieldOffset(8)]
        UInt32 mode;

        [FieldOffset(12)]
        UInt32 rxc;

        [FieldOffset(16)]
        UInt32 txc;

        [FieldOffset(24)]
        UInt32 dreq;

        [FieldOffset(28)]
        UInt32 inten;

        [FieldOffset(32)]
        UInt32 intstc;

        [FieldOffset(38)]
        UInt32 gray;
    }
    //__attribute__((packed, aligned(4))) ;



    public struct pcm_pin_table_t
    {
        int pinnum;
        int altnum;
    }

    //TODO: Does this work? 
    //  1. Converting pcm_pin_table_t* to pcm_pin_table_t[]
    //  2. Removing const modifier from fields
    public struct pcm_pin_tables_t
    {
        int count;
        pcm_pin_table_t[] pins;
    }
    public struct pwm_pin_table_t
    {
        int pinnum;
        int altnum;
    }
    //TODO: Does this work? 
    //  1. Converting pwm_pin_table_t* to pwm_pin_table_t[]
    //  2. Removing const modifier from fields
    public struct pwm_pin_tables_t
    {
        int count;
        pwm_pin_table_t[] pins;
    }


    #endregion

    #region RpiHw

    public struct rpi_hw_t
    {
        UInt32 type;
        UInt32 hwver;
        UInt32 periph_base;
        UInt32 videocore_base;
        //TODO: Can you implicitly convert char* to char[]? or even string?
        char[] desc;
    }

    #endregion

    #region Ws2811


    //public UInt32 ws2811_led_t;                   //< 0xWWRRGGBB
    public struct ws2811_device { }
    public struct ws2811_channel_t
    {

        int gpionum;                                 //< GPIO Pin with PWM alternate function, 0 if unused
        int invert;                                  //< Invert output signal
        int count;                                   //< Number of LEDs, 0 if channel is unused
        int strip_type;                              //< Strip color layout -- one of WS2811_STRIP_xxx constants
        UInt32[] leds;                          //< LED buffers, allocated by driver based on count
        byte brightness;                          //< Brightness value between 0 and 255
        byte wshift;                              //< White shift value
        byte rshift;                              //< Red shift value
        byte gshift;                              //< Green shift value
        byte bshift;                              //< Blue shift value
        byte[] gamma;                              //< Gamma correction table
    }

    public struct ws2811_t
    {

        UInt64 render_wait_time;                //< time in µs before the next render can run
        ws2811_device device;                   //< Private data for driver use
        readonly rpi_hw_t[] rpi_hw;             //< RPI Hardware Information
        UInt32 freq;                            //< Required output frequency
        int dmanum;                             //< DMA number _not_ already in use
        ws2811_channel_t[] channel;             //[RPI_PWM_CHANNELS];

    }
    #endregion
}
