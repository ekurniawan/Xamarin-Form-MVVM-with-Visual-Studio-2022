using System;
using System.Collections.Generic;
using SampleXamarinForm.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SampleXamarinForm
{
    [QueryProperty("EmployeeID","employeeid")]
	public partial class SampleCustomList : ContentPage
	{
        public string EmployeeID {
            set {
                _employeeId = Uri.UnescapeDataString(value);
            }
        }

        public SampleCustomList()
        {
            InitializeComponent();

            List<Employee> lstEmployee = new List<Employee>
            {
                new Employee{Name="Erick Kurniawan",Address="Redmond WA",
                    Picture="monkey.png",Phone="999888",Email="erick@gmail.com"},
                new Employee{Name="John Doe",Address="New York City",
                    Picture="monkey.png",Phone="999888",Email="john@gmail.com"},
                new Employee{Name="Scott Guthrie",Address="Jakarta",
                    Picture="monkey.png",Phone="999888",Email="scott@gmail.com"}
            };
            lvEmployee.ItemsSource = lstEmployee;

            lvEmployee.ItemTapped += LvEmployee_ItemTapped;
            btnCek.Clicked += BtnCek_Clicked;
            btnCekPreference.Clicked += BtnCekPreference_Clicked;
        }

        private string _employeeId="";
		public SampleCustomList(string EmployeeId)
		{
			InitializeComponent();

            _employeeId = EmployeeId;
            List<Employee> lstEmployee = new List<Employee>
            {
                new Employee{Name="Erick Kurniawan",Address="Redmond WA",
                    Picture="monkey.png",Phone="999888",Email="erick@gmail.com"},
                new Employee{Name="John Doe",Address="New York City",
                    Picture="monkey.png",Phone="999888",Email="john@gmail.com"},
                new Employee{Name="Scott Guthrie",Address="Jakarta",
                    Picture="monkey.png",Phone="999888",Email="scott@gmail.com"}
            };
            lvEmployee.ItemsSource = lstEmployee;

            lvEmployee.ItemTapped += LvEmployee_ItemTapped;
            btnCek.Clicked += BtnCek_Clicked;
            btnCekPreference.Clicked += BtnCekPreference_Clicked;
            
        }

        private async void BtnCekPreference_Clicked(object sender, EventArgs e)
        {
            if(Preferences.ContainsKey("bahasa"))
            {
                var bahasa = Preferences.Get("bahasa", String.Empty);
                await DisplayAlert("Bahasa", $"Bahasa yg digunakan: {bahasa}", "OK");
            }
            else
            {
                await DisplayAlert("Info", "Object Preferences belum ada", "OK");
            }


            await DisplayAlert("Global", $"Data Global: {Global.Instance.myData}",
                "OK");
        }

        private async void BtnCek_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Employee ID", $"Employee ID: {_employeeId}", "OK");
        }

        private async void LvEmployee_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var emp = (Employee)e.Item;
            await DisplayAlert("Data Employee",
                $"Name: {emp.Name} Phone: {emp.Phone} Email: {emp.Email}", "OK");

        }
    }
}

