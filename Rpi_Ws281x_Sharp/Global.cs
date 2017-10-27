/*
 * Global.cs
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

    public static class Global
    {
        public const string RpiWs281XNativeLib = "librpi_ws281x.so";

        #region Clk
        public const UInt32 CM_CLK_CTL_PASSWD = (0x5a << 24);
        public const UInt32 CM_CLK_CTL_FLIP = (1 << 8);
        public const UInt32 CM_CLK_CTL_BUSY = (1 << 7);
        public const UInt32 CM_CLK_CTL_KILL = (1 << 5);
        public const UInt32 CM_CLK_CTL_ENAB = (1 << 4);
        public const UInt32 CM_CLK_CTL_SRC_GND = (0 << 0);
        public const UInt32 CM_CLK_CTL_SRC_OSC = (1 << 0);
        public const UInt32 CM_CLK_CTL_SRC_TSTDBG0 = (2 << 0);
        public const UInt32 CM_CLK_CTL_SRC_TSTDBG1 = (3 << 0);
        public const UInt32 CM_CLK_CTL_SRC_PLLA = (4 << 0);
        public const UInt32 CM_CLK_CTL_SRC_PLLC = (5 << 0);
        public const UInt32 CM_CLK_CTL_SRC_PLLD = (6 << 0);
        public const UInt32 CM_CLK_CTL_SRC_HDMIAUX = (7 << 0);
        public const UInt32 CM_CLK_DIV_PASSWD = (0x5a << 24);

        /*
         * PWM and PCM clock offsets from https://www.scribd.com/doc/127599939/BCM2835-Audio-clocks
         *
         */
        public const UInt32 CM_PCM_OFFSET = (0x00101098);
        public const UInt32 CM_PWM_OFFSET = (0x001010a0);

		#endregion

		#region DMA
		public const UInt32 RPI_DMA_CS_RESET = ((UInt32)1 << 31);
		public const UInt32 RPI_DMA_CS_ABORT = (1 << 30);
		public const UInt32 RPI_DMA_CS_DISDEBUG = (1 << 29);
		public const UInt32 RPI_DMA_CS_WAIT_OUTSTANDING_WRITES = ((UInt32)1 << 28);
		public const UInt32 RPI_DMA_CS_ERROR = (1 << 8);
		public const UInt32 RPI_DMA_CS_WAITING_OUTSTANDING_WRITES = (1 << 6);
		public const UInt32 RPI_DMA_CS_DREQ_STOPS_DMA = (1 << 5);
		public const UInt32 RPI_DMA_CS_PAUSED = (1 << 4);
		public const UInt32 RPI_DMA_CS_DREQ = (1 << 3);
		public const UInt32 RPI_DMA_CS_INT = (1 << 2);
		public const UInt32 RPI_DMA_CS_END = (1 << 1);
		public const UInt32 RPI_DMA_CS_ACTIVE = (1 << 0);
		public const UInt32 RPI_DMA_TI_NO_WIDE_BURSTS = (1 << 26);
		public const UInt32 RPI_DMA_TI_SRC_IGNORE = (1 << 11);
		public const UInt32 RPI_DMA_TI_SRC_DREQ = (1 << 10);
		public const UInt32 RPI_DMA_TI_SRC_WIDTH = (1 << 9);
		public const UInt32 RPI_DMA_TI_SRC_INC = (1 << 8);
		public const UInt32 RPI_DMA_TI_DEST_IGNORE = (1 << 7);
		public const UInt32 RPI_DMA_TI_DEST_DREQ = (1 << 6);
		public const UInt32 RPI_DMA_TI_DEST_WIDTH = (1 << 5);
		public const UInt32 RPI_DMA_TI_DEST_INC = (1 << 4);
		public const UInt32 RPI_DMA_TI_WAIT_RESP = (1 << 3);
		public const UInt32 RPI_DMA_TI_TDMODE = (1 << 1);
		public const UInt32 RPI_DMA_TI_INTEN = (1 << 0);

		public const UInt64 DMA0_OFFSET = (0x00007000);
		public const UInt64 DMA1_OFFSET = (0x00007100);
		public const UInt64 DMA2_OFFSET = (0x00007200);
		public const UInt64 DMA3_OFFSET = (0x00007300);
		public const UInt64 DMA4_OFFSET = (0x00007400);
		public const UInt64 DMA5_OFFSET = (0x00007500);
		public const UInt64 DMA6_OFFSET = (0x00007600);
		public const UInt64 DMA7_OFFSET = (0x00007700);
		public const UInt64 DMA8_OFFSET = (0x00007800);
		public const UInt64 DMA9_OFFSET = (0x00007900);
		public const UInt64 DMA10_OFFSET = (0x00007a00);
		public const UInt64 DMA11_OFFSET = (0x00007b00);
		public const UInt64 DMA12_OFFSET = (0x00007c00);
		public const UInt64 DMA13_OFFSET = (0x00007d00);
		public const UInt64 DMA14_OFFSET = (0x00007e00);
		public const UInt64 DMA15_OFFSET = (0x00e05000);

		//TODO: Verify bitsize of PAGESIZE
		public const UInt32 PAGE_SIZE = (1 << 12);
		public const UInt32 PAGE_MASK = (~(PAGE_SIZE - 1));

        public static UInt32 PAGE_OFFSET(UInt32 page){return page & (PAGE_SIZE - 1); }
		public static UInt32 RPI_DMA_CS_PANIC_PRIORITY(UInt32 val) { return (val & 0xf) << 20; }
        public static UInt32 RPI_DMA_CS_PRIORITY(UInt32 val){return (val & 0xf) << 16; }
        public static UInt32 RPI_DMA_TI_WAITS(UInt32 val){return (val & 0x1f) << 21; }
        public static UInt32 RPI_DMA_TI_PERMAP(UInt32 val) {return (val & 0x1f) << 16; }
        public static UInt32 RPI_DMA_TI_BURST_LENGTH(UInt32 val){return (val & 0xf) << 12; }
		public static UInt32 RPI_DMA_TXFR_LEN_YLENGTH(UInt32 val){return (val & 0xffff) << 16; }
        public static UInt32 RPI_DMA_TXFR_LEN_XLENGTH(UInt32 val){return (val & 0xffff) << 0; }
		public static UInt32 RPI_DMA_STRIDE_D_STRIDE(UInt32 val) { return (val & 0xffff) << 16; }
		public static UInt32 RPI_DMA_STRIDE_S_STRIDE(UInt32 val) { return (val & 0xffff) << 0; }

		#endregion

		#region RpiHw
		public const int RPI_HWVER_TYPE_UNKNOWN = 0;
		public const int RPI_HWVER_TYPE_PI1 = 1;
		public const int RPI_HWVER_TYPE_PI2 = 2;
		#endregion

		#region Pcm
		/*
*
* Pin mapping of alternate pin configuration for PCM
*
* GPIO   ALT PCM_CLK   ALT PCM-FS   ALT PCM_DIN   ALT PCM_DOUT
*
*  18        0             
*  19                      0
*  20                                   0
*  21                                                 0
*  28        2 
*  29                      2
*  30                                   2
*  31                                                 2
*
*/

		public const UInt32 RPI_PCM_CS_STBY = (1 << 25);
		public const UInt32 RPI_PCM_CS_SYNC = (1 << 24);
		public const UInt32 RPI_PCM_CS_RXSEX = (1 << 23);
		public const UInt32 RPI_PCM_CS_RXF = (1 << 22);
		public const UInt32 RPI_PCM_CS_TXE = (1 << 21);
		public const UInt32 RPI_PCM_CS_RXD = (1 << 20);
		public const UInt32 RPI_PCM_CS_TXD = (1 << 19);
		public const UInt32 RPI_PCM_CS_RXR = (1 << 18);
		public const UInt32 RPI_PCM_CS_TXW = (1 << 17);
		public const UInt32 RPI_PCM_CS_RXERR = (1 << 16);
		public const UInt32 RPI_PCM_CS_TXERR = (1 << 15);
		public const UInt32 RPI_PCM_CS_RXSYNC = (1 << 14);
		public const UInt32 RPI_PCM_CS_TXSYNC = (1 << 13);
		public const UInt32 RPI_PCM_CS_DMAEN = (1 << 9);

		public const UInt32 RPI_PCM_CS_RXCLR = (1 << 4);
		public const UInt32 RPI_PCM_CS_TXCLR = (1 << 3);
		public const UInt32 RPI_PCM_CS_TXON = (1 << 2);
		public const UInt32 RPI_PCM_CS_RXON = (1 << 1);
		public const UInt32 RPI_PCM_CS_EN = (1 << 0);
		public const UInt32 RPI_PCM_MODE_CLK_DIS = (1 << 28);
		public const UInt32 RPI_PCM_MODE_PDMN = (1 << 27);
		public const UInt32 RPI_PCM_MODE_PDME = (1 << 26);
		public const UInt32 RPI_PCM_MODE_FRXP = (1 << 25);
		public const UInt32 RPI_PCM_MODE_FTXP = (1 << 24);
		public const UInt32 RPI_PCM_MODE_CLKM = (1 << 23);
		public const UInt32 RPI_PCM_MODE_CLKI = (1 << 22);
		public const UInt32 RPI_PCM_MODE_FSM = (1 << 21);
		public const UInt32 RPI_PCM_MODE_FSI = (1 << 20);

		public const UInt32 RPI_PCM_RXC_CH1WEX = ((uint)1 << 31);
		public const UInt32 RPI_PCM_RXC_CH1EN = (1 << 30);

		public const UInt32 RPI_PCM_RXC_CH2WEX = (1 << 15);

		public const UInt32 RPI_PCM_RXC_CH2EN = (1 << 14);


		public const UInt32 RPI_PCM_TXC_CH1WEX = ((uint)1 << 31);
		public const UInt32 RPI_PCM_TXC_CH1EN = (1 << 30);

		public const UInt32 RPI_PCM_TXC_CH2WEX = (1 << 15);
		public const UInt32 RPI_PCM_TXC_CH2EN = (1 << 14);

		public const UInt32 RPI_PCM_INTEN_RXERR = (1 << 3);
		public const UInt32 RPI_PCM_INTEN_TXERR = (1 << 2);
		public const UInt32 RPI_PCM_INTEN_RXR = (1 << 1);
		public const UInt32 RPI_PCM_INTEN_TXW = (1 << 0);

		public const UInt32 RPI_PCM_INTSTC_RXERR = (1 << 3);
		public const UInt32 RPI_PCM_INTSTC_TXERR = (1 << 2);
		public const UInt32 RPI_PCM_INTSTC_RXR = (1 << 1);
		public const UInt32 RPI_PCM_INTSTC_TXW = (1 << 0);


		public const UInt32 RPI_PCM_GRAY_FLUSH = (1 << 2);
		public const UInt32 RPI_PCM_GRAY_CLR = (1 << 1);
		public const UInt32 RPI_PCM_GRAY_EN = (1 << 0);

		public const UInt32 PCM_OFFSET = (0x00203000);
		public const UInt32 PCM_PERIPH_PHYS = (0x7e203000);

		public const UInt32 NUM_PCMFUNS = 4;
		public const UInt32 PCMFUN_CLK = 0;
		public const UInt32 PCMFUN_FS = 1;
		public const UInt32 PCMFUN_DIN = 2;
		public const UInt32 PCMFUN_DOUT = 3;

		public static UInt32 RPI_PCM_CS_RXTHR(UInt32 val) { return (val & 0x03) << 7; }
		public static UInt32 RPI_PCM_CS_TXTHR(UInt32 val) { return (val & 0x03) << 5; }

		public static UInt32 RPI_PCM_MODE_FLEN(UInt32 val) { return (val & 0x3ff) << 10; }

		public static UInt32 RPI_PCM_MODE_FSLEN(UInt32 val) { return (val & 0x3ff) << 0; }
		public static UInt32 RPI_PCM_GRAY_RXFIFOLEVEL(UInt32 val) { return (val & 0x3f) << 16; }
		public static UInt32 RPI_PCM_GRAY_FLUSHED(UInt32 val) { return (val & 0x3f) << 10; }
		public static UInt32 RPI_PCM_GRAY_RXLEVEL(UInt32 val) { return (val & 0x3f) << 4; }

		public static UInt32 RPI_PCM_RXC_CH1POS(UInt32 val) { return (val & 0x3ff) << 20; }


		public static UInt32 RPI_PCM_RXC_CH1WID(UInt32 val) { return (val & 0x0f) << 16; }
		public static UInt32 RPI_PCM_TXC_CH1POS(UInt32 val) { return (val & 0x3ff) << 20; }
		public static UInt32 RPI_PCM_TXC_CH1WID(UInt32 val) { return (val & 0x0f) << 16; }
		public static UInt32 RPI_PCM_DREQ_TX_PANIC(UInt32 val) { return (val & 0x7f) << 24; }
		public static UInt32 RPI_PCM_DREQ_RX_PANIC(UInt32 val) { return (val & 0x7f) << 16; }
		public static UInt32 RPI_PCM_TXC_CH2POS(UInt32 val) { return (val & 0x3ff) << 4; }
		public static UInt32 RPI_PCM_TXC_CH2WID(UInt32 val) { return (val & 0x0f) << 0; }
		public static UInt32 RPI_PCM_RXC_CH2POS(UInt32 val) { return (val & 0x3ff) << 4; }
		public static UInt32 RPI_PCM_RXC_CH2WID(UInt32 val) { return (val & 0x0f) << 0; }


		public static UInt32 RPI_PCM_DREQ_TX(UInt32 val) { return (val & 0x7f) << 8; }
		public static UInt32 RPI_PCM_DREQ_RX(UInt32 val) { return (val & 0x7f) << 0; }
		#endregion

		#region Pwm
		public static UInt32 RPI_PWM_DMAC_PANIC(UInt32 val) { return (val & 0xff) << 8; }

		public static UInt32 RPI_PWM_DMAC_DREQ(UInt32 val) { return (val & 0xff) << 0; }

		#endregion

		#region Mailbox
		public const int MAJOR_NUM = 100;
		//public static extern IOCTL_MBOX_PROPERTY _IOWR(MAJOR_NUM, 0, char*);

		#endregion

		#region Pwm
		public const UInt32 RPI_PWM_CHANNELS = 2;

		public const UInt32 RPI_PWM_CTL_MSEN2 = (1 << 15);
		public const UInt32 RPI_PWM_CTL_USEF2 = (1 << 13);
		public const UInt32 RPI_PWM_CTL_POLA2 = (1 << 12);
		public const UInt32 RPI_PWM_CTL_SBIT2 = (1 << 11);
		public const UInt32 RPI_PWM_CTL_RPTL2 = (1 << 10);
		public const UInt32 RPI_PWM_CTL_MODE2 = (1 << 9);
		public const UInt32 RPI_PWM_CTL_PWEN2 = (1 << 8);
		public const UInt32 RPI_PWM_CTL_MSEN1 = (1 << 7);
		public const UInt32 RPI_PWM_CTL_CLRF1 = (1 << 6);
		public const UInt32 RPI_PWM_CTL_USEF1 = (1 << 5);
		public const UInt32 RPI_PWM_CTL_POLA1 = (1 << 4);
		public const UInt32 RPI_PWM_CTL_SBIT1 = (1 << 3);
		public const UInt32 RPI_PWM_CTL_RPTL1 = (1 << 2);
		public const UInt32 RPI_PWM_CTL_MODE1 = (1 << 1);
		public const UInt32 RPI_PWM_CTL_PWEN1 = (1 << 0);

		public const UInt32 RPI_PWM_STA_STA4 = (1 << 12);
		public const UInt32 RPI_PWM_STA_STA3 = (1 << 11);
		public const UInt32 RPI_PWM_STA_STA2 = (1 << 10);
		public const UInt32 RPI_PWM_STA_STA1 = (1 << 9);
		public const UInt32 RPI_PWM_STA_BERR = (1 << 8);
		public const UInt32 RPI_PWM_STA_GAP04 = (1 << 7);
		public const UInt32 RPI_PWM_STA_GAP03 = (1 << 6);
		public const UInt32 RPI_PWM_STA_GAP02 = (1 << 5);
		public const UInt32 RPI_PWM_STA_GAP01 = (1 << 4);
		public const UInt32 RPI_PWM_STA_RERR1 = (1 << 3);
		public const UInt32 RPI_PWM_STA_WERR1 = (1 << 2);
		public const UInt32 RPI_PWM_STA_EMPT1 = (1 << 1);
		public const UInt32 RPI_PWM_STA_FULL1 = (1 << 0);

		public const UInt32 RPI_PWM_DMAC_ENAB = ((UInt32)1 << 31);


		public const UInt32 PWM_OFFSET = (0x0020c000);
		public const UInt32 PWM_PERIPH_PHYS = (0x7e20c000);

		#endregion

		#region Ws2811
		public const UInt32 WS2811_TARGET_FREQ = 800000;   // Can go as low as 400000

		// 4 color R, G, B and W ordering
		public const UInt32 SK6812_STRIP_RGBW = 0x18100800;
		public const UInt32 SK6812_STRIP_RBGW = 0x18100008;
		public const UInt32 SK6812_STRIP_GRBW = 0x18081000;
		public const UInt32 SK6812_STRIP_GBRW = 0x18080010;
		public const UInt32 SK6812_STRIP_BRGW = 0x18001008;
		public const UInt32 SK6812_STRIP_BGRW = 0x18000810;
		public const UInt32 SK6812_SHIFT_WMASK = 0xf0000000;

		// 3 color R, G and B ordering
		public const UInt32 WS2811_STRIP_RGB = 0x00100800;
		public const UInt32 WS2811_STRIP_RBG = 0x00100008;
		public const UInt32 WS2811_STRIP_GRB = 0x00081000;
		public const UInt32 WS2811_STRIP_GBR = 0x00080010;
		public const UInt32 WS2811_STRIP_BRG = 0x00001008;
		public const UInt32 WS2811_STRIP_BGR = 0x00000810;

		// predefined fixed LED types
		public const UInt32 WS2812_STRIP = WS2811_STRIP_GRB;
		public const UInt32 SK6812_STRIP = WS2811_STRIP_GRB;
		public const UInt32 SK6812W_STRIP = SK6812_STRIP_GRBW;


		#endregion
	}
}
