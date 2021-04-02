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
    public partial class frmConsultarOrdemAberta : Form
    {
        List<classOS> listaOS;
        int id;

        public frmConsultarOrdemAberta(List<classOS> listaOS)
        {
            this.listaOS = listaOS;
            InitializeComponent();
        }

        private void frmConsultarOrdemAberta_Load(object sender, EventArgs e)
        {
            CarregarLista();


        }
        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            if (listaOS != null)
            {
                frmDetalheOrdemAberta frm = new frmDetalheOrdemAberta(id, listaOS);
                frm.Show();

            }
        }
        private void dgOrdens_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgOrdens.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        public void CarregarLista()
        {
            if (listaOS != null)
            {
                dgOrdens.DataSource = listaOS.FindAll(i => i.Status == "Aberta");
                dgOrdens.Columns[0].Visible = false;
                dgOrdens.Columns[3].Visible = false;
                dgOrdens.Columns["Nome"].HeaderText = "Reclamante";
                dgOrdens.Columns["DataAbertura"].HeaderText = "Data de abertura";
                dgOrdens.Columns["Poste"].HeaderText = "Nº poste";
                dgOrdens.Columns["Endereco"].HeaderText = "Endereço";
                dgOrdens.ReadOnly = true;
                dgOrdens.MultiSelect = false;
                dgOrdens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
        }

    }
}
