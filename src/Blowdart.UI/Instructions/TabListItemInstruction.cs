// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Blowdart.UI.Instructions
{
	public class TabListItemInstruction : RenderInstruction
	{
		public Ui Ui { get; }
		public Value128 Id { get; }
		public string Text { get; }
		public bool Active { get; }

		public TabListItemInstruction(Ui ui, Value128 id, string text, bool active)
		{
			Ui = ui;
			Id = id;
			Text = text;
			Active = active;
		}

		public override string DebuggerDisplay => $"Tab: {Text}";
	}
}