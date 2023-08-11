namespace MonkeyFinder;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        // nameof(DetailsPage) == "Details Page"
		// basically what is the name of details page
        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
	}
}