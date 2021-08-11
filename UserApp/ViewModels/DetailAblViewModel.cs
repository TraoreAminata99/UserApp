using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using UserApp.Models;

namespace UserApp.ViewModels
{
   public class DetailAblViewModel : BaseViewModels
    {
        public Ablum Ablums
        {
            get => Get<Ablum>();
            set => Set(value);
        }
        public DetailAblViewModel(Ablum ablums)
        {
            Ablums = new Ablum();
            OneAblum(ablums.Id);
        }
        public async void OneAblum(int id)
        {
            string ApiUrl = "https://jsonplaceholder.typicode.com/albums/" + id.ToString();
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<Ablum>(reponse);
            Ablums = contente;
        }
    }
}
