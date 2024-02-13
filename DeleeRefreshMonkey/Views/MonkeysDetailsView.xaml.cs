using DeleeRefreshMonkey.ViewModels;

namespace DeleeRefreshMonkey.Views;

public partial class MonkeysDetailsView : ContentPage
{
	public MonkeysDetailsView(MonkeyDetalisViewModels vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}