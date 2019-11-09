﻿// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Windows.Forms;
using Blowdart.UI.Instructions;

namespace Blowdart.UI.WinForms.Rendering
{
	internal sealed class InlineIconRenderer : IFormRenderer
	{
		public void Render(RenderInstruction instruction, Panel panel)
		{
			var icon = (InlineIconInstruction) instruction;

			foreach (var control in panel.Controls)
			{
				if (control is ContextMenuStrip strip)
				{
					foreach (var item in strip.Items)
					{
						
					}
				}
			}
		}
	}
}