using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleXamarinForm
{	
	public partial class GridLayoutSample : ContentPage
	{	
		public GridLayoutSample ()
		{
			InitializeComponent ();
		}

        void btnSubmit_Clicked(System.Object sender, System.EventArgs e)
        {
			lblNama.Text = $"Nama anda : {entryNama.Text}";
        }
    }
}

