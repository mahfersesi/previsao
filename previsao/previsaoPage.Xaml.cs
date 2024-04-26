using System.Linq.Expressions;
using System.Text.Json;

namespace previsao;

public partial class previsaoPage : ContentPage
{
	const string Url="https//api.hbrasil.com/woeid=455927&Key=previsao";
    Results resultado; Results resposta;
	async void AtualizaTempo()
	{
		try
		{
			var navegador=new HttpClient();
			var response=await navegador.GetAsync(Url);
			if(response.IsSuccessStatusCode)
		{
		var content=await response.Content.ReadAsStringAsync();
		resposta = JsonSerializer.Deserialize<Results>(content);
		}
		PreencherTela();

		}
		catch(Exception e)
		{
			//erro
		}
	}
	int count = 0;

	public previsaoPage()
	{
		InitializeComponent();
		PreencherTela();
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