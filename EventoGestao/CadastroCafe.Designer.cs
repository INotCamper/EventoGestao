
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
            this.labelCadastroCafeStatus = new System.Windows.Forms.Label();
            this.btnCadastrarEvento = new System.Windows.Forms.Button();
            this.labelNomeSala = new System.Windows.Forms.Label();
            this.tbCafeNome = new System.Windows.Forms.TextBox();
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
            // labelCadastroCafeStatus
            // 
            this.labelCadastroCafeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCadastroCafeStatus.AutoSize = true;
            this.labelCadastroCafeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroCafeStatus.Location = new System.Drawing.Point(296, 337);
            this.labelCadastroCafeStatus.Name = "labelCadastroCafeStatus";
            this.labelCadastroCafeStatus.Size = new System.Drawing.Size(48, 17);
            this.labelCadastroCafeStatus.TabIndex = 22;
            this.labelCadastroCafeStatus.Text = "Status";
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
            this.btnCadastrarEvento.Click += new System.EventHandler(this.btnCadastrarEvento_Click);
            // 
            // labelNomeSala
            // 
            this.labelNomeSala.AutoSize = true;
            this.labelNomeSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeSala.Location = new System.Drawing.Point(54, 193);
            this.labelNomeSala.Name = "labelNomeSala";
            this.labelNomeSala.Size = new System.Drawing.Size(99, 17);
            this.labelNomeSala.TabIndex = 18;
            this.labelNomeSala.Text = "Nome da sala:";
            // 
            // tbCafeNome
            // 
            this.tbCafeNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCafeNome.Location = new System.Drawing.Point(163, 190);
            this.tbCafeNome.Name = "tbCafeNome";
            this.tbCafeNome.Size = new System.Drawing.Size(265, 23);
            this.tbCafeNome.TabIndex = 17;
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
            this.Controls.Add(this.labelCadastroCafeStatus);
            this.Controls.Add(this.btnCadastrarEvento);
            this.Controls.Add(this.labelNomeSala);
            this.Controls.Add(this.tbCafeNome);
            this.Controls.Add(this.labelCadastroCafe);
            this.Controls.Add(this.btnCloseCadastroCafe);
            this.Name = "CadastroCafe";
            this.Text = "CadastroCafe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseCadastroCafe;
        private System.Windows.Forms.Label labelCadastroCafeStatus;
        private System.Windows.Forms.Button btnCadastrarEvento;
        private System.Windows.Forms.Label labelNomeSala;
        private System.Windows.Forms.TextBox tbCafeNome;
        private System.Windows.Forms.Label labelCadastroCafe;
    }
}