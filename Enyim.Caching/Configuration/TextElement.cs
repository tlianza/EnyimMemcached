using System;
using System.ComponentModel;
using System.Configuration;
using System.Collections.Generic;
using Enyim.Caching.Memcached;
using Enyim.Reflection;
using System.Xml.Linq;

namespace Enyim.Caching.Configuration
{
	/// <summary>
	/// CDATA config element
	/// </summary>
	public sealed class TextElement : ConfigurationElement
	{
		public string Content { get; set; }

		protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey)
		{
			this.Content = reader.ReadElementContentAsString();
		}
	}
}

#region [ License information          ]
/* ************************************************************
 * 
 *    Copyright (c) 2010 Attila Kisk�, enyim.com
 *    
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *    
 *        http://www.apache.org/licenses/LICENSE-2.0
 *    
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *    
 * ************************************************************/
#endregion
