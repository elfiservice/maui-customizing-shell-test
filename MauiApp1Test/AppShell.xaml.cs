using MauiApp1Test.Pages;

namespace MauiApp1Test;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(Page2Test), typeof(Page2Test));
	}
}
