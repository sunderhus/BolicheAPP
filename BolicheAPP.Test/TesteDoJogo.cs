using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoJogoDeBoliche;
namespace BolicheAPP.Test
{
    [TestClass]
    public class TesteDoJogo
    {
        [TestMethod]
        public void TestarConstrutor()
        {
            var validacoesDeBonus = new JogoBonusValidacoes();
            var calculosDeBonus = new JogoBonusCalculos();
            var Jogo = new JogoDeBoliche(validacoesDeBonus, calculosDeBonus);
        }

        [TestMethod]
        public void TestarJogoSemBonus()
        {
            var validacoesDeBonus = new JogoBonusValidacoes();
            var calculosDeBonus = new JogoBonusCalculos();
            var Jogo = new JogoDeBoliche(validacoesDeBonus, calculosDeBonus);

            for (int i = 0; i < 20; i++)
            {
                Jogo.Jogar(1);
            }
            //Preparação
            int pontuacao = Jogo.ObterPontuacao();
            
            //Validação
            Assert.AreEqual(pontuacao, 20);

        }
        [TestMethod]
        public void TestarStrike()
        {
            var validacoesDeBonus = new JogoBonusValidacoes();
            var calculosDeBonus = new JogoBonusCalculos();
            var Jogo = new JogoDeBoliche(validacoesDeBonus, calculosDeBonus);
            
            Jogo.Jogar(10);
            Jogo.Jogar(3);
            Jogo.Jogar(4);

            for (int i = 0; i < 16; i++)
            {
                Jogo.Jogar(0);
            }

            //Preparação
            int pontuacao = Jogo.ObterPontuacao();

            //Validação
            Assert.AreEqual(pontuacao, 24);
        }

        [TestMethod]
        public void TestarSpare()
        {
            var validacoesDeBonus = new JogoBonusValidacoes();
            var calculosDeBonus = new JogoBonusCalculos();
            var Jogo = new JogoDeBoliche(validacoesDeBonus, calculosDeBonus);
            Jogo.Jogar(4);
            Jogo.Jogar(6);
            for (int i = 0; i < 18; i++)
            {
                Jogo.Jogar(0);
            }
            //Preparação
            int pontuacao = Jogo.ObterPontuacao();
            
            //Validação
            Assert.AreEqual(pontuacao, 10);
        }

        [TestMethod]
        public void TestarEnunciado()
        {
            var validacoesDeBonus = new JogoBonusValidacoes();
            var calculosDeBonus = new JogoBonusCalculos();
            var Jogo = new JogoDeBoliche(validacoesDeBonus, calculosDeBonus);

            //Jogo do enunciado.
            //1 Quadro
            Jogo.Jogar(1);
            Jogo.Jogar(4);
            //2 Quadro
            Jogo.Jogar(4);
            Jogo.Jogar(5);
            //3 Quadro
            Jogo.Jogar(6);
            Jogo.Jogar(4);
            //4 Quadro
            Jogo.Jogar(5);
            Jogo.Jogar(5);
            //5 Quadro
            Jogo.Jogar(10);
            //6 Quadro
            Jogo.Jogar(0);
            Jogo.Jogar(1);
            //7 Quadro
            Jogo.Jogar(7);
            Jogo.Jogar(3);
            //8 Quadro
            Jogo.Jogar(6);
            Jogo.Jogar(4);
            //9 Quadro
            Jogo.Jogar(10);
            //Quadro com até três jogadas.
            Jogo.Jogar(2);
            Jogo.Jogar(8);
            Jogo.Jogar(6);

            //Preparação
            int pontuacao = Jogo.ObterPontuacao();
            
            //Validação
            Assert.AreEqual(pontuacao, 133);
        }

        [TestMethod]
        public void JogandoTodosOsSparesPossiveis()
        {
            var validacoesDeBonus = new JogoBonusValidacoes();
            var calculosDeBonus = new JogoBonusCalculos();
            var Jogo = new JogoDeBoliche(validacoesDeBonus, calculosDeBonus);
            for (int i = 0; i < 20; i++)
            {
                Jogo.Jogar(5);
            }

            //Preparação
            int pontuacao = Jogo.ObterPontuacao();
            
            //Validação
            Assert.AreEqual(pontuacao, 145);
        }

        [TestMethod]
        public void JogandoTodosOsStrikesPossiveis()
        {
            var validacoesDeBonus = new JogoBonusValidacoes();
            var calculosDeBonus = new JogoBonusCalculos();
            var Jogo = new JogoDeBoliche(validacoesDeBonus, calculosDeBonus);
            
            for (int i = 0; i < 12; i++)
            {
                Jogo.Jogar(10);
            }
            
            //Preparação
            int pontuacao = Jogo.ObterPontuacao();
            
            //Validação
            Assert.AreEqual(pontuacao, 300);
        }

    }
}
