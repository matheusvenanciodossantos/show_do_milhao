namespace Controle
{
    public class Questione
    {
       public string Question;

       public string FirstQuestion;

       public string SecondQuestion;

       public string ThirdQuestion;

       public string FourthQuestion;

        public string FiveQuestion;

       public int respostacoreta =0;

       public int QuestioneLevel;

       private Label labelPergunta;

       private Button buttonResposta01;

       private Button buttonResposta02;

       private Button buttonResposta03;

       private Button buttonResposta04; 

       private Button buttonResposta05;


       
        public Questione(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05, )
                {
                    labelPergunta = lp;
                    buttonResposta01 = BT01;
                }
       public void ConfigurarDesenho(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05, )
                {
                    labelPergunta = lp;
                    buttonResposta01 = BT01;
                }
       public void Desenhar ()
                {
                    labelPergunta.Text = Question;
                    buttonResposta01.Text = FirstQuestion;
                }
       public bool VerificarSeEstaCorreta(int RR )
                {
                if (respostacoreta == RR)
                    { 
                        BTN BackgroundColor = Colors.Green
                    }
                    else 
                    {
                        var BTNCorreto = QualBTN(respostacoreta);
                        var BTNIncorreto = QualBTN(RR);
                        BTNCorreto.BackgroundColor = Colors.Yellow;
                        BTNIncorreto.BackgroundColor = Colors.Red;
                        Return False;

                    }
                }
        private  Button  QualBTN(int RR)
        {
            if(RR == RespostaRespondida)
        }
}
}