namespace previsao;

public partial class previsaoPage : ContentPage
{
    Results resultado;
	int count = 0;

	public previsaoPage()
	{
		InitializeComponent();
		TestaLayout(),
		PreencherTela(),
	}

	void TestaLayout()
	{
		resultado= new Results();
		resultado.temp=23;
		resultado.descripition="tempo nublado";
		resultado.rain=10;
		resultado.date="19/04/2024";
		resultado.time="08:09";
		resultado.currently="dia";
		resultado.city="Apucarana";
		resultado.img_id="28";
		resultado.humidity=90;
		resultado.wind_speedy="4.99 km/h";
		resultado.wind_direction=40;
		resultado.surinse="06:11 am";
		resultado.sunset="06:39 pm";
		resultado.moon_phase="cheia";
	}

	void PreencherTela()
	{
		
	}
	

}