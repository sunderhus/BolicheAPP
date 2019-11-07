using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoJogoDeBoliche;
namespace BolicheAPP.Test
{
    [TestClass]
    public class TesteDoJogo
    {
        [TestMethod]
        public void TesteIntanciarClasse()
        {
            var validacoesDeBonus = new JogoBonusValidacoes();
            var calculosDeBonus = new JogoBonusCalculos();
            var Jogo = new JogoDeBoliche(validacoesDeBonus, calculosDeBonus);
        }

        [TestMethod]
        public void TestarStrike()
        {
            var validacoesDeBonus = new JogoBonusValidacoes();
            var calculosDeBonus = new JogoBonusCalculos();
            var Jogo = new JogoDeBoliche(validacoesDeBonus, calculosDeBonus);
            Jogo.Jogar(10);
            //preparacao
            int pontuacao = Jogo.ObterPontuacao();
            //validacao
            Assert.AreEqual(pontuacao, 10);
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
            //preparacao
            int pontuacao = Jogo.ObterPontuacao();
            //validacao
            Assert.AreEqual(pontuacao, 10);
        }
        [TestMethod]
        public void TestarEnunciado()
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

            int pontuacao = Jogo.ObterPontuacao();

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

            int pontuacao = Jogo.ObterPontuacao();

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

            int pontuacao = Jogo.ObterPontuacao();

            Assert.AreEqual(pontuacao, 300);
        }

    }
}
