using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJogoDeBoliche.Interfaces
{
    interface IJogoOperacoes
    {
        public int ObterPontuacao();
        public void ContabilizarPinos(int pinos);
    }
}
