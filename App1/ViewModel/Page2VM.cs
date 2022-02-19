using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using App1.Models;
using App1.View;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace App1.ViewModel
{
    public class Page2VM 
    {
        public ICommand Push => new Command(GetSomJson);

        async void GetSomJson()
        {
            var httpClient = new HttpClient();
            var resultJson = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/users");

            var resultUsers = JsonConvert.DeserializeObject<Users[]>(resultJson);

            Users.ItemsSource = resultUsers;
        }
    }
}
