namespace Controle
{
    public class Gerenciador
    {
        // Listas para armazenar perguntas e controlar perguntas já respondidas
        private List<Questao> ListaQuestoes = new List<Questao>();
        private HashSet<int> QuestoesRespondidas = new HashSet<int>();
        
        // Variável para armazenar a questão corrente
        private Questao QuestaoCorrente;
        
        // Construtor da classe
        public Gerenciador(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
        {
            CriaPerguntas(lp, BT01, BT02, BT03, BT04, BT05);
        }

        // Método para criar e configurar perguntas
        private void CriaPerguntas(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
        {
            var P1 = new Questao();
            P1.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P1.Question = "Qual é a capital da Argentina?";
            P1.FirstQuestion = "Brasil";
            P1.SecondQuestion = "Caracas";
            P1.ThirdQuestion = "Buenos Aires";
            P1.FourthQuestion = "Mendoza";
            P1.FiveQuestion = "Xique-Xique";
            P1.respostacoreta = 3;  
            ListaQuestoes.Add(P1);

            var P2 = new Questao();
            P2.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P2.Question = "Quem pintou a Mona Lisa?";
            P2.FirstQuestion = "Vincent van Gogh";
            P2.SecondQuestion = "Leonardo da Vinci";
            P2.ThirdQuestion = "Michelangelo";
            P2.FourthQuestion = "Claude Monet";
            P2.FiveQuestion = "Pablo Picasso";
            P2.respostacoreta = 2;
            ListaQuestoes.Add(P2);

            // Terceira pergunta
            var P3 = new Questao();
            P3.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P3.Question = "Qual é o maior país do mundo em área?";
            P3.FirstQuestion = "Brasil";
            P3.SecondQuestion = "China";
            P3.ThirdQuestion = "Rússia";
            P3.FourthQuestion = "Estados Unidos";
            P3.FiveQuestion = "Canadá";
            P3.respostacoreta = 3;
            ListaQuestoes.Add(P3);

            // Quarta pergunta
            var P4 = new Questao();
            P4.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P4.Question = "Em que ano ocorreu a Revolução Francesa?";
            P4.FirstQuestion = "1789";
            P4.SecondQuestion = "1776";
            P4.ThirdQuestion = "1804";
            P4.FourthQuestion = "1812";
            P4.FiveQuestion = "1905";
            P4.respostacoreta = 1;
            ListaQuestoes.Add(P4);

            // Quinta pergunta
            var P5 = new Questao();
            P5.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P5.Question = "Qual é o rio mais longo do mundo?";
            P5.FirstQuestion = "Rio Nilo";
            P5.SecondQuestion = "Rio Amazonas";
            P5.ThirdQuestion = "Rio Yangtzé";
            P5.FourthQuestion = "Rio Mississipi";
            P5.FiveQuestion = "Rio Congo";
            P5.respostacoreta = 1;
            ListaQuestoes.Add(P5);

            // Sexta pergunta
            var P6 = new Questao();
            P6.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P6.Question = "Quem descobriu o Brasil?";
            P6.FirstQuestion = "Cristóvão Colombo";
            P6.SecondQuestion = "Vasco da Gama";
            P6.ThirdQuestion = "Pedro Álvares Cabral";
            P6.FourthQuestion = "Américo Vespúcio";
            P6.FiveQuestion = "Fernão de Magalhães";
            P6.respostacoreta = 3;
            ListaQuestoes.Add(P6);

            // Sétima pergunta
            var P7 = new Questao();
            P7.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P7.Question = "Qual é o menor país do mundo?";
            P7.FirstQuestion = "Mônaco";
            P7.SecondQuestion = "Ilhas Marshall";
            P7.ThirdQuestion = "Malta";
            P7.FourthQuestion = "Vaticano";
            P7.FiveQuestion = "San Marino";
            P7.respostacoreta = 4;
            ListaQuestoes.Add(P7);

            // Oitava pergunta
            var P8 = new Questao();
            P8.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P8.Question = "Quem é o autor de 'Dom Quixote'?";
            P8.FirstQuestion = "Miguel de Cervantes";
            P8.SecondQuestion = "Gabriel García Márquez";
            P8.ThirdQuestion = "Jorge Luis Borges";
            P8.FourthQuestion = "Pablo Neruda";
            P8.FiveQuestion = "Carlos Fuentes";
            P8.respostacoreta = 1;
            ListaQuestoes.Add(P8);

            // Nona pergunta
            var P9 = new Questao();
            P9.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P9.Question = "Quantos estados tem o Brasil?";
            P9.FirstQuestion = "24";
            P9.SecondQuestion = "26";
            P9.ThirdQuestion = "27";
            P9.FourthQuestion = "28";
            P9.FiveQuestion = "30";
            P9.respostacoreta = 3;
            ListaQuestoes.Add(P9);

            // Décima pergunta
            var P10 = new Questao();
            P10.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
            P10.Question = "Quem escreveu 'O Pequeno Príncipe'?";
            P10.FirstQuestion = "J.K. Rowling";
            P10.SecondQuestion = "Antoine de Saint-Exupéry";
            P10.ThirdQuestion = "George Orwell";
            P10.FourthQuestion = "Ernest Hemingway";
            P10.FiveQuestion = "Agatha Christie";
            P10.respostacoreta = 2;
            ListaQuestoes.Add(P10);
                    

             ProximaQuestao();
            }

        // Método para verificar se a resposta está correta
        public async void VerificarSeEstaCorreta(int RR)
        {
            if (QuestaoCorrente.VerificarSeEstaCorreta(RR))
            {
                await Task.Delay(1000); // 1 segundo de espera
                ProximaQuestao(); // Chama a próxima questão
            }
        }

        // Método para avançar para a próxima questão
        public void ProximaQuestao()
        {
            var RandomNumber = Random.Shared.Next(0, ListaQuestoes.Count);

            // Garante que a questão selecionada ainda não foi respondida
            while (QuestoesRespondidas.Contains(RandomNumber))
            {
                RandomNumber = Random.Shared.Next(0, ListaQuestoes.Count);
            }

            // Marca a questão como respondida
            QuestoesRespondidas.Add(RandomNumber);

            // Define a questão corrente e a desenha na tela
            QuestaoCorrente = ListaQuestoes[RandomNumber];
            QuestaoCorrente.Desenhar();
        }
    }
}
