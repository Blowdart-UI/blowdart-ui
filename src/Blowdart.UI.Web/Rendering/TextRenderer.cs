// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Net;
using Blowdart.UI.Instructions;
using Microsoft.AspNetCore.Components.Rendering;

namespace Blowdart.UI.Web.Rendering
{
    internal sealed class TextRenderer : IWebRenderer<TextInstruction>
    {
        public void Render(RenderTreeBuilder b, TextInstruction text)
        {
            b.OpenElement(b.NextSequence(), Strings.Paragraph);
            b.AddContent(b.NextSequence(), text.Value);
            b.CloseElement();
        }

        public void Render(RenderTreeBuilder b, RenderInstruction instruction)
        {
            Render(b, instruction as TextInstruction);
        }
    }
}
