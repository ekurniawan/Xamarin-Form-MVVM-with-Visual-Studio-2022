using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SampleXamarinForm.Models;
using Xamarin.Forms;

namespace SampleXamarinForm
{	
	public partial class SideMenuPage : ContentPage
	{
		public ListView ListView;
		public SideMenuPage ()
		{
			InitializeComponent();
			ListView = lvMenuSide;
			BindingContext = new SideMenuPageViewModel();
		}
	}

    class SideMenuPageViewModel : INotifyPropertyChanged
    {
		public ObservableCollection<MyMenuItem> MenuItems { get; set; }

		public SideMenuPageViewModel()
		{
			MenuItems = new ObservableCollection<MyMenuItem>
			{
				new MyMenuItem{Id=0,Title="Main Page",TargetType=typeof(MainPage),ImageIcon="search.png"},
                new MyMenuItem{Id=1,Title="List With Image",TargetType=typeof(SampleListObject),ImageIcon="search.png"},
                new MyMenuItem{Id=2,Title="Custom List",TargetType=typeof(SampleCustomList),ImageIcon="search.png"},
                new MyMenuItem{Id=3,Title="Tab Paged",TargetType=typeof(MyTabbedPage),ImageIcon="search.png"},
            };
		}

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

