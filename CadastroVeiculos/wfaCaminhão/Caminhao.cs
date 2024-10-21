using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCaminhão
{
    internal class Caminhao : Veiculo
    {
        private int eixos;
        public Caminhao(int ano, string placa, int eixos) : base(ano, placa)
        {
            this.eixos = eixos;
        }

        public int Eixos { get => eixos; set => eixos = value; }

        public override double CalcularDiaria(int anoAtual)
        {
            return (300 * Eixos) - ((anoAtual - AnoVeiculo) * 50);
        }
    }
}

