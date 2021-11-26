﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Unidad3.ViewModel;

namespace Unidad3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewContact : ContentPage
    {
        public NewContact()
        {
            InitializeComponent();
            BindingContext = new ContactosViewModal();
        }
    }
}