using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModel
{
    public partial class TeacherViewModel : ObservableObject
    {
        public ObservableCollection<TeacherModel> Teachers { get; set; } = new();

        [RelayCommand]
        public async Task ListTeachers()
        {
            Teachers.Clear();
            Teachers.Add(new TeacherModel() { FirstName = "Carlos", LastName = "Zapata", Email = "carlos.zapata@umad.edu.mx", Phone = "1234567890" });
            Teachers.Add(new TeacherModel() { FirstName = "Nicolás", LastName = "Arrioja", Email = "nicolas.arrioja@umad.edu.mx", Phone = "1234567890" });
            Teachers.Add(new TeacherModel() { FirstName = "Patricia", LastName = "Hernández", Email = "patricia.hernandez@umad.edu.mx", Phone = "1234567890" });
        }
    }
}
