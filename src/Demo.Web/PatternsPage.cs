﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blowdart.UI;
using Blowdart.UI.Patterns;
using Demo.Web.Patterns;
using Microsoft.AspNetCore.Components.Rendering;

namespace Demo.Web
{
	public class PatternsPage
	{
		public static void Index(Ui ui)
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

            ui.Pattern<AvatarListInstruction, AvatarListRenderer, RenderTreeBuilder>(avatars, 16);
		}
	}
}
