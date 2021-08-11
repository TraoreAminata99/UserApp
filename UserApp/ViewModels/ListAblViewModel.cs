using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using UserApp.Models;

namespace UserApp.ViewModels
{
   public class ListAblViewModel : BaseViewModels
    {
        public ObservableCollection<Ablum> AlAblum
        {
            get => Get<ObservableCollection<Ablum>>();
            set => Set(value);
        }

        public ListAblViewModel()
        {
            AlAblum = new ObservableCollection<Ablum>();
            GetAblum();
        }
       
        public async void GetAblum()
        {

            string ApiUrl = "https://jsonplaceholder.typicode.com/albums";
            var uri = new Uri(ApiUrl);
            HttpClient client = new HttpClient();
            var reponse = await client.GetStringAsync(uri);
            var contente = JsonConvert.DeserializeObject<ObservableCollection<Ablum>>(reponse);
            AlAblum = contente;
        
        }
    }
}
