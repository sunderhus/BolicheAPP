using ProjetoJogoDeBoliche.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJogoDeBoliche
{
    public class JogoBonusCalculos : IJogoBonusCalculos
    {
        public void CalcularBonusDoSpare(ref int pontuacaoTotal, ref int[] jogadas, ref int indexDoArremesso)
        {
            pontuacaoTotal += 10 + jogadas[indexDoArremesso + 2];
        }
        public void CalcularBonusDoStrike(ref int pontuacaoTotal, ref int[] jogadas, ref int indexDoArremesso)
        {
            pontuacaoTotal += 10 + jogadas[indexDoArremesso + 1] + jogadas[indexDoArremesso + 2];
        }
        public void CalcularSomaSemBonus(ref int pontuacaoTotal, ref int[] jogadas, ref int indexDoArremesso)
        {
            pontuacaoTotal += jogadas[indexDoArremesso] + jogadas[indexDoArremesso + 1];
        }
    }
}
