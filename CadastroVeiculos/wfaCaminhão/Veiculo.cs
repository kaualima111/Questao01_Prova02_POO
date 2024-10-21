using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCaminhão
{
    internal abstract class Veiculo
    {
        private int anoVeiculo;
        private string placa;

        public Veiculo(int anoVeiculo, string placa)
        {
            this.placa = placa;
            this.anoVeiculo = anoVeiculo;
        }

        public int AnoVeiculo { get => anoVeiculo; set => anoVeiculo = value; }
        public string Placa { get => placa; set => placa = value; }

        public abstract double  CalcularDiaria(int anoAtual);

    }
}
