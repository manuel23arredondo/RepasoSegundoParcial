using MauiApp1.Views;

namespace MauiApp1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(ListStudents), typeof(ListStudents));
        Routing.RegisterRoute(nameof(ListTeachers), typeof(ListTeachers));
    }
}
