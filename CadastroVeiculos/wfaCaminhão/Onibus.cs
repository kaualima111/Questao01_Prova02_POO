
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCaminhão
{
    internal class Onibus : Veiculo
    {
        private int assentos;

        public Onibus (int ano, string placa, int assentos) : base(ano,placa)
        {
            this.assentos = assentos;
        }

        public int Assentos { get => assentos; set => assentos = value; }

        public override double CalcularDiaria(int anoAtual)
        {
            return (30 * Assentos) - ((anoAtual - AnoVeiculo) * 70);
        }
    }
}
