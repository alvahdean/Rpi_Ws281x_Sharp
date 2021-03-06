﻿/*
 * ws2811.h
 *
 * Copyright (c) 2014 Jeremy Garff <jer @ jers.net>
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

/*
 * 2017-Oct-26: C# Wrapper by Dean Fuqua <alvahdean @ gmail.com> 
 */


namespace RpiWs281xSharp
{
    using System;
    using System.Runtime.InteropServices;
    using static RpiWs281xSharp.Global;

    public static class Ws2811
    {

        [DllImport(RpiWs281XNativeLib, EntryPoint = "ws2811_init")]
        public static extern ws2811_return_t ws2811_init(ws2811_t ws2811);                         //< Initialize buffers/hardware

        [DllImport(RpiWs281XNativeLib, EntryPoint = "ws2811_fini")]
        public static extern void ws2811_fini(ws2811_t ws2811);                                    //< Tear it all down

        [DllImport(RpiWs281XNativeLib, EntryPoint = "ws2811_render")]
        public static extern ws2811_return_t ws2811_render(ws2811_t ws2811);                       //< Send LEDs off to hardware

        [DllImport(RpiWs281XNativeLib, EntryPoint = "ws2811_wait")]
        unsafe public static extern ws2811_return_t ws2811_wait(ws2811_t ws2811);                         //< Wait for DMA completion

        [DllImport(RpiWs281XNativeLib, EntryPoint = "ws2811_get_return_t_str")]
        public static extern char[] ws2811_get_return_t_str(ws2811_return_t state);     //< Get string representation of the given return state

    }
}
