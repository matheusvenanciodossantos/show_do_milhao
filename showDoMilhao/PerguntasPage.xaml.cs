using Controle;
using Microsoft.Maui.Controls;

namespace showDoMilhao;

public partial class PerguntasPage : ContentPage
{
	int pular = 0;
	public Gerenciador gerenciador;

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
		pular++;
			
			if (pular == 3)
			{gerenciador.ProximaQuestao();
			(S as Button).IsVisible=false;
			}

			else
			{
				gerenciador.ProximaQuestao();
			}

			if (pular == 0)
			{ 
				Ajuda2.Text = "Pular 3x";
			}
			if (pular == 1)
			{ 
				Ajuda2.Text = "Pular 2x";
			}
			if (pular == 2)
			{ 
				Ajuda2.Text = "Pular 1x";
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


