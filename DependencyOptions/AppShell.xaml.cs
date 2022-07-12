namespace DependencyOptions;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(CounterPage), typeof(CounterPage));
	}
}
