using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SampleXamarinForm.ViewModels
{
	public class SampleMVVMPageViewModel : BindableObject
	{
		public SampleMVVMPageViewModel()
		{
            IncreaseCount = new Command(OnIncrease);
		}

        private void OnIncrease(object obj)
        {
            count++;
            CountDisplay = $"You clicked {count} time";
        }

        public ICommand IncreaseCount { get; }

        int count = 0;
        private string countDisplay = "Click Me";
        public string CountDisplay
        {
            get { return countDisplay; }
            set
            {
                if (value == countDisplay)
                    return;
                countDisplay = value;
                OnPropertyChanged();
            }
        }
    }
}

