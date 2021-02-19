
namespace EventoGestao
{
    partial class ConsultaCafe
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
            this.btnCloseConsultaCafe = new System.Windows.Forms.Button();
            this.labelEtapa2 = new System.Windows.Forms.Label();
            this.labelEtapa1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelConsultaCafeNome = new System.Windows.Forms.Label();
            this.tbConsultaCafeNome = new System.Windows.Forms.TextBox();
            this.labelConsultaEventoStatus = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.labelConsultaCafe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCloseConsultaCafe
            // 
            this.btnCloseConsultaCafe.Location = new System.Drawing.Point(35, 35);
            this.btnCloseConsultaCafe.Name = "btnCloseConsultaCafe";
            this.btnCloseConsultaCafe.Size = new System.Drawing.Size(30, 30);
            this.btnCloseConsultaCafe.TabIndex = 8;
            this.btnCloseConsultaCafe.Text = "X";
            this.btnCloseConsultaCafe.UseVisualStyleBackColor = true;
            this.btnCloseConsultaCafe.Click += new System.EventHandler(this.btnCloseConsultaCafe_Click);
            // 
            // labelEtapa2
            // 
            this.labelEtapa2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEtapa2.AutoSize = true;
            this.labelEtapa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtapa2.Location = new System.Drawing.Point(335, 275);
            this.labelEtapa2.Name = "labelEtapa2";
            this.labelEtapa2.Size = new System.Drawing.Size(61, 17);
            this.labelEtapa2.TabIndex = 32;
            this.labelEtapa2.Text = "Etapa 2:";
            // 
            // labelEtapa1
            // 
            this.labelEtapa1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEtapa1.AutoSize = true;
            this.labelEtapa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtapa1.Location = new System.Drawing.Point(71, 275);
            this.labelEtapa1.Name = "labelEtapa1";
            this.labelEtapa1.Size = new System.Drawing.Size(61, 17);
            this.labelEtapa1.TabIndex = 31;
            this.labelEtapa1.Text = "Etapa 1:";
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(338, 295);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(250, 220);
            this.listView2.TabIndex = 30;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(74, 295);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 220);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // labelConsultaCafeNome
            // 
            this.labelConsultaCafeNome.AutoSize = true;
            this.labelConsultaCafeNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaCafeNome.Location = new System.Drawing.Point(52, 168);
            this.labelConsultaCafeNome.Name = "labelConsultaCafeNome";
            this.labelConsultaCafeNome.Size = new System.Drawing.Size(119, 17);
            this.labelConsultaCafeNome.TabIndex = 28;
            this.labelConsultaCafeNome.Text = "Nome do espaço:";
            // 
            // tbConsultaCafeNome
            // 
            this.tbConsultaCafeNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConsultaCafeNome.Location = new System.Drawing.Point(177, 165);
            this.tbConsultaCafeNome.Name = "tbConsultaCafeNome";
            this.tbConsultaCafeNome.Size = new System.Drawing.Size(261, 23);
            this.tbConsultaCafeNome.TabIndex = 27;
            // 
            // labelConsultaEventoStatus
            // 
            this.labelConsultaEventoStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConsultaEventoStatus.AutoSize = true;
            this.labelConsultaEventoStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaEventoStatus.Location = new System.Drawing.Point(525, 205);
            this.labelConsultaEventoStatus.Name = "labelConsultaEventoStatus";
            this.labelConsultaEventoStatus.Size = new System.Drawing.Size(48, 17);
            this.labelConsultaEventoStatus.TabIndex = 26;
            this.labelConsultaEventoStatus.Text = "Status";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(504, 161);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 30);
            this.btnConsultar.TabIndex = 25;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // labelConsultaCafe
            // 
            this.labelConsultaCafe.AutoSize = true;
            this.labelConsultaCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaCafe.Location = new System.Drawing.Point(30, 101);
            this.labelConsultaCafe.Name = "labelConsultaCafe";
            this.labelConsultaCafe.Size = new System.Drawing.Size(273, 25);
            this.labelConsultaCafe.TabIndex = 24;
            this.labelConsultaCafe.Text = "Consultar um Espaço de Café";
            // 
            // ConsultaCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.labelEtapa2);
            this.Controls.Add(this.labelEtapa1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelConsultaCafeNome);
            this.Controls.Add(this.tbConsultaCafeNome);
            this.Controls.Add(this.labelConsultaEventoStatus);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.labelConsultaCafe);
            this.Controls.Add(this.btnCloseConsultaCafe);
            this.Name = "ConsultaCafe";
            this.Text = "ConsultaCafe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseConsultaCafe;
        private System.Windows.Forms.Label labelEtapa2;
        private System.Windows.Forms.Label labelEtapa1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelConsultaCafeNome;
        private System.Windows.Forms.TextBox tbConsultaCafeNome;
        private System.Windows.Forms.Label labelConsultaEventoStatus;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label labelConsultaCafe;
    }
}