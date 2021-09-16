using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using System.Reflection;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name, "APP");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

        protected override void OnResume()
        {
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
        }
    }
}
