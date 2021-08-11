using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using UserApp.Models;

namespace UserApp.ViewModels
{
   public class ListUViewModel : BaseViewModels
    {
        public ObservableCollection<Users> AlUser
        {
            get => Get<ObservableCollection<Users>>();
            set => Set(value);
        }

        public ListUViewModel()
        {
            AlUser = new ObservableCollection<Users>();
            GetUsers();
        }

        public async void GetUsers()
        {
            string WebAPIUrl = "http://jsonplaceholder.typicode.com/users";
            var uri = new Uri(WebAPIUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var content = JsonConvert.DeserializeObject<ObservableCollection<Users>>(reponse);
            AlUser = content;

        }
    }
}
