// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Blowdart.UI.Instructions
{
    public class HeaderInstruction : RenderInstruction
    {
        public string Text { get; }
        public int Level { get; }

        public HeaderInstruction(int level, string text)
        {
            Level = level;
            Text = text;
        }

        public override string DebuggerDisplay => $"h{Level}";
    }
}