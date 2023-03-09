using MauiApp1.ViewModel;
using MauiApp1.Views;
using MauiApp1.Views.Template;

namespace MauiApp1;

public partial class App : Application
{
	public new static App Current => (App)Application.Current;
	public IServiceProvider Services { get; }

	public App()
	{
		var services = new ServiceCollection();
		Services = ConfigureServices(services);

		InitializeComponent();

		MainPage = new AppShell();
	}

	static IServiceProvider ConfigureServices(ServiceCollection services)
	{
		services.AddTransient<StudentViewModel>();
		services.AddTransient<TeacherViewModel>();

        services.AddSingleton<ListStudents>();
        services.AddSingleton<ListTeachers>();

        return services.BuildServiceProvider();
	}
}
