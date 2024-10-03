using System.Collections;
using showDoMilhao;

namespace Controle
{
    public class RetiraErrada : IAjuda
    {
        public override void RealizaAjuda(Questao questao)
        {
            // Verifica qual é a resposta correta e oculta as respostas erradas
            switch (questao.respostaCorreta) // Acessando a propriedade RespostaCorreta da instância questao
            {
                case 1:
                    buttonResposta02.IsVisible = false;
                    buttonResposta03.IsVisible = false;
                    buttonResposta04.IsVisible = false;
                    break;
                case 2:
                    buttonResposta01.IsVisible = false;
                    buttonResposta03.IsVisible = false;
                    buttonResposta04.IsVisible = false;
                    break;
                case 3:
                    buttonResposta01.IsVisible = false;
                    buttonResposta02.IsVisible = false;
                    buttonResposta04.IsVisible = false;
                    break;
                case 4:
                    buttonResposta01.IsVisible = false;
                    buttonResposta02.IsVisible = false;
                    buttonResposta03.IsVisible = false;
                    break;
                case 5:
                    buttonResposta01.IsVisible = false;
                    buttonResposta02.IsVisible = false;
                    buttonResposta03.IsVisible = false;
                    break;
            }
        }
    }
}
