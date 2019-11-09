﻿// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Windows.Forms;
using Blowdart.UI.Instructions;

namespace Blowdart.UI.WinForms.Rendering
{
	internal sealed class BeginMenuRenderer : IFormRenderer
	{
		public void Render(RenderInstruction instruction, Panel panel)
		{
			var beginMenu = (BeginMenuInstruction) instruction;

			var menu = new ToolStrip();
			menu.Dock = DockStyle.Top;

			panel.Controls.Add(menu);
		}
	}
}