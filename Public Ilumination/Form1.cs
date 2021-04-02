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
            frm.Show();
        }

        private void abrirOrdemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrder frm = new frmAddOrder(listaOS);
            frm.Show();
        }

        private void fecharOrdensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarOrdemFechada frm = new frmConsultarOrdemFechada(listaOS);
            frm.Show();
        }
    }
}
