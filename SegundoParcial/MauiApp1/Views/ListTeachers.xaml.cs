using MauiApp1.ViewModel;

namespace MauiApp1.Views;

public partial class ListTeachers : ContentPage
{
	public ListTeachers()
	{
		BindingContext = App.Current.Services.GetRequiredService<TeacherViewModel>();
		InitializeComponent();
	}
}