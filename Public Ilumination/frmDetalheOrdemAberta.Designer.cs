
namespace Public_Ilumination
{
    partial class frmDetalheOrdemAberta
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
            this.txtDefeitos = new System.Windows.Forms.RichTextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtPoste = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServicos = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDataFechamento = new System.Windows.Forms.MaskedTextBox();
            this.rbCheck = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtDefeitos
            // 
            this.txtDefeitos.Location = new System.Drawing.Point(56, 410);
            this.txtDefeitos.Name = "txtDefeitos";
            this.txtDefeitos.ReadOnly = true;
            this.txtDefeitos.Size = new System.Drawing.Size(691, 106);
            this.txtDefeitos.TabIndex = 16;
            this.txtDefeitos.Text = "";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(248, 299);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.ReadOnly = true;
            this.txtEnd.Size = new System.Drawing.Size(499, 26);
            this.txtEnd.TabIndex = 15;
            // 
            // txtPoste
            // 
            this.txtPoste.Location = new System.Drawing.Point(248, 245);
            this.txtPoste.Name = "txtPoste";
            this.txtPoste.ReadOnly = true;
            this.txtPoste.Size = new System.Drawing.Size(100, 26);
            this.txtPoste.TabIndex = 14;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(248, 195);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(110, 26);
            this.txtData.TabIndex = 13;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.Location = new System.Drawing.Point(248, 142);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(499, 26);
            this.txtNome.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Defeitos apresentados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Número do poste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data de abertura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Reclamante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fechamento de Ordem de Serviço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Serviços realizados";
            // 
            // txtServicos
            // 
            this.txtServicos.Location = new System.Drawing.Point(56, 573);
            this.txtServicos.Name = "txtServicos";
            this.txtServicos.Size = new System.Drawing.Size(691, 106);
            this.txtServicos.TabIndex = 1;
            this.txtServicos.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 767);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fechar OS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 767);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 705);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Data de fechamento";
            // 
            // txtDataFechamento
            // 
            this.txtDataFechamento.Location = new System.Drawing.Point(248, 704);
            this.txtDataFechamento.Mask = "00/00/0000";
            this.txtDataFechamento.Name = "txtDataFechamento";
            this.txtDataFechamento.Size = new System.Drawing.Size(110, 26);
            this.txtDataFechamento.TabIndex = 2;
            this.txtDataFechamento.ValidatingType = typeof(System.DateTime);
            // 
            // rbCheck
            // 
            this.rbCheck.AutoSize = true;
            this.rbCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCheck.Location = new System.Drawing.Point(486, 705);
            this.rbCheck.Name = "rbCheck";
            this.rbCheck.Size = new System.Drawing.Size(261, 29);
            this.rbCheck.TabIndex = 3;
            this.rbCheck.TabStop = true;
            this.rbCheck.Text = "Fechar Ordem de Serviço";
            this.rbCheck.UseVisualStyleBackColor = true;
            // 
            // frmDetalheOrdemAberta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 878);
            this.Controls.Add(this.rbCheck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServicos);
            this.Controls.Add(this.txtDefeitos);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtPoste);
            this.Controls.Add(this.txtDataFechamento);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmDetalheOrdemAberta";
            this.Text = "Fechamento de Ordem de Serviço";
            this.Load += new System.EventHandler(this.frmDetalheOrdemAberta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDefeitos;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtPoste;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtServicos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtDataFechamento;
        private System.Windows.Forms.RadioButton rbCheck;
    }
}