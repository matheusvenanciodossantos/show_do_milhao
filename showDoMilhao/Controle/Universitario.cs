namespace Controle;
public class Universitarios : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        var porcentagem = 100;
        for (int i = 0; i < 5; i++)
        {
            int numRand = 0;
            if (porcentagem > 0)
            {
                numRand = Random.Shared.Next(0, porcentagem);
                 porcentagem -= numRand;
            }
            switch (i)
            {
                case 0:
                    buttonResposta01.Text += "-" + numRand.ToString() + "%";
                    break;
                case 1:
                    buttonResposta02.Text += "-" + numRand.ToString() + "%";
                    break;
                case 2:
                    buttonResposta03.Text += "-" + numRand.ToString() + "%";
                    break;
                case 3:
                    buttonResposta04.Text += "-" + numRand.ToString() + "%";
                    break;
                case 4:
                    buttonResposta05.Text += "-" + numRand.ToString() + "%";
                    break;
            }
        }
    }
}