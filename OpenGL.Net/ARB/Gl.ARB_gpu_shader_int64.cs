
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
		/// [GL] Value of GL_INT64_ARB symbol.
		/// </summary>
		[AliasOf("GL_INT64_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public const int INT64_ARB = 0x140E;

		/// <summary>
		/// [GL] Value of GL_INT64_VEC2_ARB symbol.
		/// </summary>
		[AliasOf("GL_INT64_VEC2_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int INT64_VEC2_ARB = 0x8FE9;

		/// <summary>
		/// [GL] Value of GL_INT64_VEC3_ARB symbol.
		/// </summary>
		[AliasOf("GL_INT64_VEC3_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int INT64_VEC3_ARB = 0x8FEA;

		/// <summary>
		/// [GL] Value of GL_INT64_VEC4_ARB symbol.
		/// </summary>
		[AliasOf("GL_INT64_VEC4_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int INT64_VEC4_ARB = 0x8FEB;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT64_VEC2_ARB symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT64_VEC2_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int UNSIGNED_INT64_VEC2_ARB = 0x8FF5;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT64_VEC3_ARB symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT64_VEC3_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int UNSIGNED_INT64_VEC3_ARB = 0x8FF6;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT64_VEC4_ARB symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT64_VEC4_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int UNSIGNED_INT64_VEC4_ARB = 0x8FF7;

		/// <summary>
		/// [GL] Binding for glUniform1i64ARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform1ARB(Int32 location, Int64 x)
		{
			Debug.Assert(Delegates.pglUniform1i64ARB != null, "pglUniform1i64ARB not implemented");
			Delegates.pglUniform1i64ARB(location, x);
			LogCommand("glUniform1i64ARB", null, location, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform2i64ARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform2ARB(Int32 location, Int64 x, Int64 y)
		{
			Debug.Assert(Delegates.pglUniform2i64ARB != null, "pglUniform2i64ARB not implemented");
			Delegates.pglUniform2i64ARB(location, x, y);
			LogCommand("glUniform2i64ARB", null, location, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform3i64ARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform3ARB(Int32 location, Int64 x, Int64 y, Int64 z)
		{
			Debug.Assert(Delegates.pglUniform3i64ARB != null, "pglUniform3i64ARB not implemented");
			Delegates.pglUniform3i64ARB(location, x, y, z);
			LogCommand("glUniform3i64ARB", null, location, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform4i64ARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform4ARB(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Debug.Assert(Delegates.pglUniform4i64ARB != null, "pglUniform4i64ARB not implemented");
			Delegates.pglUniform4i64ARB(location, x, y, z, w);
			LogCommand("glUniform4i64ARB", null, location, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform1i64vARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform1ARB(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1i64vARB != null, "pglUniform1i64vARB not implemented");
					Delegates.pglUniform1i64vARB(location, count, p_value);
					LogCommand("glUniform1i64vARB", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform2i64vARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform2ARB(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2i64vARB != null, "pglUniform2i64vARB not implemented");
					Delegates.pglUniform2i64vARB(location, count, p_value);
					LogCommand("glUniform2i64vARB", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform3i64vARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform3ARB(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3i64vARB != null, "pglUniform3i64vARB not implemented");
					Delegates.pglUniform3i64vARB(location, count, p_value);
					LogCommand("glUniform3i64vARB", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform4i64vARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform4ARB(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4i64vARB != null, "pglUniform4i64vARB not implemented");
					Delegates.pglUniform4i64vARB(location, count, p_value);
					LogCommand("glUniform4i64vARB", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform1ui64ARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform1ARB(Int32 location, UInt64 x)
		{
			Debug.Assert(Delegates.pglUniform1ui64ARB != null, "pglUniform1ui64ARB not implemented");
			Delegates.pglUniform1ui64ARB(location, x);
			LogCommand("glUniform1ui64ARB", null, location, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform2ui64ARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform2ARB(Int32 location, UInt64 x, UInt64 y)
		{
			Debug.Assert(Delegates.pglUniform2ui64ARB != null, "pglUniform2ui64ARB not implemented");
			Delegates.pglUniform2ui64ARB(location, x, y);
			LogCommand("glUniform2ui64ARB", null, location, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform3ui64ARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform3ARB(Int32 location, UInt64 x, UInt64 y, UInt64 z)
		{
			Debug.Assert(Delegates.pglUniform3ui64ARB != null, "pglUniform3ui64ARB not implemented");
			Delegates.pglUniform3ui64ARB(location, x, y, z);
			LogCommand("glUniform3ui64ARB", null, location, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform4ui64ARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform4ARB(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Debug.Assert(Delegates.pglUniform4ui64ARB != null, "pglUniform4ui64ARB not implemented");
			Delegates.pglUniform4ui64ARB(location, x, y, z, w);
			LogCommand("glUniform4ui64ARB", null, location, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform1ui64vARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform1ARB(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1ui64vARB != null, "pglUniform1ui64vARB not implemented");
					Delegates.pglUniform1ui64vARB(location, count, p_value);
					LogCommand("glUniform1ui64vARB", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform2ui64vARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform2ARB(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2ui64vARB != null, "pglUniform2ui64vARB not implemented");
					Delegates.pglUniform2ui64vARB(location, count, p_value);
					LogCommand("glUniform2ui64vARB", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform3ui64vARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform3ARB(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3ui64vARB != null, "pglUniform3ui64vARB not implemented");
					Delegates.pglUniform3ui64vARB(location, count, p_value);
					LogCommand("glUniform3ui64vARB", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform4ui64vARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void Uniform4ARB(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4ui64vARB != null, "pglUniform4ui64vARB not implemented");
					Delegates.pglUniform4ui64vARB(location, count, p_value);
					LogCommand("glUniform4ui64vARB", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetUniformi64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void GetUniformARB(UInt32 program, Int32 location, [Out] Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformi64vARB != null, "pglGetUniformi64vARB not implemented");
					Delegates.pglGetUniformi64vARB(program, location, p_params);
					LogCommand("glGetUniformi64vARB", null, program, location, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetUniformui64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void GetUniformARB(UInt32 program, Int32 location, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformui64vARB != null, "pglGetUniformui64vARB not implemented");
					Delegates.pglGetUniformui64vARB(program, location, p_params);
					LogCommand("glGetUniformui64vARB", null, program, location, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetnUniformi64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void GetnUniformARB(UInt32 program, Int32 location, Int32 bufSize, [Out] Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformi64vARB != null, "pglGetnUniformi64vARB not implemented");
					Delegates.pglGetnUniformi64vARB(program, location, bufSize, p_params);
					LogCommand("glGetnUniformi64vARB", null, program, location, bufSize, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetnUniformui64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void GetnUniformARB(UInt32 program, Int32 location, Int32 bufSize, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformui64vARB != null, "pglGetnUniformui64vARB not implemented");
					Delegates.pglGetnUniformui64vARB(program, location, bufSize, p_params);
					LogCommand("glGetnUniformui64vARB", null, program, location, bufSize, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform1i64ARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform1ARB(UInt32 program, Int32 location, Int64 x)
		{
			Debug.Assert(Delegates.pglProgramUniform1i64ARB != null, "pglProgramUniform1i64ARB not implemented");
			Delegates.pglProgramUniform1i64ARB(program, location, x);
			LogCommand("glProgramUniform1i64ARB", null, program, location, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform2i64ARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform2ARB(UInt32 program, Int32 location, Int64 x, Int64 y)
		{
			Debug.Assert(Delegates.pglProgramUniform2i64ARB != null, "pglProgramUniform2i64ARB not implemented");
			Delegates.pglProgramUniform2i64ARB(program, location, x, y);
			LogCommand("glProgramUniform2i64ARB", null, program, location, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform3i64ARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform3ARB(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z)
		{
			Debug.Assert(Delegates.pglProgramUniform3i64ARB != null, "pglProgramUniform3i64ARB not implemented");
			Delegates.pglProgramUniform3i64ARB(program, location, x, y, z);
			LogCommand("glProgramUniform3i64ARB", null, program, location, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform4i64ARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform4ARB(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Debug.Assert(Delegates.pglProgramUniform4i64ARB != null, "pglProgramUniform4i64ARB not implemented");
			Delegates.pglProgramUniform4i64ARB(program, location, x, y, z, w);
			LogCommand("glProgramUniform4i64ARB", null, program, location, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform1i64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform1ARB(UInt32 program, Int32 location, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1i64vARB != null, "pglProgramUniform1i64vARB not implemented");
					Delegates.pglProgramUniform1i64vARB(program, location, (Int32)value.Length, p_value);
					LogCommand("glProgramUniform1i64vARB", null, program, location, value.Length, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform2i64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform2ARB(UInt32 program, Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2i64vARB != null, "pglProgramUniform2i64vARB not implemented");
					Delegates.pglProgramUniform2i64vARB(program, location, count, p_value);
					LogCommand("glProgramUniform2i64vARB", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform3i64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform3ARB(UInt32 program, Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3i64vARB != null, "pglProgramUniform3i64vARB not implemented");
					Delegates.pglProgramUniform3i64vARB(program, location, count, p_value);
					LogCommand("glProgramUniform3i64vARB", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform4i64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform4ARB(UInt32 program, Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4i64vARB != null, "pglProgramUniform4i64vARB not implemented");
					Delegates.pglProgramUniform4i64vARB(program, location, count, p_value);
					LogCommand("glProgramUniform4i64vARB", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform1ui64ARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform1ARB(UInt32 program, Int32 location, UInt64 x)
		{
			Debug.Assert(Delegates.pglProgramUniform1ui64ARB != null, "pglProgramUniform1ui64ARB not implemented");
			Delegates.pglProgramUniform1ui64ARB(program, location, x);
			LogCommand("glProgramUniform1ui64ARB", null, program, location, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform2ui64ARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform2ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y)
		{
			Debug.Assert(Delegates.pglProgramUniform2ui64ARB != null, "pglProgramUniform2ui64ARB not implemented");
			Delegates.pglProgramUniform2ui64ARB(program, location, x, y);
			LogCommand("glProgramUniform2ui64ARB", null, program, location, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform3ui64ARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform3ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z)
		{
			Debug.Assert(Delegates.pglProgramUniform3ui64ARB != null, "pglProgramUniform3ui64ARB not implemented");
			Delegates.pglProgramUniform3ui64ARB(program, location, x, y, z);
			LogCommand("glProgramUniform3ui64ARB", null, program, location, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform4ui64ARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform4ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Debug.Assert(Delegates.pglProgramUniform4ui64ARB != null, "pglProgramUniform4ui64ARB not implemented");
			Delegates.pglProgramUniform4ui64ARB(program, location, x, y, z, w);
			LogCommand("glProgramUniform4ui64ARB", null, program, location, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform1ui64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform1ARB(UInt32 program, Int32 location, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1ui64vARB != null, "pglProgramUniform1ui64vARB not implemented");
					Delegates.pglProgramUniform1ui64vARB(program, location, (Int32)value.Length, p_value);
					LogCommand("glProgramUniform1ui64vARB", null, program, location, value.Length, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform2ui64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform2ARB(UInt32 program, Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2ui64vARB != null, "pglProgramUniform2ui64vARB not implemented");
					Delegates.pglProgramUniform2ui64vARB(program, location, count, p_value);
					LogCommand("glProgramUniform2ui64vARB", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform3ui64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform3ARB(UInt32 program, Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3ui64vARB != null, "pglProgramUniform3ui64vARB not implemented");
					Delegates.pglProgramUniform3ui64vARB(program, location, count, p_value);
					LogCommand("glProgramUniform3ui64vARB", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform4ui64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		public static void ProgramUniform4ARB(UInt32 program, Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4ui64vARB != null, "pglProgramUniform4ui64vARB not implemented");
					Delegates.pglProgramUniform4ui64vARB(program, location, count, p_value);
					LogCommand("glProgramUniform4ui64vARB", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform1i64ARB", ExactSpelling = true)]
			internal extern static void glUniform1i64ARB(Int32 location, Int64 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform2i64ARB", ExactSpelling = true)]
			internal extern static void glUniform2i64ARB(Int32 location, Int64 x, Int64 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform3i64ARB", ExactSpelling = true)]
			internal extern static void glUniform3i64ARB(Int32 location, Int64 x, Int64 y, Int64 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform4i64ARB", ExactSpelling = true)]
			internal extern static void glUniform4i64ARB(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform1i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform1i64vARB(Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform2i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform2i64vARB(Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform3i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform3i64vARB(Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform4i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform4i64vARB(Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform1ui64ARB", ExactSpelling = true)]
			internal extern static void glUniform1ui64ARB(Int32 location, UInt64 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform2ui64ARB", ExactSpelling = true)]
			internal extern static void glUniform2ui64ARB(Int32 location, UInt64 x, UInt64 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform3ui64ARB", ExactSpelling = true)]
			internal extern static void glUniform3ui64ARB(Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform4ui64ARB", ExactSpelling = true)]
			internal extern static void glUniform4ui64ARB(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform1ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform1ui64vARB(Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform2ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform2ui64vARB(Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform3ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform3ui64vARB(Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform4ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniform4ui64vARB(Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetUniformi64vARB", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformi64vARB(UInt32 program, Int32 location, Int64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetUniformui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformui64vARB(UInt32 program, Int32 location, UInt64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnUniformi64vARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformi64vARB(UInt32 program, Int32 location, Int32 bufSize, Int64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnUniformui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformui64vARB(UInt32 program, Int32 location, Int32 bufSize, UInt64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1i64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform1i64ARB(UInt32 program, Int32 location, Int64 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2i64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform2i64ARB(UInt32 program, Int32 location, Int64 x, Int64 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3i64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform3i64ARB(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4i64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform4i64ARB(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4i64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1ui64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform1ui64ARB(UInt32 program, Int32 location, UInt64 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2ui64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform2ui64ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3ui64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform3ui64ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4ui64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniform4ui64ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform1i64ARB(Int32 location, Int64 x);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform1i64ARB pglUniform1i64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform2i64ARB(Int32 location, Int64 x, Int64 y);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform2i64ARB pglUniform2i64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform3i64ARB(Int32 location, Int64 x, Int64 y, Int64 z);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform3i64ARB pglUniform3i64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform4i64ARB(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform4i64ARB pglUniform4i64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform1i64vARB(Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform1i64vARB pglUniform1i64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform2i64vARB(Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform2i64vARB pglUniform2i64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform3i64vARB(Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform3i64vARB pglUniform3i64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform4i64vARB(Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform4i64vARB pglUniform4i64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform1ui64ARB(Int32 location, UInt64 x);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform1ui64ARB pglUniform1ui64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform2ui64ARB(Int32 location, UInt64 x, UInt64 y);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform2ui64ARB pglUniform2ui64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform3ui64ARB(Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform3ui64ARB pglUniform3ui64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform4ui64ARB(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform4ui64ARB pglUniform4ui64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform1ui64vARB(Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform1ui64vARB pglUniform1ui64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform2ui64vARB(Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform2ui64vARB pglUniform2ui64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform3ui64vARB(Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform3ui64vARB pglUniform3ui64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform4ui64vARB(Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUniform4ui64vARB pglUniform4ui64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformi64vARB(UInt32 program, Int32 location, Int64* @params);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetUniformi64vARB pglGetUniformi64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformui64vARB(UInt32 program, Int32 location, UInt64* @params);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetUniformui64vARB pglGetUniformui64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformi64vARB(UInt32 program, Int32 location, Int32 bufSize, Int64* @params);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetnUniformi64vARB pglGetnUniformi64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformui64vARB(UInt32 program, Int32 location, Int32 bufSize, UInt64* @params);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetnUniformui64vARB pglGetnUniformui64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1i64ARB(UInt32 program, Int32 location, Int64 x);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform1i64ARB pglProgramUniform1i64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2i64ARB(UInt32 program, Int32 location, Int64 x, Int64 y);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform2i64ARB pglProgramUniform2i64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3i64ARB(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform3i64ARB pglProgramUniform3i64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4i64ARB(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform4i64ARB pglProgramUniform4i64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform1i64vARB pglProgramUniform1i64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform2i64vARB pglProgramUniform2i64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform3i64vARB pglProgramUniform3i64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4i64vARB(UInt32 program, Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform4i64vARB pglProgramUniform4i64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1ui64ARB(UInt32 program, Int32 location, UInt64 x);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform1ui64ARB pglProgramUniform1ui64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2ui64ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform2ui64ARB pglProgramUniform2ui64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3ui64ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform3ui64ARB pglProgramUniform3ui64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4ui64ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform4ui64ARB pglProgramUniform4ui64ARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform1ui64vARB pglProgramUniform1ui64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform2ui64vARB pglProgramUniform2ui64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform3ui64vARB pglProgramUniform3ui64vARB;

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4ui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glProgramUniform4ui64vARB pglProgramUniform4ui64vARB;

		}
	}

}
