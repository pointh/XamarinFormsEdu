namespace MauiFormsEdu
{
    public partial class AppShell : Shell
    {
        public AppShell()
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