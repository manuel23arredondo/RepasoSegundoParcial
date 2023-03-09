using MauiApp1.ViewModel;

namespace MauiApp1.Views;

public partial class ListStudents : ContentPage
{
	public ListStudents()
	{
		BindingContext = App.Current.Services.GetRequiredService<StudentViewModel>();
		InitializeComponent();
	}
}