using ProjetoJogoDeBoliche.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJogoDeBoliche
{
    public class JogoDeBoliche : IJogoOperacoes
    {
        private int[] jogadas = new int[21];
        private int jogadaIndex = 0;
        private IJogoBonusValidacoes _validacoesDeBonus;
        private IJogoBonusCalculos _calculosDeBonus;

        public JogoDeBoliche(JogoBonusValidacoes validacoesDeBonus, JogoBonusCalculos calculosDeBonus)
        {
            this._validacoesDeBonus = validacoesDeBonus;
            this._calculosDeBonus = calculosDeBonus;
        }

        public void Jogar(int pinos)
        {
            ContabilizarPinos(pinos);
            ProximaJogada(ref jogadaIndex, 1);
        }

        public int ObterPontuacao()
        {
            int pontuacaoTotal = 0;
            int indexDoArremesso = 0;
            try
            {
                for (int quadro = 0; quadro < 10; quadro++)
                {

                    if (_validacoesDeBonus.IsStrike(ref jogadas, ref indexDoArremesso))
                    {
                        _calculosDeBonus.CalcularBonusDoStrike(ref pontuacaoTotal, ref jogadas, ref indexDoArremesso);
                        ProximaJogada(ref indexDoArremesso, 1);
                    }
                    else
                    {
                        if (_validacoesDeBonus.IsSpare(ref jogadas, ref indexDoArremesso))
                        {
                            _calculosDeBonus.CalcularBonusDoSpare(ref pontuacaoTotal, ref jogadas, ref indexDoArremesso);
                        }
                        else
                        {
                            _calculosDeBonus.CalcularSomaSemBonus(ref pontuacaoTotal, ref jogadas, ref indexDoArremesso);
                        }

                        ProximaJogada(ref indexDoArremesso, 2);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ERR001: Ocorreu um erro no processo de contabilização de pontos. Sua pontuação será resetada.");
                pontuacaoTotal = 0;
            }
            return pontuacaoTotal;
        }

        #region Avancar Jogadas
        //Avança ponteiro do index da jogada/arremesso.
        #endregion 
        private void ProximaJogada(ref int index, int avanco)
        {
            try { index = (index + avanco); }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ERR002: Tentativa de acessar index inválido, ao avançar jogada.");
            }
        }

        #region Contabilizar Pinos Derrubados
        //Contablizar pinos derrubados, para a jogada/arremesso corrente
        #endregion 
        public void ContabilizarPinos(int pinos)
        {
            try { jogadas[jogadaIndex] = pinos; }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ERR003: Tentativa de acessar index inválido, ao contabilizar pinos derrubados.");
            }

        }
    }
}
