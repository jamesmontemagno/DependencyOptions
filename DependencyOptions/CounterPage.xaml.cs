namespace DependencyOptions;

public partial class CounterPage : ContentPage
{
	public CounterPage(CounterViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		BackgroundColor = Colors.Orange;
	}
}