using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using App1.View;

namespace App1.ViewModel
{
    public class MainPageViewModel : BindableObject
    {
        public ICommand SetClick => new Command(GetClick);
        public int click = 0;
        private string lbl1 = "ТестДо: ";

        public void GetClick()
        {
            click++;
            FrameText = $"Тест: {click}";
        }

        public string FrameText
        {
            get => lbl1;
            set
            {
                if (lbl1 != value)
                {
                    lbl1 = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Push => new Command(OnPage2);
        private void OnPage2()
        {
            App.Current.MainPage.Navigation.PushAsync(new Page2());
        }

        private void OnPage3()
        {
            App.Current.MainPage.Navigation.PushAsync(new Page3());
        }

    }
}