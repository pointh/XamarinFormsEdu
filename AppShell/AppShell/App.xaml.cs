﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppShell
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ShellPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
