namespace DeleeRefreshMonkey.Views;

public class MonkeysDetailsViews : ContentPage
{
	public MonkeysDetailsViews()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}