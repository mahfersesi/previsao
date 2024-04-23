namespace previsao;

public partial class previsaoPage : ContentPage
{
    Results resultado;
	int count = 0;

	public previsaoPage()
	{
		InitializeComponent();
		TestaLayout();
		PreencherTela();
	}

	void TestaLayout()
	{
		resultado= new Results();
		resultado.temp=23;
		resultado.descripition="tempo nublado";
		resultado.rain=10;
		resultado.date="19/04/2024";
		resultado.cloudness=100;
		resultado.currently="dia";
		resultado.city="Apucarana";
		resultado.img_id="28";
		resultado.humidity=90;
		resultado.wind_speedy="4.99 km/h";
		resultado.wind_direction="40";
		resultado.surinse="06:11";
		resultado.sunset="06:39";
		resultado.moon_phase="cheia";
	}

	void PreencherTela()
	{
		if (resultado.currently=="dia")
		if (resultado.rain>=10)
		ImgBackground.Source="diachuvoso.jpg";
		else if (resultado.cloudness>=10)
		ImgBackground.Source="ceunublado.jpg";
		else 
		ImgBackground.Source="diaensolarado.jpg";

		 if (resultado.currently=="noite")
		 if (resultado.rain>=10)
		ImgBackground.Source="noitechuvosa.jpg";
		else if (resultado.cloudness>=10)
		ImgBackground.Source="noitenublado.jpg";
		else 
		ImgBackground.Source="ceuestrelado.jpg";
	

		LabelGrau.Text=resultado.temp.ToString();
		LabelCeu.Text=resultado.descripition.ToString();
		LabelCidade.Text=resultado.city.ToString();
		LabelChuva.Text=resultado.rain.ToString();
		LabelHumidade.Text=resultado.humidity.ToString();
		LabelAmanhecer.Text=resultado.surinse.ToString();
		LabelAnoitecer.Text=resultado.sunset.ToString();
		LabelForte.Text=resultado.wind_speedy.ToString();
		LabelDirecao.Text=resultado.wind_direction.ToString();
		LabelFase.Text=resultado.moon_phase.ToString();
	
	}


	

}