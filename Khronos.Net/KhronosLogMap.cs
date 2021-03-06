﻿
// Copyright (C) 2017 Luca Piccioni
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace Khronos
{
	/// <summary>
	/// Contains metedata information for Khronos API commands.
	/// </summary>
	[XmlType("KhronosLogMap")]
	public sealed class KhronosLogMap
	{
		#region XML Schema

		/// <summary>
		/// Commands.
		/// </summary>
		[XmlElement("command")]
		public Command[] Commands
		{
			get { return (_Commands.Values.ToArray()); }
			set
			{
				_Commands.Clear();

				if (value != null) {
					foreach (Command command in value)
						_Commands[command.Name] = command;
				}
			}
		}

		/// <summary>
		/// Commands mapped for documentation.
		/// </summary>
		private readonly Dictionary<string, Command> _Commands = new Dictionary<string, Command>();

		/// <summary>
		/// Command element.
		/// </summary>
		[XmlType("command")]
		public sealed class Command
		{
			/// <summary>
			/// Command name.
			/// </summary>
			[XmlAttribute("name")]
			public string Name;

			/// <summary>
			/// Command parameters flags.
			/// </summary>
			[XmlElement("param")]
			public CommandParam[] Params;
		}

		/// <summary>
		/// Command parameter element.
		/// </summary>
		[XmlType("command_param")]
		public sealed class CommandParam
		{
			[XmlAttribute("name")]
			public string Name;

			[XmlAttribute("flags")]
			[DefaultValue(KhronosLogCommandParameterFlags.None)]
			public KhronosLogCommandParameterFlags Flags = KhronosLogCommandParameterFlags.None;
		}

		#endregion

		#region Load/Save

		/// <summary>
		/// Load a <see cref="KhronosLogMap"/> from an embedded resource.
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="String"/> that specifies the path of the Khronos API log map resource.
		/// </param>
		/// <returns>
		/// It returns the <see cref="KhronosLogMap"/> loaded from <paramref name="resourcePath"/>.
		/// </returns>
		public static KhronosLogMap Load(string resourcePath)
		{
			if (resourcePath == null)
				throw new ArgumentNullException("resourcePath");

			using (Stream xmlStream = Assembly.GetCallingAssembly().GetManifestResourceStream(resourcePath)) {
				return ((KhronosLogMap)_XmlSerializer.Deserialize(xmlStream));
			}
		}

		/// <summary>
		/// Load a <see cref="KhronosLogMap"/> from an embedded resource.
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="String"/> that specifies the path of the Khronos API log map resource.
		/// </param>
		/// <param name="logMap">
		/// The <see cref="KhronosLogMap"/> to be serialized into <paramref name="resourcePath"/>.
		/// </param>
		public static void Save(string resourcePath, KhronosLogMap logMap)
		{
			if (resourcePath == null)
				throw new ArgumentNullException("resourcePath");
			if (logMap == null)
				throw new ArgumentNullException("logMap");

			using (FileStream fs = new FileStream(resourcePath, FileMode.Create, FileAccess.Write)) {
				_XmlSerializer.Serialize(fs, logMap);
			}
		}

		/// <summary>
		/// XML serializer used by <see cref="Load"/> for loading log maps.
		/// </summary>
		private static XmlSerializer _XmlSerializer = new XmlSerializer(typeof(KhronosLogMap));

		#endregion

		#region Information Query

		public string GetCommandParameterName(string commandName, int paramIndex)
		{
			CommandParam commandParam = GetCommandParam(commandName, paramIndex);
			if (commandParam == null)
				return (String.Format("param{0}", paramIndex));

			return (commandParam.Name);
		}

		public KhronosLogCommandParameterFlags GetCommandParameterFlag(string commandName, int paramIndex)
		{
			CommandParam commandParam = GetCommandParam(commandName, paramIndex);
			if (commandParam == null)
				return (KhronosLogCommandParameterFlags.None);

			return (commandParam.Flags);
		}

		private Command GetCommand(string commandName)
		{
			if (commandName == null)
				throw new ArgumentNullException("commandName");

			Command command;

			if (_Commands.TryGetValue(commandName, out command))
				return (command);

			return (null);
		}

		private CommandParam GetCommandParam(string commandName, int paramIndex)
		{
			if (paramIndex < 0)
				throw new ArgumentOutOfRangeException("paramIndex", paramIndex, "it cannot be negative");

			Command command = GetCommand(commandName);
			if (command == null)
				return (null);

			if (paramIndex >= command.Params.Length)
				throw new ArgumentOutOfRangeException("paramIndex", paramIndex, "greater than the number of parameters");

			 return (command.Params[paramIndex]);
		}

		#endregion
	}
}