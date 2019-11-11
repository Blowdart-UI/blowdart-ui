// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Blowdart.UI;
using Blowdart.UI.Patterns;

namespace Demo.Examples.Pages
{
	public class ElementsPage
	{
		#region Elements Page

		private static bool _alertsTabOpen = true;
		private static bool _inputControlsTabOpen;
		private static bool _patternsTabOpen;

		public static void Index(Ui ui)
		{
			ui.BeginTabList();

			if (ui.Tab("Alerts", ref _alertsTabOpen))
			{
				_inputControlsTabOpen = false;
				_patternsTabOpen = false;
			}

			if (ui.Tab("Input Controls", ref _inputControlsTabOpen))
			{
				_alertsTabOpen = false;
				_patternsTabOpen = false;
			}

			if (ui.Tab("Patterns", ref _patternsTabOpen))
			{
				_alertsTabOpen = false;
				_inputControlsTabOpen = false;
			}

			ui.EndTabList();

			ui.BeginTabContent();
			ui.TabContent("Alerts", _alertsTabOpen, AlertsTab);
			ui.TabContent("Input Controls", _inputControlsTabOpen, InputControlsTab);
			ui.TabContent("Patterns", _patternsTabOpen, PatternsTab);
			ui.EndTabContent();
		}

		private static bool _checked;
		private static int _slider;
		private static bool _radioButton;
		
		public static void InputControlsTab(Ui ui)
		{
			ui.NextLine();
			ui.Header(3, "Input Controls");
			ui.Separator();

			ui.Push(ElementAlignment.Right);
			if (ui.CheckBox(ref _checked, "Check me"))
			{
				ui.Log($"checked the box: ({_checked})");
			}

			ui.NextLine();

			ui.Push(InputActivation.Continuous);
			if (ui.Slider(ref _slider, "Slide me"))
			{
				ui.Log($"changed slider: ({_slider})");
			}

			ui.NextLine();

			if (ui.RadioButton(ref _radioButton, "Press me"))
			{
				ui.Log($"changed radio button: ({_radioButton})");
			}

			ui.NextLine();

			ui.Push(ElementContext.Dark);
			ui.Push(ElementDecorator.SpinnerBorder);
			if (ui.Button())
			{
				ui.ShowModal("Example");
				ui.Log($"clicked the first button");
			}

			ui.Push(ElementContext.Dark);
			ui.Push(ElementDecorator.SpinnerBorder);
			ui.Push(ElementAlignment.Right);
			if (ui.Button("Click me "))
			{
				ui.ShowModal("Example");
				ui.Log($"clicked the second button");
			}

			ui.BeginModal("Example");
			ui.Text("Hello from a modal!");
			ui.EndModal();

			#region Code

			ui.SampleCode(@"
ui.NextLine();
ui.Header(3, ""Input Controls"");
ui.Separator();

ui.Push(ElementAlignment.Right);
if (ui.CheckBox(ref _checked, ""Check me""))
{
	ui.Log($""checked the box: ({_checked})"");
}

ui.NextLine();

ui.Push(InputActivation.Continuous);
if (ui.Slider(ref _slider, ""Slide me""))
{
	ui.Log($""changed slider: ({_slider})"");
}

ui.NextLine();

if (ui.RadioButton(ref _radioButton, ""Press me""))
{
	ui.Log($""changed radio button: ({_radioButton})"");
}

ui.NextLine();

ui.Push(ElementContext.Dark);
ui.Push(ElementDecorator.SpinnerBorder);
if (ui.Button())
{
	ui.ShowModal(""Example"");
	ui.Log($""clicked the first button"");
}

ui.Push(ElementContext.Dark);
ui.Push(ElementDecorator.SpinnerBorder);
ui.Push(ElementAlignment.Right);
if (ui.Button(""Click me ""))
{
	ui.ShowModal(""Example"");
	ui.Log($""clicked the second button"");
}

ui.BeginModal(""Example"");
ui.Text(""Hello from a modal!"");
ui.EndModal();
");
			#endregion
		}

		public static void AlertsTab(Ui ui)
		{
			ui.NextLine();
			ui.Header(3, "Alerts");
			ui.Separator();

			ui.Push(ElementContext.Primary);
			ui.Alert("This is a primary alertócheck it out!");

			ui.Push(ElementContext.Secondary);
			ui.Alert("This is a secondary alertócheck it out!");

			ui.Push(ElementContext.Success);
			ui.Alert("This is a success alertócheck it out!");

			ui.Push(ElementContext.Danger);
			ui.Alert("This is a danger alertócheck it out!");

			ui.Push(ElementContext.Warning);
			ui.Alert("This is a warning alertócheck it out!");

			ui.Push(ElementContext.Info);
			ui.Alert("This is an info alertócheck it out!");

			ui.Push(ElementContext.Dark);
			ui.Alert("This is a dark alertócheck it out!");

			ui.Push(ElementContext.Light);
			ui.Alert("This is a light alertócheck it out!");

			#region Code

			ui.SampleCode(@"
ui.Header(3, ""Alerts"");
ui.Separator();

ui.Push(ElementContext.Primary);
ui.Alert(""This is a primary alertócheck it out!"");

ui.Push(ElementContext.Secondary);
ui.Alert(""This is a secondary alertócheck it out!"");

ui.Push(ElementContext.Success);
ui.Alert(""This is a success alertócheck it out!"");

ui.Push(ElementContext.Danger);
ui.Alert(""This is a danger alertócheck it out!"");

ui.Push(ElementContext.Warning);
ui.Alert(""This is a warning alertócheck it out!"");

ui.Push(ElementContext.Info);
ui.Alert(""This is an info alertócheck it out!"");

ui.Push(ElementContext.Dark);
ui.Alert(""This is a dark alertócheck it out!"");

ui.Push(ElementContext.Light);
ui.Alert(""This is a light alertócheck it out!"");");
			#endregion
		}

		public static void PatternsTab(Ui ui)
		{
			ui.NextLine();
			ui.Header(3, "Patterns");
			ui.Separator();

			var avatars = new List<Avatar>
			{
				new Avatar
				{
					FirstName = "Chuck",
					LastName = "Norris",
					ImageUrl = "https://i.pravatar.cc/64?u=chuck@norris.com"
				},
				new Avatar
				{
					FirstName = "Bob",
					LastName = "Loblaw",
					ImageUrl = "https://i.pravatar.cc/64?u=bob@loblaw.com"
				}
			};

			ui.AvatarList(avatars);
		}

		#endregion
	}
}