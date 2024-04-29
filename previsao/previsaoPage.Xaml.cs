using System.Linq.Expressions;
using System.Text.Json;

namespace previsao;

public partial class previsaoPage : ContentPage
{
	const string Url="https//api.hbrasil.com/woeid=455927&Key=previsao";
    Resposta resposta; 
	async void AtualizaTempo()
	{
		try
		{
			var navegador=new HttpClient();
			var response=await navegador.GetAsync(Url);
			if(response.IsSuccessStatusCode)
		{
		var content=await response.Content.ReadAsStringAsync();
		resposta = JsonSerializer.Deserialize<Resposta>(content);
		}
		PreencherTela();

		}
		catch(Exception e)
		{
			//erro
		}
	}
	

	public previsaoPage()
	{
		InitializeComponent();
		AtualizaTempo();
	}

	

	void PreencherTela()
	{
		if (resposta.results.currently=="dia")
		if (resposta.results.rain>=10)
		ImgBackground.Source="diachuvoso.jpg";
		else if (resposta.results.cloudness>=10)
		ImgBackground.Source="ceunublado.jpg";
		else 
		ImgBackground.Source="diaensolarado.jpg";

		 if (resposta.results.currently=="noite")
		 if (resposta.results.rain>=10)
		ImgBackground.Source="noitechuvosa.jpg";
		else if (resposta.results.cloudness>=10)
		ImgBackground.Source="noitenublado.jpg";
		else 
		ImgBackground.Source="ceuestrelado.jpg";
	

		LabelGrau.Text=resposta.results.temp.ToString();
		LabelCeu.Text=resposta.results.descripition.ToString();
		LabelCidade.Text=resposta.results.city.ToString();
		LabelChuva.Text=resposta.results.rain.ToString();
		LabelHumidade.Text=resposta.results.humidity.ToString();
		LabelAmanhecer.Text=resposta.results.surinse.ToString();
		LabelAnoitecer.Text=resposta.results.sunset.ToString();
		LabelForte.Text=resposta.results.wind_speedy.ToString();
		LabelDirecao.Text=resposta.results.wind_direction.ToString();
		LabelFase.Text=resposta.results.moon_phase.ToString();
	
	}


	

}