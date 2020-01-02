// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Blowdart.UI.Instructions;
using Blowdart.UI.Web.Core.Extensions;
using Microsoft.AspNetCore.Components.Rendering;

namespace Blowdart.UI.Web.Core.Rendering
{
	internal sealed class CheckBoxRenderer : IRenderer<CheckBoxInstruction, RenderTreeBuilder>
	{
		private readonly ImGui _imGui;

		public CheckBoxRenderer(ImGui imGui)
		{
			_imGui = imGui;
		}

		public void Render(RenderTreeBuilder b, CheckBoxInstruction checkBox)
		{
			RenderButton(b, checkBox);
		}

		private void RenderButton(RenderTreeBuilder b, CheckBoxInstruction checkBox)
		{
			b.OpenElement(HtmlElements.Div);
			{
				b.AddAttribute(HtmlAttributes.Class, "form-inline");

				switch (checkBox.Alignment)
				{
					case ElementAlignment.Left:
						RenderInput();
						RenderLabel();
						break;
					case ElementAlignment.Right:
						RenderLabel();
						RenderInput();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}

                b.CloseElement();
			}
			
			void RenderInput()
			{
				b.OpenElement(HtmlElements.Input);
				{
					b.AddAttribute(HtmlAttributes.Class, "form-check-input");
					b.AddAttribute(HtmlAttributes.Type, HtmlInputTypes.Checkbox);
					b.AddAttribute(HtmlAttributes.Value, checkBox.Value);
					b.AddAttribute(HtmlAttributes.Id, checkBox.Id);
					b.AddAttribute(HtmlAttributes.Checked, checkBox.Value);

					if (checkBox.Disabled)
						b.AddAttribute(HtmlAttributes.Disabled, true);
					else
						b.AddAttribute(DomEvents.OnClick, _imGui.OnClickCallback(checkBox.Id));

					b.CloseElement();
				}
			}

			void RenderLabel()
			{
				if (!string.IsNullOrWhiteSpace(checkBox.Text))
				{
					b.OpenElement(HtmlElements.Label);
					{
						b.AddAttribute(HtmlAttributes.Class, "form-check-label");
						b.AddAttribute(HtmlAttributes.For, checkBox.Id);
						b.AddContent(checkBox.Text);

						b.CloseElement();
					}
				}
			}
		}
	}
}