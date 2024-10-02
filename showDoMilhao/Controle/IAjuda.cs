using Controle;

namespace showDoMilhao;

public abstract class IAjuda 
{
    private Button buttonResposta01;
    private Button buttonResposta02;
    private Button buttonResposta03;
    private Button buttonResposta04; 
    private Button buttonResposta05;
    private Frame frameAjuda;

    // Método para configurar os botões
    public void ConfigurarDesenho(Button buttonResposta01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05)
    {
        this.buttonResposta01 = buttonResposta01;
        this.buttonResposta02 = buttonResposta02;
        this.buttonResposta03 = buttonResposta03;
        this.buttonResposta04 = buttonResposta04;
        this.buttonResposta05 = buttonResposta05;  
    }

    // Método para configurar o frame
    public void ConfigurarDesenho(Frame frameAjuda)
    {
        this.frameAjuda = frameAjuda;
    }

    // Método abstrato para realizar ajuda
    public abstract void RealizaAjuda(Questao questao);
}
