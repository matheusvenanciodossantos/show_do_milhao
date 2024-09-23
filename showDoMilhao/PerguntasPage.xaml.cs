using Controle;
using Microsoft.Maui.Controls;

namespace showDoMilhao;

public partial class PerguntasPage : ContentPage
{
	public Gerenciador gerenciador;

	public PerguntasPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
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
}


