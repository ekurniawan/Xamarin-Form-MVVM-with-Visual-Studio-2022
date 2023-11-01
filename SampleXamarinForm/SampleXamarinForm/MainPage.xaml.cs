using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SampleXamarinForm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnListObject.Clicked += BtnListObject_Clicked;
            tbAdd.Clicked += TbAdd_Clicked;
            btnCustomList.Clicked += BtnCustomList_Clicked;

            btnSetPreference.Clicked += BtnSetPreference_Clicked;
            btnClearPreference.Clicked += BtnClearPreference_Clicked;
            btnSetGlobal.Clicked += BtnSetGlobal_Clicked;
        }

        private void BtnSetGlobal_Clicked(object sender, EventArgs e)
        {
            Global.Instance.myData = "Erick Kurniawan";
        }

        private async void BtnClearPreference_Clicked(object sender, EventArgs e)
        {
            Preferences.Remove("bahasa");
            Preferences.Clear();
            await DisplayAlert("Keterangan", "Clear Preferences", "OK");
        }

        private async void BtnSetPreference_Clicked(object sender, EventArgs e)
        {
            if(!Preferences.ContainsKey("bahasa"))
            {
                Preferences.Set("bahasa", entryBahasa.Text);
                await DisplayAlert("Info", $"Preference berhasil dibuat", "OK");
            }    
        }

        private async void BtnCustomList_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(SampleCustomList)}?employeeid={entryEmployeeID.Text}");
        }

        private async void TbAdd_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Keterangan", "Add Data", "OK");
        }

        private async void BtnListObject_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SampleListObject));
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
        }
    }
}

