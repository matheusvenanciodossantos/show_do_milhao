namespace Controle
{
    public class Questao
    {
       public string Question;

       public string FirstQuestion;

       public string SecondQuestion;

       public string ThirdQuestion;

       public string FourthQuestion;

        public string FiveQuestion;

       public int respostacoreta =0;

       public int QuestaoLevel;

       private Label labelPergunta;

       private Button buttonResposta01;

       private Button buttonResposta02;

       private Button buttonResposta03;

       private Button buttonResposta04; 

       private Button buttonResposta05;


        public Questao()
        {

        }
       
        public Questao(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
                {
                    labelPergunta = lp;
                    buttonResposta01 = BT01;
                    buttonResposta02 = BT02;
                    buttonResposta03 = BT03;
                    buttonResposta04 = BT04;
                    buttonResposta05 = BT05;
                }
       public void ConfigurarDesenho(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
                {
                    labelPergunta = lp;
                    buttonResposta01 = BT01;
                    buttonResposta02 = BT02;
                    buttonResposta03 = BT03;
                    buttonResposta04 = BT04;
                    buttonResposta05 = BT05;
                }
       public void Desenhar ()
                {
                    labelPergunta.Text = Question;
                    buttonResposta01.Text = FirstQuestion;
                    buttonResposta02.Text = SecondQuestion;
                    buttonResposta03.Text = ThirdQuestion;
                    buttonResposta04.Text = FourthQuestion;
                    buttonResposta05.Text = FiveQuestion;

                    buttonResposta01.BackgroundColor = Color.FromArgb("#77000000");
                    buttonResposta01.TextColor       = Colors.White;
                    buttonResposta02.BackgroundColor = Color.FromArgb("#77000000");
                    buttonResposta02.TextColor       = Colors.White;
                    buttonResposta03.BackgroundColor = Color.FromArgb("#77000000");
                    buttonResposta03.TextColor       = Colors.White;
                    buttonResposta04.BackgroundColor = Color.FromArgb("#77000000");
                    buttonResposta04.TextColor       = Colors.White;
                    buttonResposta05.BackgroundColor = Color.FromArgb("#77000000");
                    buttonResposta05.TextColor       = Colors.White; 
                }
       public bool VerificarSeEstaCorreta(int RR )
                {
                if (respostacoreta == RR)
                    { 
                        var btn = QualBTN( RR);
                        btn.BackgroundColor = Colors.Green;
                        return true;
                    }
                    else 
                    {
                        var btnCorreto =  QualBTN(respostacoreta);
                        var btnIncorreto = QualBTN(RR);
                        btnCorreto.BackgroundColor = Colors.BlueViolet;
                       
                        btnIncorreto.BackgroundColor = Colors.Red;
                        return false;
                    }
                }
            private  Button  QualBTN(int RR)
            {
                    if (RR == 1) return buttonResposta01;
                     else if (RR == 2) return buttonResposta02;
                    else if (RR == 3) return buttonResposta03;
                     else if (RR == 4) return buttonResposta04;
                    else if (RR == 5) return buttonResposta05;
                     else return null;
            }
 }
}