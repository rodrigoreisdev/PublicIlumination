
namespace Public_Ilumination
{
    partial class frmConsultarOrdemFechada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgOrdens = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOrdens
            // 
            this.dgOrdens.AllowUserToAddRows = false;
            this.dgOrdens.AllowUserToDeleteRows = false;
            this.dgOrdens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrdens.Location = new System.Drawing.Point(90, 140);
            this.dgOrdens.Name = "dgOrdens";
            this.dgOrdens.ReadOnly = true;
            this.dgOrdens.RowHeadersWidth = 62;
            this.dgOrdens.RowTemplate.Height = 28;
            this.dgOrdens.Size = new System.Drawing.Size(1008, 273);
            this.dgOrdens.TabIndex = 10;
            this.dgOrdens.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrdens_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ordens de Serviço Fechadas";
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Location = new System.Drawing.Point(470, 434);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(207, 41);
            this.btnDetalhes.TabIndex = 12;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Selecione e clique em detalhes";
            // 
            // frmConsultarOrdemFechada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 574);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgOrdens);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultarOrdemFechada";
            this.Text = "Consultar Ordens Fechadas";
            this.Load += new System.EventHandler(this.frmConsultarOrdemFechada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrdens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Label label2;
    }
}