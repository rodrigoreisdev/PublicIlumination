
namespace Public_Ilumination
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirOrdemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOrdensAbertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharOrdensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirOrdemDeServiçoToolStripMenuItem,
            this.consultarOrdensAbertasToolStripMenuItem,
            this.fecharOrdensToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1313, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // abrirOrdemDeServiçoToolStripMenuItem
            // 
            this.abrirOrdemDeServiçoToolStripMenuItem.Name = "abrirOrdemDeServiçoToolStripMenuItem";
            this.abrirOrdemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(215, 29);
            this.abrirOrdemDeServiçoToolStripMenuItem.Text = "Abrir Ordem de Serviço";
            this.abrirOrdemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.abrirOrdemDeServiçoToolStripMenuItem_Click);
            // 
            // consultarOrdensAbertasToolStripMenuItem
            // 
            this.consultarOrdensAbertasToolStripMenuItem.Name = "consultarOrdensAbertasToolStripMenuItem";
            this.consultarOrdensAbertasToolStripMenuItem.Size = new System.Drawing.Size(232, 29);
            this.consultarOrdensAbertasToolStripMenuItem.Text = "Consultar Ordens Abertas";
            this.consultarOrdensAbertasToolStripMenuItem.Click += new System.EventHandler(this.consultarOrdensAbertasToolStripMenuItem_Click);
            // 
            // fecharOrdensToolStripMenuItem
            // 
            this.fecharOrdensToolStripMenuItem.Name = "fecharOrdensToolStripMenuItem";
            this.fecharOrdensToolStripMenuItem.Size = new System.Drawing.Size(244, 29);
            this.fecharOrdensToolStripMenuItem.Text = "Consultar Ordens Fechadas";
            this.fecharOrdensToolStripMenuItem.Click += new System.EventHandler(this.fecharOrdensToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 1019);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Projeto Iluminação Pública";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirOrdemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarOrdensAbertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharOrdensToolStripMenuItem;
    }
}

