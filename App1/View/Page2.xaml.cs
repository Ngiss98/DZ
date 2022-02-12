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
    public partial class Page2 : ContentPage
    {
        Page2VM viewModel;
        public Page2()
        {
            InitializeComponent();
            viewModel = new Page2VM();
            
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var resultJson = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/users");

            var resultUsers = JsonConvert.DeserializeObject<Users[]>(resultJson);

            Users.ItemsSource = resultUsers;
        }
    }
}