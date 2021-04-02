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
    public partial class frmAddOrder : Form
    {
        classOS ordemServico;
        List<classOS> listaOS;

        public frmAddOrder(List<classOS> listaOS)
        {
            this.listaOS = listaOS;
            InitializeComponent();
        }

        private void frmAddOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnGerarOS_Click(object sender, EventArgs e)
        {
            AddOrdem();
            Clear();
            MessageBox.Show("Ordem aberta com sucesso!");
            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void AddOrdem()
        {
            int id = listaOS.Count + 1;
            this.ordemServico = new classOS(id);
            ordemServico.Nome = txtNome.Text;
            ordemServico.DataAbertura = txtData.Text;
            ordemServico.Poste = int.Parse(txtPoste.Text);
            ordemServico.Endereco = txtEnd.Text;
            ordemServico.Defeitos = txtDefeitos.Text.Split(',');
            ordemServico.Status = "Aberta";

            listaOS.Add(ordemServico);
        }

        void Clear()
        {
            txtNome.Text = "";
            txtData.Text = "";
            txtEnd.Text = "";
            txtPoste.Text = "";
            txtDefeitos.Text = "";
        }

        private void txtPoste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                
                e.Handled = true;
            }
        }
    }
}
