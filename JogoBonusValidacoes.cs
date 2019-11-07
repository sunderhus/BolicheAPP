using ProjetoJogoDeBoliche.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJogoDeBoliche
{
    public class JogoBonusValidacoes : IJogoBonusValidacoes
    {
        public bool IsStrike(ref int []jogadas,ref int indexDoArremesso)
        {
            return jogadas[indexDoArremesso] == 10;
        }

        public bool IsSpare(ref int[] jogadas, ref int posicao)
        {
            bool resp = false;
            if (jogadas[posicao] + jogadas[posicao + 1] == 10)
            {
                resp = true;
            }
            return resp;
        }
    }
}
