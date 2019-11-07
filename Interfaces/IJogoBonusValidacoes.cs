using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJogoDeBoliche.Interfaces
{
    interface IJogoBonusValidacoes
    {
        public bool IsStrike(ref int[] jogadas, ref int indexDoArremesso);
        public bool IsSpare(ref int[] jogadas, ref int posicao);
    }
}
