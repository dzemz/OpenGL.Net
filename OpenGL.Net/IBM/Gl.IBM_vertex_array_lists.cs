
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int VERTEX_ARRAY_LIST_IBM = 103070;

		/// <summary>
		/// [GL] Value of GL_NORMAL_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int NORMAL_ARRAY_LIST_IBM = 103071;

		/// <summary>
		/// [GL] Value of GL_COLOR_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int COLOR_ARRAY_LIST_IBM = 103072;

		/// <summary>
		/// [GL] Value of GL_INDEX_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int INDEX_ARRAY_LIST_IBM = 103073;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_COORD_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int TEXTURE_COORD_ARRAY_LIST_IBM = 103074;

		/// <summary>
		/// [GL] Value of GL_EDGE_FLAG_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int EDGE_FLAG_ARRAY_LIST_IBM = 103075;

		/// <summary>
		/// [GL] Value of GL_FOG_COORDINATE_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int FOG_COORDINATE_ARRAY_LIST_IBM = 103076;

		/// <summary>
		/// [GL] Value of GL_SECONDARY_COLOR_ARRAY_LIST_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int SECONDARY_COLOR_ARRAY_LIST_IBM = 103077;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int VERTEX_ARRAY_LIST_STRIDE_IBM = 103080;

		/// <summary>
		/// [GL] Value of GL_NORMAL_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int NORMAL_ARRAY_LIST_STRIDE_IBM = 103081;

		/// <summary>
		/// [GL] Value of GL_COLOR_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int COLOR_ARRAY_LIST_STRIDE_IBM = 103082;

		/// <summary>
		/// [GL] Value of GL_INDEX_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int INDEX_ARRAY_LIST_STRIDE_IBM = 103083;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM = 103084;

		/// <summary>
		/// [GL] Value of GL_EDGE_FLAG_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int EDGE_FLAG_ARRAY_LIST_STRIDE_IBM = 103085;

		/// <summary>
		/// [GL] Value of GL_FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM = 103086;

		/// <summary>
		/// [GL] Value of GL_SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public const int SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM = 103087;

		/// <summary>
		/// [GL] Binding for glColorPointerListIBM.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:ColorPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void ColorPointerListIBM(Int32 size, ColorPointerType type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglColorPointerListIBM != null, "pglColorPointerListIBM not implemented");
					Delegates.pglColorPointerListIBM(size, (Int32)type, stride, p_pointer, ptrstride);
					LogCommand("glColorPointerListIBM", null, size, type, stride, pointer, ptrstride					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glSecondaryColorPointerListIBM.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void SecondaryColorPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglSecondaryColorPointerListIBM != null, "pglSecondaryColorPointerListIBM not implemented");
					Delegates.pglSecondaryColorPointerListIBM(size, type, stride, p_pointer, ptrstride);
					LogCommand("glSecondaryColorPointerListIBM", null, size, type, stride, pointer, ptrstride					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glEdgeFlagPointerListIBM.
		/// </summary>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void EdgeFlagPointerListIBM(Int32 stride, bool[] pointer, Int32 ptrstride)
		{
			Debug.Assert(Delegates.pglEdgeFlagPointerListIBM != null, "pglEdgeFlagPointerListIBM not implemented");
			Delegates.pglEdgeFlagPointerListIBM(stride, pointer, ptrstride);
			LogCommand("glEdgeFlagPointerListIBM", null, stride, pointer, ptrstride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glFogCoordPointerListIBM.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:FogCoordinatePointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void FogCoordPointerListIBM(FogCoordinatePointerType type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglFogCoordPointerListIBM != null, "pglFogCoordPointerListIBM not implemented");
					Delegates.pglFogCoordPointerListIBM((Int32)type, stride, p_pointer, ptrstride);
					LogCommand("glFogCoordPointerListIBM", null, type, stride, pointer, ptrstride					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glIndexPointerListIBM.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:IndexPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void IndexPointerListIBM(IndexPointerType type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglIndexPointerListIBM != null, "pglIndexPointerListIBM not implemented");
					Delegates.pglIndexPointerListIBM((Int32)type, stride, p_pointer, ptrstride);
					LogCommand("glIndexPointerListIBM", null, type, stride, pointer, ptrstride					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glNormalPointerListIBM.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:NormalPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void NormalPointerListIBM(NormalPointerType type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglNormalPointerListIBM != null, "pglNormalPointerListIBM not implemented");
					Delegates.pglNormalPointerListIBM((Int32)type, stride, p_pointer, ptrstride);
					LogCommand("glNormalPointerListIBM", null, type, stride, pointer, ptrstride					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoordPointerListIBM.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:TexCoordPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void TexCoordPointerListIBM(Int32 size, TexCoordPointerType type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglTexCoordPointerListIBM != null, "pglTexCoordPointerListIBM not implemented");
					Delegates.pglTexCoordPointerListIBM(size, (Int32)type, stride, p_pointer, ptrstride);
					LogCommand("glTexCoordPointerListIBM", null, size, type, stride, pointer, ptrstride					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexPointerListIBM.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:VertexPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ptrstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_vertex_array_lists")]
		public static void VertexPointerListIBM(Int32 size, VertexPointerType type, Int32 stride, IntPtr[] pointer, Int32 ptrstride)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglVertexPointerListIBM != null, "pglVertexPointerListIBM not implemented");
					Delegates.pglVertexPointerListIBM(size, (Int32)type, stride, p_pointer, ptrstride);
					LogCommand("glVertexPointerListIBM", null, size, type, stride, pointer, ptrstride					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColorPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glColorPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColorPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColorPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEdgeFlagPointerListIBM", ExactSpelling = true)]
			internal extern static void glEdgeFlagPointerListIBM(Int32 stride, bool[] pointer, Int32 ptrstride);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogCoordPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glFogCoordPointerListIBM(Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glIndexPointerListIBM(Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glNormalPointerListIBM(Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoordPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexPointerListIBM", ExactSpelling = true)]
			internal extern static unsafe void glVertexPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[ThreadStatic]
			internal static glColorPointerListIBM pglColorPointerListIBM;

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColorPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[ThreadStatic]
			internal static glSecondaryColorPointerListIBM pglSecondaryColorPointerListIBM;

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEdgeFlagPointerListIBM(Int32 stride, bool[] pointer, Int32 ptrstride);

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[ThreadStatic]
			internal static glEdgeFlagPointerListIBM pglEdgeFlagPointerListIBM;

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogCoordPointerListIBM(Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[ThreadStatic]
			internal static glFogCoordPointerListIBM pglFogCoordPointerListIBM;

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexPointerListIBM(Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[ThreadStatic]
			internal static glIndexPointerListIBM pglIndexPointerListIBM;

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalPointerListIBM(Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[ThreadStatic]
			internal static glNormalPointerListIBM pglNormalPointerListIBM;

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[ThreadStatic]
			internal static glTexCoordPointerListIBM pglTexCoordPointerListIBM;

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexPointerListIBM(Int32 size, Int32 type, Int32 stride, IntPtr* pointer, Int32 ptrstride);

			[RequiredByFeature("GL_IBM_vertex_array_lists")]
			[ThreadStatic]
			internal static glVertexPointerListIBM pglVertexPointerListIBM;

		}
	}

}
