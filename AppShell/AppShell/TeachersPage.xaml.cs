using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppShell
{
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
                    new Teacher { Degree = "Ing.", Name="R. Sáblík"},
                    new Teacher { Degree = "Mgr.", Name="Z. Nechanický"},
                    new Teacher { Degree = "Ing.", Name="Y. Scharnaglová"},
                    new Teacher { Degree = "Ing.", Name="P. Švec"},
                });
            TeachersListView.ItemsSource = TeachersList;
        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            TeachersList.Add(new Teacher { Degree = "Mgr.", Name = "T. Tkáč" });
        }
    }
}
