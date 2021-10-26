using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppShell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShellPage : Shell
    {
        public ShellPage()
        {
            InitializeComponent();
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            DisplayAlert("ČAS", $"{DateTime.Now}", "OK");
        }
    }
}