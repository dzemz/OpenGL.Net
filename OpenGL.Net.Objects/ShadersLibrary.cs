﻿
// Copyright (C) 2015-2016 Luca Piccioni
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace OpenGL.Objects
{
	/// <summary>
	/// Shaders library.
	/// </summary>
	[XmlRoot("ShadersLibrary")]
	public sealed class ShadersLibrary
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static ShadersLibrary()
		{
			// Load OpenGL.Objects shaders library
			Merge("OpenGL.Objects.Shaders._ShadersLibrary.xml");
			Merge("OpenGL.Objects.Shaders.Light._ShadersLibrary.xml");
			Merge("OpenGL.Objects.Shaders.Standard._ShadersLibrary.xml");
			Merge("OpenGL.Objects.Shaders.Skybox._ShadersLibrary.xml");
		}

		#endregion

		#region Includes

		/// <summary>
		/// Shader object.
		/// </summary>
		[XmlType("Include")]
		public class Include
		{
			/// <summary>
			/// The path of the shader object source.
			/// </summary>
			[XmlAttribute("Id")]
			public string Id;

			/// <summary>
			/// Preprocessor symbols affecting the shader object compilation.
			/// </summary>
			[XmlElement("Path")]
			public string Path;
		}

		/// <summary>
		/// List of paths specifying shader include sources.
		/// </summary>
		[XmlArray("Includes")]
		[XmlArrayItem("Include")]
		public readonly List<Include> Includes = new List<Include>();

		#endregion

		#region Objects

		/// <summary>
		/// Shader object.
		/// </summary>
		[XmlType("Object")]
		public class Object
		{
			/// <summary>
			/// The path of the shader object source.
			/// </summary>
			[XmlAttribute("Path")]
			public string Path;

			/// <summary>
			/// Shader object stage.
			/// </summary>
			[XmlAttribute("Stage")]
			public ShaderStage Stage = ShaderStage.Vertex;

			/// <summary>
			/// Preprocessor symbols affecting the shader object compilation.
			/// </summary>
			[XmlArray("Symbols")]
			[XmlArrayItem("Symbol")]
			public readonly List<string> Symbols = new List<string>();

			/// <summary>
			/// Create a shader object from this Object.
			/// </summary>
			/// <returns></returns>
			public ShaderObject Create()
			{
				ShaderObject shaderObject = new ShaderObject(Stage);

				// Load source
				shaderObject.LoadSource(Path);

				return (shaderObject);
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="cctx"></param>
			/// <returns></returns>
			internal void GetHashInfo(StringBuilder hashMessage, ShaderCompilerContext cctx)
			{
				// Shaders can be compiled at different stages
				hashMessage.Append(Stage);
				// All symbols known for this shader are included
				foreach (string define in cctx.Defines) {
					if (Symbols.Contains(define) == false)
						continue;
					hashMessage.Append(define);
				}
			}
		}

		/// <summary>
		/// List of <see cref="Object"/> instances describing the available shader objects in library.
		/// </summary>
		[XmlArray("Objects")]
		[XmlArrayItem("Object")]
		public readonly List<Object> Objects = new List<Object>();

		/// <summary>
		/// Get the definition of a object.
		/// </summary>
		/// <param name="objectId">
		/// A <see cref="String"/> that specifies the object identifier.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Object"/> describing the object identified with <paramref name="objectId"/>.
		/// </returns>
		public Object GetObject(string objectId)
		{
			if (objectId == null)
				throw new ArgumentNullException("programId");

			return (Objects.Find(delegate(Object item) { return (item.Path == objectId); }));
		}

		#endregion

		#region Programs

		/// <summary>
		/// Program object.
		/// </summary>
		[XmlType("Program")]
		public class Program
		{
			/// <summary>
			/// The identifier of the shader program.
			/// </summary>
			[XmlAttribute("Id")]
			public string Id;

			/// <summary>
			/// Object linked to this shader program.
			/// </summary>
			[XmlElement("Object")]
			public readonly List<Object> Objects = new List<Object>();

			[XmlType("Attribute")]
			public class Attribute
			{
				/// <summary>
				/// Attribute name.
				/// </summary>
				[XmlAttribute("Name")]
				public string Name;

				/// <summary>
				/// Attribute semantic.
				/// </summary>
				[XmlAttribute("Semantic")]
				public string Semantic;
			}

			/// <summary>
			/// 
			/// </summary>
			[XmlElement("Attribute")]
			public readonly List<Attribute> Attributes = new List<Attribute>();

			[XmlType("Uniform")]
			public class Uniform
			{
				/// <summary>
				/// Uniform name.
				/// </summary>
				[XmlAttribute("Name")]
				public string Name;

				/// <summary>
				/// Uniform semantic.
				/// </summary>
				[XmlAttribute("Semantic")]
				public string Semantic;
			}

			/// <summary>
			/// 
			/// </summary>
			[XmlElement("Uniform")]
			public readonly List<Uniform> Uniforms = new List<Uniform>();

			/// <summary>
			/// Create a program from this Program.
			/// </summary>
			/// <returns></returns>
			public ShaderProgram Create()
			{
				return (Create(GetCompilerContext()));
			}

			/// <summary>
			/// Create a program from this Program.
			/// </summary>
			/// <param name="cctx"></param>
			/// <returns></returns>
			public ShaderProgram Create(ShaderCompilerContext cctx)
			{
				if (String.IsNullOrEmpty(Id))
					throw new InvalidOperationException("invalid program identifier");
				if (cctx == null)
					throw new ArgumentNullException("cctx");

				ShaderProgram shaderProgram = new ShaderProgram(Id, cctx);
				shaderProgram.CompilationParams = cctx;

				// Attach required objects
				foreach (Object shaderProgramObject in Objects) {
					ShaderObject shaderObject = new ShaderObject(shaderProgramObject.Stage);

					// Load source
					shaderObject.LoadSource(shaderProgramObject.Path);
					// Attach object
					shaderProgram.AttachShader(shaderObject);
				}

				// Register attributes semantic
				foreach (Attribute attribute in Attributes)
					shaderProgram.SetAttributeSemantic(attribute.Name, attribute.Semantic);
				// Register uniforms semantic
				foreach (Uniform uniform in Uniforms)
					shaderProgram.SetUniformSemantic(uniform.Name, uniform.Semantic);

				return (shaderProgram);
			}

			internal ShaderCompilerContext GetCompilerContext()
			{
				ShaderCompilerContext shaderCompilerParams = new ShaderCompilerContext();

				foreach (Object shaderProgramObject in Objects) {
					// Take into account required preprocessor symbols
					foreach (string preprocessorSymbol in shaderProgramObject.Symbols)
						shaderCompilerParams.Defines.Add(preprocessorSymbol);
				}

				return (shaderCompilerParams);
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="cctx"></param>
			/// <returns></returns>
			internal string GetHashInfo(ShaderCompilerContext cctx)
			{
				StringBuilder hashMessage = new StringBuilder();

				// Take into account the shader program name
				hashMessage.Append(Id);

				// Objects hash
				if (Objects != null) {
					foreach (Object programObject in Objects)
						hashMessage.Append(programObject);
				}

				// Compilation parameters (common to all shaders?)
				hashMessage.Append(cctx.ShaderVersion);

				if (cctx.Includes != null) {
					foreach (string includePath in cctx.Includes)
						hashMessage.Append(includePath);
				}

				hashMessage.Append(cctx.FeedbackVaryingsFormat);

				return (hashMessage.ToString());
			}
		}

		/// <summary>
		/// List of <see cref="Program"/> instances describing the available shader programs in library.
		/// </summary>
		[XmlArray("Programs")]
		[XmlArrayItem("Program")]
		public readonly List<Program> Programs = new List<Program>();

		/// <summary>
		/// Get the definition of a program.
		/// </summary>
		/// <param name="programId">
		/// A <see cref="String"/> that specifies the program identifier.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Program"/> describing the program identified with <paramref name="programId"/>.
		/// </returns>
		public Program GetProgram(string programId)
		{
			if (programId == null)
				throw new ArgumentNullException("programId");

			return (Programs.Find(delegate(Program item) { return (item.Id == programId); }));
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Load a ShadersLibrary from a Stream.
		/// </summary>
		/// <param name="libraryStream">
		/// A <see cref="Stream"/> that reads a <see cref="ShadersLibrary"/> information.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ShadersLibrary"/> read from <paramref name="libraryStream"/>.
		/// </returns>
		private static ShadersLibrary Load(Stream libraryStream)
		{
			if (libraryStream == null)
				throw new ArgumentNullException("libraryStream");

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(ShadersLibrary));

			return ((ShadersLibrary)xmlSerializer.Deserialize(libraryStream));
		}

		/// <summary>
		/// Load a ShadersLibrary from an embedded resource.
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="String"/> that specify the embedded resource path.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ShadersLibrary"/> read from <paramref name="resourcePath"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="resourcePath"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if no embedded resource can be found.
		/// </exception>
		private static ShadersLibrary Load(string resourcePath)
		{
			if (resourcePath == null)
				throw new ArgumentNullException("resourcePath");

			Assembly[] resourceAssemblies = new Assembly[] {
				Assembly.GetExecutingAssembly(),
				Assembly.GetCallingAssembly(),
				Assembly.GetEntryAssembly()
			};
			Stream resourceStream = null;

			try {
				for (int i = 0; i < resourceAssemblies.Length && resourceStream == null; i++) {
					if (resourceAssemblies[i] == null)
						continue;
					resourceStream = resourceAssemblies[i].GetManifestResourceStream(resourcePath);
				}

				if (resourceStream == null)
					throw new ArgumentException("resource path not found", "resourcePath");

				return (Load(resourceStream));
			} finally {
				if (resourceStream != null)
					resourceStream.Dispose();
			}
		}

		#endregion

		#region Singleton

		/// <summary>
		/// Get the only instance of <see cref="ShadersLibrary"/>.
		/// </summary>
		public static ShadersLibrary Instance
		{
			get
			{
				return (_ShadersLibrary);
			}
		}

		/// <summary>
		/// Merge a ShaderLibrary loaded from an embedded resource with <see cref="Instance"/>.
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="String"/> that specify the embedded resource path.
		/// </param>
		public static void Merge(string resourcePath)
		{
			ShadersLibrary embeddedShadersLibrary = Load(resourcePath);

			// Merge information
			_ShadersLibrary.Includes.AddRange(embeddedShadersLibrary.Includes);
			_ShadersLibrary.Objects.AddRange(embeddedShadersLibrary.Objects);
			_ShadersLibrary.Programs.AddRange(embeddedShadersLibrary.Programs);
		}

		/// <summary>
		/// The reference instance of <see cref="ShadersLibrary"/>.
		/// </summary>
		private static readonly ShadersLibrary _ShadersLibrary = new ShadersLibrary();

		#endregion

		#region Program Cache

		/// <summary>
		/// 
		/// </summary>
		/// <param name="programId"></param>
		/// <returns></returns>
		public ShaderProgram CreateProgram(string programId)
		{
			return (CreateProgram(programId, null));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="programId"></param>
		/// <returns></returns>
		public ShaderProgram CreateProgram(string programId, ShaderCompilerContext cctx)
		{
			if (String.IsNullOrEmpty(programId))
				throw new ArgumentException("invalid program identifier", "programId");

			Program libraryProgram = GetProgram(programId);
			if (libraryProgram == null)
				throw new ArgumentException("no program with such identifier", "programId");

			ShaderCompilerContext compilerContext = cctx ?? libraryProgram.GetCompilerContext();

			// Try to find cached program
			ShaderProgram shaderProgram;
			string cacheHash = ComputeLibraryHash(libraryProgram, compilerContext);

			if (_ProgramCache.TryGetValue(cacheHash, out shaderProgram))
				return (shaderProgram);

			// Create the program instance
			shaderProgram = libraryProgram.Create(compilerContext);

			if (_ProgramCache.ContainsKey(cacheHash) == false)
				_ProgramCache.Add(cacheHash, shaderProgram);

			return (shaderProgram);
		}

		/// <summary>
		/// Determine an unique identifier that specify the linked shader program.
		/// </summary>
		/// <param name="libraryId">
		/// A <see cref="String"/> that identifies the shader object in library.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> determining the compiler parameteres.
		/// </param>
		/// <returns>
		/// It returns a string that identify the a shader program classified with <paramref name="libraryId"/> by
		/// specifying <paramref name="cctx"/> as compiled parameters.
		/// </returns>
		private static string ComputeLibraryHash(Program libraryProgram, ShaderCompilerContext cctx)
		{
			if (libraryProgram == null)
				throw new ArgumentNullException("libraryProgram");

			byte[] hashBytes;

			using (System.Security.Cryptography.HashAlgorithm hash = System.Security.Cryptography.HashAlgorithm.Create("SHA256")) {
				hashBytes = hash.ComputeHash(Encoding.ASCII.GetBytes(libraryProgram.GetHashInfo(cctx)));
			}

			// ConvertItemType has to string
			return (Convert.ToBase64String(hashBytes));
		}

		/// <summary>
		/// Program cache, indexed by compilation hash.
		/// </summary>
		private readonly Dictionary<string, ShaderProgram> _ProgramCache = new Dictionary<string, ShaderProgram>();

		#endregion
	}
}
