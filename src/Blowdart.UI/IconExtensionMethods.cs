// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;

namespace Blowdart.UI
{
	public static class IconExtensionMethods
	{
		public static string ToCssCase(this OpenIconicIcons icon)
		{
			return string.Concat(icon.ToString().Select((x, i) => i > 0 && char.IsUpper(x) ? $"-{x}" : $"{x}")).ToLowerInvariant();
		}
	}
}