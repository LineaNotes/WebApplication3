﻿using System.Collections.Generic;
using Microsoft.AspNet.Mvc.Rendering;

namespace WebApplication3.ViewModels.Manage
{
	public class ConfigureTwoFactorViewModel
	{
		public string SelectedProvider { get; set; }

		public ICollection<SelectListItem> Providers { get; set; }
	}
}