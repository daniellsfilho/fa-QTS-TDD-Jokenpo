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

        private string VerificarResultadosTesoura(string escolha2)
        {
            switch (escolha2)
            {
                case "PAPEL":
                    return "Venceu!";
                case "PEDRA":
                    return "Perdeu!";
                case "TESOURA":
                    return "Empate";
                default:
                    return "Valor inválido";
            }
        }

        private string VerificarResultadosPapel(string escolha2)
        {
            throw new NotImplementedException();
        }

        private string VerificarResultadosPedra(string escolha2)
        {
            throw new NotImplementedException();
        }
    }
}
