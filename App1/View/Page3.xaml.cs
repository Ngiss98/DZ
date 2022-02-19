using App1.Models;
using App1.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        Page3VM viewModel;
        public Page3()
        {
            InitializeComponent();
            viewModel = new Page3VM();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var resultJson = await httpClient.GetStringAsync("https://localhost:44317/home/GetList");

            var resultUsers = JsonConvert.DeserializeObject<Names[]>(resultJson);

            Names.ItemsSource = resultUsers;
        }
    }
}