
namespace EventoGestao
{
    partial class CadastroCafe
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
            this.btnCloseCadastroCafe = new System.Windows.Forms.Button();
            this.labelCadastroEventoStatus = new System.Windows.Forms.Label();
            this.btnCadastrarEvento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEventoNome = new System.Windows.Forms.TextBox();
            this.labelCadastroCafe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCloseCadastroCafe
            // 
            this.btnCloseCadastroCafe.Location = new System.Drawing.Point(35, 35);
            this.btnCloseCadastroCafe.Name = "btnCloseCadastroCafe";
            this.btnCloseCadastroCafe.Size = new System.Drawing.Size(30, 30);
            this.btnCloseCadastroCafe.TabIndex = 8;
            this.btnCloseCadastroCafe.Text = "X";
            this.btnCloseCadastroCafe.UseVisualStyleBackColor = true;
            this.btnCloseCadastroCafe.Click += new System.EventHandler(this.btnCloseCadastroCafe_Click);
            // 
            // labelCadastroEventoStatus
            // 
            this.labelCadastroEventoStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCadastroEventoStatus.AutoSize = true;
            this.labelCadastroEventoStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroEventoStatus.Location = new System.Drawing.Point(296, 337);
            this.labelCadastroEventoStatus.Name = "labelCadastroEventoStatus";
            this.labelCadastroEventoStatus.Size = new System.Drawing.Size(48, 17);
            this.labelCadastroEventoStatus.TabIndex = 22;
            this.labelCadastroEventoStatus.Text = "Status";
            // 
            // btnCadastrarEvento
            // 
            this.btnCadastrarEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEvento.Location = new System.Drawing.Point(273, 389);
            this.btnCadastrarEvento.Name = "btnCadastrarEvento";
            this.btnCadastrarEvento.Size = new System.Drawing.Size(100, 30);
            this.btnCadastrarEvento.TabIndex = 21;
            this.btnCadastrarEvento.Text = "Cadastrar";
            this.btnCadastrarEvento.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome da sala:";
            // 
            // tbEventoNome
            // 
            this.tbEventoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventoNome.Location = new System.Drawing.Point(163, 190);
            this.tbEventoNome.Name = "tbEventoNome";
            this.tbEventoNome.Size = new System.Drawing.Size(265, 23);
            this.tbEventoNome.TabIndex = 17;
            // 
            // labelCadastroCafe
            // 
            this.labelCadastroCafe.AutoSize = true;
            this.labelCadastroCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroCafe.Location = new System.Drawing.Point(30, 105);
            this.labelCadastroCafe.Name = "labelCadastroCafe";
            this.labelCadastroCafe.Size = new System.Drawing.Size(236, 25);
            this.labelCadastroCafe.TabIndex = 16;
            this.labelCadastroCafe.Text = "Cadastrar espaço de café";
            // 
            // CadastroCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.labelCadastroEventoStatus);
            this.Controls.Add(this.btnCadastrarEvento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEventoNome);
            this.Controls.Add(this.labelCadastroCafe);
            this.Controls.Add(this.btnCloseCadastroCafe);
            this.Name = "CadastroCafe";
            this.Text = "CadastroCafe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseCadastroCafe;
        private System.Windows.Forms.Label labelCadastroEventoStatus;
        private System.Windows.Forms.Button btnCadastrarEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEventoNome;
        private System.Windows.Forms.Label labelCadastroCafe;
    }
}