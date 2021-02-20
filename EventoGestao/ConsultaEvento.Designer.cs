
namespace EventoGestao
{
    partial class ConsultaEvento
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
            this.btnCloseConsultaEvento = new System.Windows.Forms.Button();
            this.labelConsultaEvento = new System.Windows.Forms.Label();
            this.labelConsultaEventoStatus = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.labelConsultaEventoNome = new System.Windows.Forms.Label();
            this.tbConsultaEventoNome = new System.Windows.Forms.TextBox();
            this.lvEtapa1 = new System.Windows.Forms.ListView();
            this.lvEtapa2 = new System.Windows.Forms.ListView();
            this.labelEtapa1 = new System.Windows.Forms.Label();
            this.labelEtapa2 = new System.Windows.Forms.Label();
            this.labelSalaProcuradaNome = new System.Windows.Forms.Label();
            this.labelSalaNome = new System.Windows.Forms.Label();
            this.labelSalaLotacao = new System.Windows.Forms.Label();
            this.labelSapaProcuradaLotacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCloseConsultaEvento
            // 
            this.btnCloseConsultaEvento.Location = new System.Drawing.Point(35, 35);
            this.btnCloseConsultaEvento.Name = "btnCloseConsultaEvento";
            this.btnCloseConsultaEvento.Size = new System.Drawing.Size(30, 30);
            this.btnCloseConsultaEvento.TabIndex = 8;
            this.btnCloseConsultaEvento.Text = "X";
            this.btnCloseConsultaEvento.UseVisualStyleBackColor = true;
            this.btnCloseConsultaEvento.Click += new System.EventHandler(this.btnCloseConsultaEvento_Click);
            // 
            // labelConsultaEvento
            // 
            this.labelConsultaEvento.AutoSize = true;
            this.labelConsultaEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaEvento.Location = new System.Drawing.Point(30, 101);
            this.labelConsultaEvento.Name = "labelConsultaEvento";
            this.labelConsultaEvento.Size = new System.Drawing.Size(277, 25);
            this.labelConsultaEvento.TabIndex = 14;
            this.labelConsultaEvento.Text = "Consultar uma Sala de Evento";
            // 
            // labelConsultaEventoStatus
            // 
            this.labelConsultaEventoStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConsultaEventoStatus.AutoSize = true;
            this.labelConsultaEventoStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaEventoStatus.Location = new System.Drawing.Point(525, 205);
            this.labelConsultaEventoStatus.Name = "labelConsultaEventoStatus";
            this.labelConsultaEventoStatus.Size = new System.Drawing.Size(48, 17);
            this.labelConsultaEventoStatus.TabIndex = 17;
            this.labelConsultaEventoStatus.Text = "Status";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(504, 161);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 30);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // labelConsultaEventoNome
            // 
            this.labelConsultaEventoNome.AutoSize = true;
            this.labelConsultaEventoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaEventoNome.Location = new System.Drawing.Point(52, 168);
            this.labelConsultaEventoNome.Name = "labelConsultaEventoNome";
            this.labelConsultaEventoNome.Size = new System.Drawing.Size(101, 17);
            this.labelConsultaEventoNome.TabIndex = 19;
            this.labelConsultaEventoNome.Text = "Nome da Sala:";
            // 
            // tbConsultaEventoNome
            // 
            this.tbConsultaEventoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConsultaEventoNome.Location = new System.Drawing.Point(159, 165);
            this.tbConsultaEventoNome.Name = "tbConsultaEventoNome";
            this.tbConsultaEventoNome.Size = new System.Drawing.Size(261, 23);
            this.tbConsultaEventoNome.TabIndex = 18;
            // 
            // lvEtapa1
            // 
            this.lvEtapa1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lvEtapa1.HideSelection = false;
            this.lvEtapa1.Location = new System.Drawing.Point(74, 295);
            this.lvEtapa1.Name = "lvEtapa1";
            this.lvEtapa1.Size = new System.Drawing.Size(250, 220);
            this.lvEtapa1.TabIndex = 20;
            this.lvEtapa1.UseCompatibleStateImageBehavior = false;
            // 
            // lvEtapa2
            // 
            this.lvEtapa2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lvEtapa2.HideSelection = false;
            this.lvEtapa2.Location = new System.Drawing.Point(338, 295);
            this.lvEtapa2.Name = "lvEtapa2";
            this.lvEtapa2.Size = new System.Drawing.Size(250, 220);
            this.lvEtapa2.TabIndex = 21;
            this.lvEtapa2.UseCompatibleStateImageBehavior = false;
            // 
            // labelEtapa1
            // 
            this.labelEtapa1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEtapa1.AutoSize = true;
            this.labelEtapa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtapa1.Location = new System.Drawing.Point(71, 275);
            this.labelEtapa1.Name = "labelEtapa1";
            this.labelEtapa1.Size = new System.Drawing.Size(61, 17);
            this.labelEtapa1.TabIndex = 22;
            this.labelEtapa1.Text = "Etapa 1:";
            // 
            // labelEtapa2
            // 
            this.labelEtapa2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEtapa2.AutoSize = true;
            this.labelEtapa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtapa2.Location = new System.Drawing.Point(335, 275);
            this.labelEtapa2.Name = "labelEtapa2";
            this.labelEtapa2.Size = new System.Drawing.Size(61, 17);
            this.labelEtapa2.TabIndex = 23;
            this.labelEtapa2.Text = "Etapa 2:";
            // 
            // labelSalaProcuradaNome
            // 
            this.labelSalaProcuradaNome.AutoSize = true;
            this.labelSalaProcuradaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalaProcuradaNome.Location = new System.Drawing.Point(74, 225);
            this.labelSalaProcuradaNome.Name = "labelSalaProcuradaNome";
            this.labelSalaProcuradaNome.Size = new System.Drawing.Size(40, 17);
            this.labelSalaProcuradaNome.TabIndex = 24;
            this.labelSalaProcuradaNome.Text = "Sala:";
            // 
            // labelSalaNome
            // 
            this.labelSalaNome.AutoSize = true;
            this.labelSalaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalaNome.Location = new System.Drawing.Point(120, 225);
            this.labelSalaNome.Name = "labelSalaNome";
            this.labelSalaNome.Size = new System.Drawing.Size(0, 17);
            this.labelSalaNome.TabIndex = 25;
            // 
            // labelSalaLotacao
            // 
            this.labelSalaLotacao.AutoSize = true;
            this.labelSalaLotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalaLotacao.Location = new System.Drawing.Point(404, 225);
            this.labelSalaLotacao.Name = "labelSalaLotacao";
            this.labelSalaLotacao.Size = new System.Drawing.Size(0, 17);
            this.labelSalaLotacao.TabIndex = 27;
            // 
            // labelSapaProcuradaLotacao
            // 
            this.labelSapaProcuradaLotacao.AutoSize = true;
            this.labelSapaProcuradaLotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSapaProcuradaLotacao.Location = new System.Drawing.Point(335, 225);
            this.labelSapaProcuradaLotacao.Name = "labelSapaProcuradaLotacao";
            this.labelSapaProcuradaLotacao.Size = new System.Drawing.Size(63, 17);
            this.labelSapaProcuradaLotacao.TabIndex = 26;
            this.labelSapaProcuradaLotacao.Text = "Lotação:";
            // 
            // ConsultaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.labelSalaLotacao);
            this.Controls.Add(this.labelSapaProcuradaLotacao);
            this.Controls.Add(this.labelSalaNome);
            this.Controls.Add(this.labelSalaProcuradaNome);
            this.Controls.Add(this.labelEtapa2);
            this.Controls.Add(this.labelEtapa1);
            this.Controls.Add(this.lvEtapa2);
            this.Controls.Add(this.lvEtapa1);
            this.Controls.Add(this.labelConsultaEventoNome);
            this.Controls.Add(this.tbConsultaEventoNome);
            this.Controls.Add(this.labelConsultaEventoStatus);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.labelConsultaEvento);
            this.Controls.Add(this.btnCloseConsultaEvento);
            this.Name = "ConsultaEvento";
            this.Text = "ConsultaEvento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseConsultaEvento;
        private System.Windows.Forms.Label labelConsultaEvento;
        private System.Windows.Forms.Label labelConsultaEventoStatus;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label labelConsultaEventoNome;
        private System.Windows.Forms.TextBox tbConsultaEventoNome;
        private System.Windows.Forms.ListView lvEtapa1;
        private System.Windows.Forms.ListView lvEtapa2;
        private System.Windows.Forms.Label labelEtapa1;
        private System.Windows.Forms.Label labelEtapa2;
        private System.Windows.Forms.Label labelSalaProcuradaNome;
        private System.Windows.Forms.Label labelSalaNome;
        private System.Windows.Forms.Label labelSalaLotacao;
        private System.Windows.Forms.Label labelSapaProcuradaLotacao;
    }
}