using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ATXBSAPP.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "¿Quiénes somos?";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://atx.mx"));
        }

        public ICommand OpenWebCommand { get; }
    }
}