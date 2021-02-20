
namespace EventoGestao
{
    partial class CadastroEvento
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
            this.btnCloseCadastroEvento = new System.Windows.Forms.Button();
            this.labelCadastroEvento = new System.Windows.Forms.Label();
            this.tbEventoNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLotacao = new System.Windows.Forms.Label();
            this.numLotacao = new System.Windows.Forms.NumericUpDown();
            this.btnCadastrarEvento = new System.Windows.Forms.Button();
            this.labelCadastroEventoStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numLotacao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseCadastroEvento
            // 
            this.btnCloseCadastroEvento.Location = new System.Drawing.Point(35, 35);
            this.btnCloseCadastroEvento.Name = "btnCloseCadastroEvento";
            this.btnCloseCadastroEvento.Size = new System.Drawing.Size(30, 30);
            this.btnCloseCadastroEvento.TabIndex = 8;
            this.btnCloseCadastroEvento.Text = "X";
            this.btnCloseCadastroEvento.UseVisualStyleBackColor = true;
            this.btnCloseCadastroEvento.Click += new System.EventHandler(this.btnCloseCadastroEvento_Click);
            // 
            // labelCadastroEvento
            // 
            this.labelCadastroEvento.AutoSize = true;
            this.labelCadastroEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroEvento.Location = new System.Drawing.Point(30, 101);
            this.labelCadastroEvento.Name = "labelCadastroEvento";
            this.labelCadastroEvento.Size = new System.Drawing.Size(232, 25);
            this.labelCadastroEvento.TabIndex = 9;
            this.labelCadastroEvento.Text = "Cadastrar sala de Evento";
            // 
            // tbEventoNome
            // 
            this.tbEventoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventoNome.Location = new System.Drawing.Point(162, 159);
            this.tbEventoNome.Name = "tbEventoNome";
            this.tbEventoNome.Size = new System.Drawing.Size(265, 23);
            this.tbEventoNome.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome da sala:";
            // 
            // labelLotacao
            // 
            this.labelLotacao.AutoSize = true;
            this.labelLotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLotacao.Location = new System.Drawing.Point(89, 227);
            this.labelLotacao.Name = "labelLotacao";
            this.labelLotacao.Size = new System.Drawing.Size(63, 17);
            this.labelLotacao.TabIndex = 12;
            this.labelLotacao.Text = "Lotação:";
            // 
            // numLotacao
            // 
            this.numLotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLotacao.Location = new System.Drawing.Point(162, 225);
            this.numLotacao.Name = "numLotacao";
            this.numLotacao.Size = new System.Drawing.Size(120, 23);
            this.numLotacao.TabIndex = 13;
            // 
            // btnCadastrarEvento
            // 
            this.btnCadastrarEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEvento.Location = new System.Drawing.Point(273, 389);
            this.btnCadastrarEvento.Name = "btnCadastrarEvento";
            this.btnCadastrarEvento.Size = new System.Drawing.Size(100, 30);
            this.btnCadastrarEvento.TabIndex = 14;
            this.btnCadastrarEvento.Text = "Cadastrar";
            this.btnCadastrarEvento.UseVisualStyleBackColor = true;
            this.btnCadastrarEvento.Click += new System.EventHandler(this.btnCadastrarEvento_Click);
            // 
            // labelCadastroEventoStatus
            // 
            this.labelCadastroEventoStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCadastroEventoStatus.AutoSize = true;
            this.labelCadastroEventoStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroEventoStatus.Location = new System.Drawing.Point(296, 337);
            this.labelCadastroEventoStatus.Name = "labelCadastroEventoStatus";
            this.labelCadastroEventoStatus.Size = new System.Drawing.Size(48, 17);
            this.labelCadastroEventoStatus.TabIndex = 15;
            this.labelCadastroEventoStatus.Text = "Status";
            // 
            // CadastroEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.labelCadastroEventoStatus);
            this.Controls.Add(this.btnCadastrarEvento);
            this.Controls.Add(this.numLotacao);
            this.Controls.Add(this.labelLotacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEventoNome);
            this.Controls.Add(this.labelCadastroEvento);
            this.Controls.Add(this.btnCloseCadastroEvento);
            this.Name = "CadastroEvento";
            this.Text = "CadastroEvento";
            ((System.ComponentModel.ISupportInitialize)(this.numLotacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseCadastroEvento;
        private System.Windows.Forms.Label labelCadastroEvento;
        private System.Windows.Forms.TextBox tbEventoNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLotacao;
        private System.Windows.Forms.NumericUpDown numLotacao;
        private System.Windows.Forms.Button btnCadastrarEvento;
        private System.Windows.Forms.Label labelCadastroEventoStatus;
    }
}