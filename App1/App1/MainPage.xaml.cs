using System;
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

        private void OK_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Upozornění o volání", MethodBase.GetCurrentMethod().Name, "Zpět");
        }

        private void AppInfo_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Upozornění o voláních", Application.Current.Properties["LastMainPageAppeared"].ToString(), "Zpět");
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            Debug.WriteLine($"MainPage appearing at {DateTime.Now}");
            if (Application.Current.Properties.ContainsKey("LastMainPageAppeared") == false)
                Application.Current.Properties.Add("LastMainPageAppeared", DateTime.Now);
            else
                Debug.WriteLine($"MainPage first time appeared at" +
                    $" {Application.Current.Properties["LastMainPageAppeared"].ToString()}, now is {DateTime.Now}");
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
            Entry entry = new Entry() { Text = "Dynamicky generované tlačítko" };
            MainStackLayout.Children.Add(entry);

        }
    }
}
