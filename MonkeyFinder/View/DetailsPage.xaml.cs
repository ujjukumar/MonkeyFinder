namespace MonkeyFinder;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(MonkeyDetailsViewModel viewmodel)
	{
		InitializeComponent();
		BindingContext = viewmodel;
	}
}