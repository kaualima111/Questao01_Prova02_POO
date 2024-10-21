using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wfaCaminhão
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void rbOnibus_CheckedChanged(object sender, EventArgs e)
        {
            pbImagens.Image = Properties.Resources.ImagemOnibus;
            ocultaPainel();            
            pnlOnibus.Visible = true;
            
        }
        private void ocultaPainel()
        {
            pnlOnibus.Visible = false;
            pnlCaminhao.Visible = false;
        }

        private void rbCaminhao_CheckedChanged(object sender, EventArgs e)
        {
            pbImagens.Image = Properties.Resources.ImagemCaminhao;
            ocultaPainel();
            pnlCaminhao.Visible = true;
        }

        private void lv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if(tbAno.Text == "")
            {
                MessageBox.Show("Ano não pode ser Vazio");
                tbAno.Focus();
                return;
            }
            if (mtbPlaca.Text=="")
            {
                MessageBox.Show("Placa não pode ser Vazio");
                tbAno.Focus();
                return;
            }

            if (rbCaminhao.Checked == true)
            {
                int anoAtual = DateTime.Now.Year;
                Veiculo v1 = new Caminhao(Convert.ToInt32(tbAno.Text), mtbPlaca.Text, Convert.ToInt32(tbEixos.Text));
                double valorDiaria = v1.CalcularDiaria(anoAtual);

                string[] pr = new string[5];
                pr[0] = mtbPlaca.Text;
                pr[1] = tbAno.Text;
                pr[2] = null;
                pr[3] = tbEixos.Text;
                pr[4] = Convert.ToString(valorDiaria);

                ListViewItem l = new ListViewItem(pr);
                lv1.Items.Add(l);
            }
            if (rbOnibus.Checked == true)
            {
                int anoAtual = DateTime.Now.Year;
                Veiculo v2 = new Onibus(Convert.ToInt32(tbAno.Text), mtbPlaca.Text, Convert.ToInt32(tbAssentos.Text));
                double valorDiaria = v2.CalcularDiaria(anoAtual);

                string[] pr = new string[5];
                pr[0] = mtbPlaca.Text;
                pr[1] = tbAno.Text;
                pr[2] = tbAssentos.Text;
                pr[3] = null;
                pr[4] = Convert.ToString(valorDiaria);

                ListViewItem l = new ListViewItem(pr);
                lv1.Items.Add(l);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbAno.Clear();
            tbAssentos.Clear();
            mtbPlaca.Clear();
            tbEixos.Clear();
        }
    }
}
