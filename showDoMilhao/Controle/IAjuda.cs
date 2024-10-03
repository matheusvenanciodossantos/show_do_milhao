using showDoMilhao;

namespace Controle
{
    public abstract class IAjuda 
    {
        protected Button buttonResposta01;
        protected Button buttonResposta02;
        protected Button buttonResposta03;
        protected Button buttonResposta04; 
        protected Button buttonResposta05;
        protected Frame frameAjuda;

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
}
