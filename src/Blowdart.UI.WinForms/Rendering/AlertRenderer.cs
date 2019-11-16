﻿// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Windows.Forms;
using Blowdart.UI.Instructions;

namespace Blowdart.UI.WinForms.Rendering
{
	internal sealed class AlertRenderer :
		IRenderer<BeginAlertInstruction, Panel>,
		IRenderer<EndAlertInstruction, Panel>
	{
		public void Render(Panel p, BeginAlertInstruction instruction)
		{
			
		}

		public void Render(Panel p, EndAlertInstruction instruction)
		{
			
		}
	}
}