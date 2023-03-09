using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModel
{
    public partial class StudentViewModel : ObservableObject
    {
        public ObservableCollection<StudentModel> Students { get; set; } = new();

        [RelayCommand]
        public async Task ListStudents()
        {
            Students.Clear();
            Students.Add(new StudentModel() { FirstName = "Diego", LastName = "Garzón" });
            Students.Add(new StudentModel() { FirstName = "Samuel", LastName = "Díaz" });
            Students.Add(new StudentModel() { FirstName = "Manuel", LastName = "Arredondo" });
            Students.Add(new StudentModel() { FirstName = "Jessé", LastName = "Cerezo" });
            Students.Add(new StudentModel() { FirstName = "Alfonso", LastName = "Hernández" });
            Students.Add(new StudentModel() { FirstName = "Yael", LastName = "Palacios" });
            Students.Add(new StudentModel() { FirstName = "Edwin", LastName = "Lozada" });
            Students.Add(new StudentModel() { FirstName = "Alejandro", LastName = "Barroeta" });
            Students.Add(new StudentModel() { FirstName = "Luis", LastName = "Navarro" });
        }
    }
}
