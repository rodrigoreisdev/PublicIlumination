using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Public_Ilumination
{

    public partial class frmDetalheOrdemAberta : Form
    {
        classOS ordemServico;
        List<classOS> listaOS;
        int id;
        public frmDetalheOrdemAberta(int id, List<classOS> listaOS)
        {
            this.id = id;
            this.listaOS = listaOS;
            InitializeComponent();
        }

        private void frmDetalheOrdemAberta_Load(object sender, EventArgs e)
        {
            ConsultaOS();
        }

        void ConsultaOS()
        {
            ordemServico = listaOS.FirstOrDefault(i => i.Id == id);
           
            txtNome.Text = ordemServico.Nome;
            txtData.Text = ordemServico.DataAbertura;
            txtEnd.Text = ordemServico.Endereco;
            txtPoste.Text = ordemServico.Poste.ToString();
            txtDefeitos.Text = string.Join(",",ordemServico.Defeitos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rbCheck.Checked==true)
            {
                ordemServico.DataFechamento = txtDataFechamento.Text;
                ordemServico.Servicos = txtServicos.Text.Split(',');
                ordemServico.Status = "Fechada";
                this.Close();
            }
            else
            {
                MessageBox.Show("Confirme o fechamento da Ordem de Serviço!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbCheck_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
