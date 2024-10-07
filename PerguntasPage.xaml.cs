using Controle;
using Microsoft.Maui.Controls;

namespace showDoMilhao;


public partial class PerguntasPage : ContentPage
{
	public Gerenciador gerenciador;
	int count = 0;
	public PerguntasPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05, LpPontuacao, LpNivelAtual);
	}

	void OnbuttonResposta01(object sender, EventArgs args)
	{
		gerenciador.VerificarSeEstaCorreta(1);
	}
	void OnbuttonResposta02(object sender, EventArgs args)
	{
		gerenciador.VerificarSeEstaCorreta(2);
	}
	void OnbuttonResposta03(object sender, EventArgs args)
	{
		gerenciador.VerificarSeEstaCorreta(3);
	}
	void OnbuttonResposta04(object sender, EventArgs args)
	{
		gerenciador.VerificarSeEstaCorreta(4);
	}
	void OnbuttonResposta05(object sender, EventArgs args)
	{
		gerenciador.VerificarSeEstaCorreta(5);
	}
	void OnButtonHelp(object S, EventArgs e)
	{
		var ajuda = new RetiraErrada();
		ajuda.ConfigurarDesenho(buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(S as Button).IsVisible=false;
	}
	void OnButtonHelp2(object S, EventArgs e)
	{
		count++;
			
			if (count == 3)
			{gerenciador.ProximaQuestao();
			(S as Button).IsVisible=false;
			}

			else
			{
				gerenciador.ProximaQuestao();
			}

	} 
	void OnButtonHelp3(object S, EventArgs e)
	{
		var ajuda = new Universitarios();
		ajuda.ConfigurarDesenho(buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(S as Button).IsVisible=false;
	}
}


