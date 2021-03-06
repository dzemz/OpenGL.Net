
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_INSTRUMENT_BUFFER_POINTER_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_instruments")]
		public const int INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180;

		/// <summary>
		/// [GL] Value of GL_INSTRUMENT_MEASUREMENTS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_instruments")]
		public const int INSTRUMENT_MEASUREMENTS_SGIX = 0x8181;

		/// <summary>
		/// [GL] glGetInstrumentsSGIX: Binding for glGetInstrumentsSGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_instruments")]
		public static Int32 GetInstrumentsSGIX()
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetInstrumentsSGIX != null, "pglGetInstrumentsSGIX not implemented");
			retValue = Delegates.pglGetInstrumentsSGIX();
			LogCommand("glGetInstrumentsSGIX", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glInstrumentsBufferSGIX: Binding for glInstrumentsBufferSGIX.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_instruments")]
		public static void InstrumentsBufferSGIX(Int32[] buffer)
		{
			unsafe {
				fixed (Int32* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglInstrumentsBufferSGIX != null, "pglInstrumentsBufferSGIX not implemented");
					Delegates.pglInstrumentsBufferSGIX((Int32)buffer.Length, p_buffer);
					LogCommand("glInstrumentsBufferSGIX", null, buffer.Length, buffer					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glPollInstrumentsSGIX: Binding for glPollInstrumentsSGIX.
		/// </summary>
		/// <param name="marker_p">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_instruments")]
		public static Int32 PollInstrumentsSGIX(Int32[] marker_p)
		{
			Int32 retValue;

			unsafe {
				fixed (Int32* p_marker_p = marker_p)
				{
					Debug.Assert(Delegates.pglPollInstrumentsSGIX != null, "pglPollInstrumentsSGIX not implemented");
					retValue = Delegates.pglPollInstrumentsSGIX(p_marker_p);
					LogCommand("glPollInstrumentsSGIX", retValue, marker_p					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glReadInstrumentsSGIX: Binding for glReadInstrumentsSGIX.
		/// </summary>
		/// <param name="marker">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_instruments")]
		public static void ReadInstrumentsSGIX(Int32 marker)
		{
			Debug.Assert(Delegates.pglReadInstrumentsSGIX != null, "pglReadInstrumentsSGIX not implemented");
			Delegates.pglReadInstrumentsSGIX(marker);
			LogCommand("glReadInstrumentsSGIX", null, marker			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glStartInstrumentsSGIX: Binding for glStartInstrumentsSGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_instruments")]
		public static void StartInstrumentsSGIX()
		{
			Debug.Assert(Delegates.pglStartInstrumentsSGIX != null, "pglStartInstrumentsSGIX not implemented");
			Delegates.pglStartInstrumentsSGIX();
			LogCommand("glStartInstrumentsSGIX", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glStopInstrumentsSGIX: Binding for glStopInstrumentsSGIX.
		/// </summary>
		/// <param name="marker">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_instruments")]
		public static void StopInstrumentsSGIX(Int32 marker)
		{
			Debug.Assert(Delegates.pglStopInstrumentsSGIX != null, "pglStopInstrumentsSGIX not implemented");
			Delegates.pglStopInstrumentsSGIX(marker);
			LogCommand("glStopInstrumentsSGIX", null, marker			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIX_instruments")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetInstrumentsSGIX();

			[RequiredByFeature("GL_SGIX_instruments")]
			[ThreadStatic]
			internal static glGetInstrumentsSGIX pglGetInstrumentsSGIX;

			[RequiredByFeature("GL_SGIX_instruments")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glInstrumentsBufferSGIX(Int32 size, Int32* buffer);

			[RequiredByFeature("GL_SGIX_instruments")]
			[ThreadStatic]
			internal static glInstrumentsBufferSGIX pglInstrumentsBufferSGIX;

			[RequiredByFeature("GL_SGIX_instruments")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int32 glPollInstrumentsSGIX(Int32* marker_p);

			[RequiredByFeature("GL_SGIX_instruments")]
			[ThreadStatic]
			internal static glPollInstrumentsSGIX pglPollInstrumentsSGIX;

			[RequiredByFeature("GL_SGIX_instruments")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReadInstrumentsSGIX(Int32 marker);

			[RequiredByFeature("GL_SGIX_instruments")]
			[ThreadStatic]
			internal static glReadInstrumentsSGIX pglReadInstrumentsSGIX;

			[RequiredByFeature("GL_SGIX_instruments")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStartInstrumentsSGIX();

			[RequiredByFeature("GL_SGIX_instruments")]
			[ThreadStatic]
			internal static glStartInstrumentsSGIX pglStartInstrumentsSGIX;

			[RequiredByFeature("GL_SGIX_instruments")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStopInstrumentsSGIX(Int32 marker);

			[RequiredByFeature("GL_SGIX_instruments")]
			[ThreadStatic]
			internal static glStopInstrumentsSGIX pglStopInstrumentsSGIX;

		}
	}

}
