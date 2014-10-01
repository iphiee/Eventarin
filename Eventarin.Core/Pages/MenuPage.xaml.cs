﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Eventarin.Core.ViewModels;

namespace Eventarin.Core.Pages
{	
	public partial class MenuPage : BaseContentPage
	{	
		public MenuPage () : base()
		{
			InitializeComponent ();
			BindingContext = App.SimpleIoC.Resolve<MenuViewModel>();
			IncludeActivityIndicator = false;
		}
	}
}

