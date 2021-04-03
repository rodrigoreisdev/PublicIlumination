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
    public partial class Form1 : Form
    {

        List<classOS> listaOS;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaOS = new List<classOS>();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void consultarOrdensAbertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarOrdemAberta frm = new frmConsultarOrdemAberta(listaOS);
            AbrirForm(frm, panel1);
        }

        private void abrirOrdemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrder frm = new frmAddOrder(listaOS);
            AbrirForm(frm, panel1);
        }

        private void fecharOrdensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarOrdemFechada frm = new frmConsultarOrdemFechada(listaOS);
            AbrirForm(frm, panel1);
        }

        static void AbrirForm(Form frm, Panel panel1)
        {
            panel1.Controls.Clear();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.Show();
        }
    }
}
