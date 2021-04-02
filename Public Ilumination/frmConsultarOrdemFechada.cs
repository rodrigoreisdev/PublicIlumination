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
    public partial class frmConsultarOrdemFechada : Form
    {
        List<classOS> listaOS;
        int id;

        public frmConsultarOrdemFechada(List<classOS> listaOS)
        {
            this.listaOS = listaOS;
            InitializeComponent();
        }

        private void frmConsultarOrdemFechada_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            if (listaOS != null)
            {
                frmDetalheOrdemFechada frm = new frmDetalheOrdemFechada(id, listaOS);
                frm.Show();

            }
        }
        private void dgOrdens_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgOrdens.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        void CarregarLista()
        {
            if (listaOS != null)
            {
                dgOrdens.DataSource = listaOS.FindAll(i => i.Status == "Fechada");
                dgOrdens.Columns[0].Visible = false;
                dgOrdens.Columns["Nome"].HeaderText = "Reclamante";
                dgOrdens.Columns["DataAbertura"].HeaderText = "Data de abertura";
                dgOrdens.Columns["DataFechamento"].HeaderText = "Data de fechamento";
                dgOrdens.Columns["Poste"].HeaderText = "Nº poste";
                dgOrdens.Columns["Endereco"].HeaderText = "Endereço";
                dgOrdens.ReadOnly = true;
                dgOrdens.MultiSelect = false;
                dgOrdens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
        }

    }
}
