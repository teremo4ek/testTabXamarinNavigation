using System;
using System.Collections.Generic;

using tabtest.Pages;

using Xamarin.Forms;

namespace tabtest
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

	  private void Button_OnClicked(object sender, EventArgs e)
	  {
	    //throw new NotImplementedException();
	    this.Navigation.PushAsync(new SecondPage());
	  }
	}
}

