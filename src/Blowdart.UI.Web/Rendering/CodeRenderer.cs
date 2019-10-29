// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq;
using Blowdart.UI.Instructions;
using Blowdart.UI.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Blowdart.UI.Web.Rendering
{
	internal sealed class CodeRenderer : IWebRenderer<CodeInstruction>
	{
		public void Render(RenderTreeBuilder b, CodeInstruction code)
		{
			if (code.Block)
			{
				b.OpenElement(b.NextSequence(), Strings.Pre);
				b.AddAttribute(b.NextSequence(), Strings.Class, ".pre-scrollable");
			}
			b.OpenElement(b.NextSequence(), Strings.Code);
			b.AddContent(b.NextSequence(), EscapeAngleBrackets(code.Value));
			b.CloseElement();
			if(code.Block)
				b.CloseElement();
		}

		private static readonly char[] TrimChars = Environment.NewLine.Concat(new[] {' '}).ToArray();

		private static MarkupString EscapeAngleBrackets(string codeValue)
		{
			var formatted = codeValue
				.Replace("<", "&lt;")
				.Replace(">", "&gt;")
				.Trim(TrimChars)
				.TabsToSpaces(4);

			return new MarkupString(formatted);
		}

		public void Render(RenderTreeBuilder b, RenderInstruction instruction)
		{
			Render(b, instruction as CodeInstruction);
		}
	}
}