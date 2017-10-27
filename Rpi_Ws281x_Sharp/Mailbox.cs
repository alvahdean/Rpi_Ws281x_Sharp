/*
Copyright (c) 2012, Broadcom Europe Ltd.
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the copyright holder nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

/*
 * 2017-Oct-26: C# Wrapper by Dean Fuqua <alvahdean @ gmail.com> 
 */


namespace RpiWs281xSharp
{
using System;
    using System.Runtime.InteropServices;
    using static RpiWs281xSharp.Global;

	public static class MailBox
    {
		[DllImport(RpiWs281XNativeLib, EntryPoint = "mbox_open")]
		public static extern int mbox_open();

		[DllImport(RpiWs281XNativeLib, EntryPoint = "mbox_close")]
		public static extern void mbox_close(int file_desc);

		[DllImport(RpiWs281XNativeLib, EntryPoint = "get_version")]
		public static extern uint get_version(int file_desc);

		[DllImport(RpiWs281XNativeLib, EntryPoint = "mem_alloc")]
		public static extern uint mem_alloc(int file_desc, uint size, uint align, uint flags);

		[DllImport(RpiWs281XNativeLib, EntryPoint = "gpio_level_set")]
		public static extern uint mem_free(int file_desc, uint handle);

		[DllImport(RpiWs281XNativeLib, EntryPoint = "gpio_level_set")]
		public static extern uint mem_lock(int file_desc, uint handle);

		[DllImport(RpiWs281XNativeLib, EntryPoint = "gpio_level_set")]
		public static extern uint mem_unlock(int file_desc, uint handle);

        [DllImport(RpiWs281XNativeLib, EntryPoint = "mapmem")]
        public static extern IntPtr mapmem(uint baseMem, uint size);

		[DllImport(RpiWs281XNativeLib, EntryPoint = "unmapmem")]
		public static extern IntPtr unmapmem(IntPtr addr, uint size);

		[DllImport(RpiWs281XNativeLib, EntryPoint = "execute_code")]
		public static extern uint execute_code(int file_desc, uint code, uint r0, uint r1, uint r2, uint r3, uint r4, uint r5);

		[DllImport(RpiWs281XNativeLib, EntryPoint = "execute_qpu")]
		public static extern uint execute_qpu(int file_desc, uint num_qpus, uint control, uint noflush, uint timeout);

		[DllImport(RpiWs281XNativeLib, EntryPoint = "qpu_enable")]
		public static extern uint qpu_enable(int file_desc, uint enable);

	}
}
