﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection;
using System.Diagnostics;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OK_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Upozornění o volání", MethodBase.GetCurrentMethod().Name, "Zpět");
        }

        private async void AppInfo_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Upozornění o voláních", Application.Current.Properties["LastMainPageAppeared"].ToString(), "Zpět");
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            Debug.WriteLine($"MainPage appearing at {DateTime.Now}");
            if (Application.Current.Properties.ContainsKey("LastMainPageAppeared") == false)
            {
                Application.Current.Properties.Add("LastMainPageAppeared", DateTime.Now);
            }
            else
            {
                Debug.WriteLine($"MainPage first time appeared at" +
                    $" {Application.Current.Properties["LastMainPageAppeared"].ToString()}, now is {DateTime.Now}");
            }
        }

        private void ContentPage_Disappearing(object sender, EventArgs e)
        {
            Debug.WriteLine("MainPage disappearing");

        }

        private void Resources_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine($"Resources: {string.Join(",", Application.Current.Resources.Keys)}");

            // Dynamicky generované tlačítko
            // MainStackLayout je StackLayout pojmenovaný v XAML filu.
            Button b = new Button() { Text = "Zdravicí tlačítko" };
            b.Clicked += B_Clicked;
            MainStackLayout.Children.Add(b);

        }

        private async void B_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Hello", $"Nazdar {EntryJmeno.Text}", "OK");
        }
    }
}
