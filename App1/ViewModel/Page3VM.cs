using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using App1.Models;
using App1.View;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace App1.ViewModel
{
    class Page3VM
    {
        public ICommand PushList => new Command(GetSomJson);

        async void GetSomJson()
        {
            var httpClient = new HttpClient();
            var resultJson = await httpClient.GetStringAsync("https://localhost:44317/home/GetList");

            var resultUsers = JsonConvert.DeserializeObject<Names[]>(resultJson);

            Names.ItemsSource = resultUsers;
        }
    }
}
