using System.Collections.ObjectModel;
using RGPopup.Maui.Services;

namespace MauiFormsEdu;

public class Teacher
{
    public string Degree { get; set; }
    public string Name { get; set; }
}

public partial class TeachersPage : ContentPage
{
    public static ObservableCollection<Teacher> TeachersList { get; set; }
    public TeachersPage()
    {
        InitializeComponent();
        TeachersList = new ObservableCollection<Teacher>(
            new Teacher[]
            {
                    new Teacher {Degree="Ing.", Name="R. S�bl�k" },
                    new Teacher {Degree="Mgr.", Name="Z. Nechanick�" },
                    new Teacher {Degree="Ing.", Name="Y. Scharnaglov�" },
                    new Teacher {Degree="Ing.", Name="P. �vec" },
            });
        TeachersListView.ItemsSource = TeachersList;
    }

    private async void AddButton_Clicked(object sender, EventArgs e)
    {
        TeacherPopup tp = new TeacherPopup();

        await PopupNavigation.Instance.PushAsync(tp, animate: true);

        //TeachersList.Add(new Teacher { Degree = "NoTitle", Name = "NoName" });

        //ObservableCollection �e�� tuto �karedost
        //TeachersListView.ItemsSource = null;
        //TeachersListView.ItemsSource = this.TeachersList;
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        ImageButton b = sender as ImageButton;
        TeachersList.Remove(b.CommandParameter as Teacher);
    }

    private void TeachersListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        DisplayAlert("U�itel", (TeachersListView.SelectedItem as Teacher).Name, "OK");
    }
}

