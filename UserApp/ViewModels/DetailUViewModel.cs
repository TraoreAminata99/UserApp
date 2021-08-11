using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using UserApp.Models;

namespace UserApp.ViewModels
{
   public class DetailUViewModel : BaseViewModels
    {

        public Users User
        {
            get => Get<Users>();
            set => Set(value);
        }
        public DetailUViewModel(Users user)
        {
            User = new Users();
            OneUser(user.Id);
        }
        public async void OneUser(int id)
        {
            string ApiUrl = "https://jsonplaceholder.typicode.com/users/" + id.ToString();
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<Users>(reponse);
            User = contente;
        }
    }
}
