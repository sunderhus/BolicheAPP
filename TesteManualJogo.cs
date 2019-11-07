using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJogoDeBoliche
{
    class TesteManualJogo
    {
        static void Main(string[] args)
        {
            var validacoesDeBonus = new JogoBonusValidacoes();
            var calculosDeBonus = new JogoBonusCalculos();
            var Jogo = new JogoDeBoliche(validacoesDeBonus, calculosDeBonus);

            //Jogo do enunciado.
            //1 
            Jogo.Jogar(1);
            Jogo.Jogar(4);
            //2
            Jogo.Jogar(4);
            Jogo.Jogar(5);
            //3
            Jogo.Jogar(6);
            Jogo.Jogar(4);
            //4
            Jogo.Jogar(5);
            Jogo.Jogar(5);
            //5
            Jogo.Jogar(10);
            //6
            Jogo.Jogar(0);
            Jogo.Jogar(1);
            //7
            Jogo.Jogar(7);
            Jogo.Jogar(3);
            //8
            Jogo.Jogar(6);
            Jogo.Jogar(4);
            //9
            Jogo.Jogar(10);
            //Quadro Bonus 
            Jogo.Jogar(2);
            Jogo.Jogar(8);
            Jogo.Jogar(6);


            //jogando todos os spares possiveis
            //for (int i = 0; i < 20; i++)
            //{
            //    Jogo.Jogar(5);
            //}

            //jogando todos os strikes
            //for (int i = 0; i < 12; i++)
            //{
            //    Jogo.Jogar(10);
            //}

            //primeira jogada Strike.
            //Jogo.Jogar(10);
            //Jogo.Jogar(3);
            //Jogo.Jogar(4);
            //for (int i = 0; i < 16; i++)
            //{
            //    Jogo.Jogar(0);
            //}

            //Verificando um Spare.
            //Jogo.Jogar(4);
            //Jogo.Jogar(6);
            //for (int i = 0; i < 18; i++)
            //{
            //    Jogo.Jogar(0);
            //}
            //Um strike.
            // Jogo.Jogar(10);


            #region ScoreFinal
            //mostra pontuação do jogo.
            #endregion
            Console.WriteLine($"Total no jogo: {Jogo.ObterPontuacao()} pontos.");
        }

    }
}
