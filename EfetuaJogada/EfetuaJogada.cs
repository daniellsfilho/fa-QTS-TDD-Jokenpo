using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fa_QTS_tdd_jokenpo
{
    public class EfetuaJogada
    {
        public string EfetuarJogada(string escolha1, string escolha2)
        {
            List<string> escolhas = new List<string>()
            {
                "PEDRA", "PAPEL", "TESOURA"
            };

            string combate = escolha1 + " X " + escolha2;

            int deltaEscolhas = escolhas.IndexOf(escolha1) - escolhas.IndexOf(escolha2);

            switch (deltaEscolhas)
            {
                case 0:
                    return combate + ": EMPATOU!";
                case 1:
                case -2:
                    return combate + ": " + escolha1 + " VENCEU!";
                case -1:
                case 2:
                    return combate + ": " + escolha2 + " VENCEU!";
                default: 
                    return "Valor inválido";
            }
        }
    }
}
