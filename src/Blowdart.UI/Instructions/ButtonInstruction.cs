// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Blowdart.UI.Instructions
{
    public class ButtonInstruction : RenderInstruction
    {
        public Ui Ui { get; }
        public Value128 Id { get; }
        public ElementContext Type { get; }
        public string Text { get; }

        public ButtonInstruction(Ui ui, Value128 id, ElementContext type, string text)
        {
            Ui = ui;
            Id = id;
            Type = type;
            Text = text;
        }

        public override string DebuggerDisplay => $"Button: {Text}";
    }
}
