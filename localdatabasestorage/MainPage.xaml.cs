﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace localdatabasestorage
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(ageEntry.Text))
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Name = nameEntry.Text,
                    Age = int.Parse(ageEntry.Text)
                });

                nameEntry.Text = ageEntry.Text = string.Empty;
                listView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }
    }
}
