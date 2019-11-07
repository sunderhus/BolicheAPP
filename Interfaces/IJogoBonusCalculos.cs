using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJogoDeBoliche.Interfaces
{
    interface IJogoBonusCalculos
    {
        public void CalcularBonusDoSpare(ref int pontuacaoTotal, ref int[] jogadas, ref int indexDoArremesso);
        public void CalcularBonusDoStrike(ref int pontuacaoTotal, ref int[] jogadas, ref int indexDoArremesso);
        public void CalcularSomaSemBonus(ref int pontuacaoTotal, ref int[] jogadas, ref int indexDoArremesso);
    }
}
