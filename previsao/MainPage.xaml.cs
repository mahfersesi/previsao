namespace previsao;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void Pr(object sender, EventArgs args)
  {
      Application.Current.MainPage = new previsaoPage();
  }

}

