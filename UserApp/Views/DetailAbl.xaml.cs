using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Models;
using UserApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UserApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailAbl : ContentPage
    {
        public DetailAbl(Ablum global)
        {
            InitializeComponent();

            BindingContext = new DetailAblViewModel(global);

            //Id.Text = Convert.ToString(global.Id);
            //userId.Text = Convert.ToString(global.UserId);
            //title.Text = Convert.ToString(global.Title);
        }
    }
}