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
    public partial class frmDetalheOrdemFechada : Form
    {
        classOS ordemServico;
        List<classOS> listaOS;
        int id;
        public frmDetalheOrdemFechada(int id, List<classOS> listaOS)
        {
            this.id = id;
            this.listaOS = listaOS;
            InitializeComponent();
        }

        private void frmDetalheOrdemFechada_Load(object sender, EventArgs e)
        {
            ConsultaOS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ConsultaOS()
        {
            ordemServico = listaOS.FirstOrDefault(i => i.Id == id);

            txtNome.Text = ordemServico.Nome;
            txtData.Text = ordemServico.DataAbertura;
            txtDataFechamento.Text = ordemServico.DataFechamento;
            txtEnd.Text = ordemServico.Endereco;
            txtPoste.Text = ordemServico.Poste.ToString();
            txtDefeitos.Text = string.Join(",", ordemServico.Defeitos);
            txtServicos.Text = string.Join(",", ordemServico.Servicos);

        }
    }
}
