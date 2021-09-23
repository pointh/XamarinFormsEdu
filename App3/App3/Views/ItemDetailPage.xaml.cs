using AppTabbed.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppTabbed.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}