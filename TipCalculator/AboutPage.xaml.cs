namespace TipCalculator;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
    private async void AboutButton_ClickedOne(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/Gustavo-Crnts");
    }
    private async void AboutButton_ClickedTwo(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/isaxavierz");
    }
    
}