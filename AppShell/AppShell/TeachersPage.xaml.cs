﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
using System.Diagnostics;

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

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            ImageButton b = sender as ImageButton;
            TeachersList.Remove(b.CommandParameter as Teacher);
        }

        private void TeachersListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Učitel", (TeachersListView.SelectedItem as Teacher).Name, "OK");
        }
    }
}
