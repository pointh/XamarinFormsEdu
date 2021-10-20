using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;

namespace AppShell
{
    public class Teacher
    {
        public string Degree { get; set; }
        public string Name { get; set; }
    }

    public partial class TeachersPage : ContentPage
    {
        // public List<Teacher> TeacherList {get; set;}
        public static ObservableCollection<Teacher> TeachersList { get; set; }
        public TeachersPage()
        {
            InitializeComponent();
            TeachersList = new ObservableCollection<Teacher>(
                new Teacher[]
                {
                    new Teacher {Degree="Ing.", Name="R. Sáblík" },
                    new Teacher {Degree="Mgr.", Name="Z. Nechanický" },
                    new Teacher {Degree="Ing.", Name="Y. Scharnaglová" },
                    new Teacher {Degree="Ing.", Name="P. Švec" },
                });
            TeachersListView.ItemsSource = TeachersList;
        }

        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            TeacherPopup tp = new TeacherPopup();

            await PopupNavigation.Instance.PushAsync(tp, animate:true);
            
            //TeachersList.Add(new Teacher { Degree = "NoTitle", Name = "NoName" });

            //ObservableCollection řeší tuto škaredost
            //TeachersListView.ItemsSource = null;
            //TeachersListView.ItemsSource = this.TeachersList;
        }
    }
}
