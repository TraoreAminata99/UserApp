﻿using System;
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
    public partial class DetailU : ContentPage
    {
        public DetailU(Users global)
        {
            InitializeComponent();
            BindingContext = new DetailUViewModel(global);

      

        }
    }
}