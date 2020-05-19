using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MultiBindingTest.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }

        public ICommand OpenWebCommand { get; }

        #region Value1
        private bool value1;
        public bool Value1
        {
            get { return value1; }
            set
            {
                value1 = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region Value2
        private bool value2;
        public bool Value2
        {
            get { return value2; }
            set
            {
                value2 = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region Value3
        private bool value3;
        public bool Value3
        {
            get { return value3; }
            set
            {
                value3 = value;
                OnPropertyChanged();
            }
        }
        #endregion

    }
}