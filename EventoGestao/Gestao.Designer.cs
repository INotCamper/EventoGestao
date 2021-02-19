
namespace EventoGestao
{
    partial class Gestao
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelConsultaSubMenu = new System.Windows.Forms.Panel();
            this.btnConsultaCafe = new System.Windows.Forms.Button();
            this.btnConsultaEvento = new System.Windows.Forms.Button();
            this.btnConsultaPessoa = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnOrganizar = new System.Windows.Forms.Button();
            this.panelCadastroSubMenu = new System.Windows.Forms.Panel();
            this.btnCadastroCafe = new System.Windows.Forms.Button();
            this.btnCadastroEvento = new System.Windows.Forms.Button();
            this.btnCadastroPessoa = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelConsultaSubMenu.SuspendLayout();
            this.panelCadastroSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenu.Controls.Add(this.panelConsultaSubMenu);
            this.panelMenu.Controls.Add(this.btnConsulta);
            this.panelMenu.Controls.Add(this.btnOrganizar);
            this.panelMenu.Controls.Add(this.panelCadastroSubMenu);
            this.panelMenu.Controls.Add(this.btnCadastro);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 661);
            this.panelMenu.TabIndex = 0;
            // 
            // panelConsultaSubMenu
            // 
            this.panelConsultaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelConsultaSubMenu.Controls.Add(this.btnConsultaCafe);
            this.panelConsultaSubMenu.Controls.Add(this.btnConsultaEvento);
            this.panelConsultaSubMenu.Controls.Add(this.btnConsultaPessoa);
            this.panelConsultaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConsultaSubMenu.Location = new System.Drawing.Point(0, 351);
            this.panelConsultaSubMenu.Name = "panelConsultaSubMenu";
            this.panelConsultaSubMenu.Size = new System.Drawing.Size(250, 128);
            this.panelConsultaSubMenu.TabIndex = 5;
            // 
            // btnConsultaCafe
            // 
            this.btnConsultaCafe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultaCafe.FlatAppearance.BorderSize = 0;
            this.btnConsultaCafe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InfoText;
            this.btnConsultaCafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaCafe.ForeColor = System.Drawing.Color.LightGray;
            this.btnConsultaCafe.Location = new System.Drawing.Point(0, 80);
            this.btnConsultaCafe.Name = "btnConsultaCafe";
            this.btnConsultaCafe.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultaCafe.Size = new System.Drawing.Size(250, 40);
            this.btnConsultaCafe.TabIndex = 2;
            this.btnConsultaCafe.Text = "Espaço de Café";
            this.btnConsultaCafe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaCafe.UseVisualStyleBackColor = true;
            this.btnConsultaCafe.Click += new System.EventHandler(this.btnConsultaCafe_Click);
            // 
            // btnConsultaEvento
            // 
            this.btnConsultaEvento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultaEvento.FlatAppearance.BorderSize = 0;
            this.btnConsultaEvento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InfoText;
            this.btnConsultaEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaEvento.ForeColor = System.Drawing.Color.LightGray;
            this.btnConsultaEvento.Location = new System.Drawing.Point(0, 40);
            this.btnConsultaEvento.Name = "btnConsultaEvento";
            this.btnConsultaEvento.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultaEvento.Size = new System.Drawing.Size(250, 40);
            this.btnConsultaEvento.TabIndex = 1;
            this.btnConsultaEvento.Text = "Sala do Evento";
            this.btnConsultaEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaEvento.UseVisualStyleBackColor = true;
            this.btnConsultaEvento.Click += new System.EventHandler(this.btnConsultaEvento_Click);
            // 
            // btnConsultaPessoa
            // 
            this.btnConsultaPessoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultaPessoa.FlatAppearance.BorderSize = 0;
            this.btnConsultaPessoa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InfoText;
            this.btnConsultaPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaPessoa.ForeColor = System.Drawing.Color.LightGray;
            this.btnConsultaPessoa.Location = new System.Drawing.Point(0, 0);
            this.btnConsultaPessoa.Name = "btnConsultaPessoa";
            this.btnConsultaPessoa.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultaPessoa.Size = new System.Drawing.Size(250, 40);
            this.btnConsultaPessoa.TabIndex = 0;
            this.btnConsultaPessoa.Text = "Pessoa";
            this.btnConsultaPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaPessoa.UseVisualStyleBackColor = true;
            this.btnConsultaPessoa.Click += new System.EventHandler(this.btnConsultaPessoa_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InfoText;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.ForeColor = System.Drawing.Color.Silver;
            this.btnConsulta.Location = new System.Drawing.Point(0, 311);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsulta.Size = new System.Drawing.Size(250, 40);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnOrganizar
            // 
            this.btnOrganizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrganizar.FlatAppearance.BorderSize = 0;
            this.btnOrganizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InfoText;
            this.btnOrganizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganizar.ForeColor = System.Drawing.Color.Silver;
            this.btnOrganizar.Location = new System.Drawing.Point(0, 271);
            this.btnOrganizar.Name = "btnOrganizar";
            this.btnOrganizar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrganizar.Size = new System.Drawing.Size(250, 40);
            this.btnOrganizar.TabIndex = 3;
            this.btnOrganizar.Text = "Organizar";
            this.btnOrganizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganizar.UseVisualStyleBackColor = true;
            this.btnOrganizar.Click += new System.EventHandler(this.btnOrganizar_Click);
            // 
            // panelCadastroSubMenu
            // 
            this.panelCadastroSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelCadastroSubMenu.Controls.Add(this.btnCadastroCafe);
            this.panelCadastroSubMenu.Controls.Add(this.btnCadastroEvento);
            this.panelCadastroSubMenu.Controls.Add(this.btnCadastroPessoa);
            this.panelCadastroSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastroSubMenu.Location = new System.Drawing.Point(0, 140);
            this.panelCadastroSubMenu.Name = "panelCadastroSubMenu";
            this.panelCadastroSubMenu.Size = new System.Drawing.Size(250, 131);
            this.panelCadastroSubMenu.TabIndex = 2;
            // 
            // btnCadastroCafe
            // 
            this.btnCadastroCafe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroCafe.FlatAppearance.BorderSize = 0;
            this.btnCadastroCafe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InfoText;
            this.btnCadastroCafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCafe.ForeColor = System.Drawing.Color.LightGray;
            this.btnCadastroCafe.Location = new System.Drawing.Point(0, 80);
            this.btnCadastroCafe.Name = "btnCadastroCafe";
            this.btnCadastroCafe.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCadastroCafe.Size = new System.Drawing.Size(250, 40);
            this.btnCadastroCafe.TabIndex = 2;
            this.btnCadastroCafe.Text = "Espaço de Café";
            this.btnCadastroCafe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCafe.UseVisualStyleBackColor = true;
            this.btnCadastroCafe.Click += new System.EventHandler(this.btnCadastroCafe_Click);
            // 
            // btnCadastroEvento
            // 
            this.btnCadastroEvento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroEvento.FlatAppearance.BorderSize = 0;
            this.btnCadastroEvento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InfoText;
            this.btnCadastroEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroEvento.ForeColor = System.Drawing.Color.LightGray;
            this.btnCadastroEvento.Location = new System.Drawing.Point(0, 40);
            this.btnCadastroEvento.Name = "btnCadastroEvento";
            this.btnCadastroEvento.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCadastroEvento.Size = new System.Drawing.Size(250, 40);
            this.btnCadastroEvento.TabIndex = 1;
            this.btnCadastroEvento.Text = "Sala do Evento";
            this.btnCadastroEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroEvento.UseVisualStyleBackColor = true;
            this.btnCadastroEvento.Click += new System.EventHandler(this.btnCadastroEvento_Click);
            // 
            // btnCadastroPessoa
            // 
            this.btnCadastroPessoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroPessoa.FlatAppearance.BorderSize = 0;
            this.btnCadastroPessoa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InfoText;
            this.btnCadastroPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroPessoa.ForeColor = System.Drawing.Color.LightGray;
            this.btnCadastroPessoa.Location = new System.Drawing.Point(0, 0);
            this.btnCadastroPessoa.Name = "btnCadastroPessoa";
            this.btnCadastroPessoa.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCadastroPessoa.Size = new System.Drawing.Size(250, 40);
            this.btnCadastroPessoa.TabIndex = 0;
            this.btnCadastroPessoa.Text = "Pessoa";
            this.btnCadastroPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroPessoa.UseVisualStyleBackColor = true;
            this.btnCadastroPessoa.Click += new System.EventHandler(this.btnCadastroPessoa_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InfoText;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.ForeColor = System.Drawing.Color.Silver;
            this.btnCadastro.Location = new System.Drawing.Point(0, 100);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastro.Size = new System.Drawing.Size(250, 40);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(834, 661);
            this.panelChildForm.TabIndex = 1;
            // 
            // Gestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Gestao";
            this.ShowIcon = false;
            this.Text = "Gestao";
            this.panelMenu.ResumeLayout(false);
            this.panelConsultaSubMenu.ResumeLayout(false);
            this.panelCadastroSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelConsultaSubMenu;
        private System.Windows.Forms.Button btnConsultaCafe;
        private System.Windows.Forms.Button btnConsultaEvento;
        private System.Windows.Forms.Button btnConsultaPessoa;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnOrganizar;
        private System.Windows.Forms.Panel panelCadastroSubMenu;
        private System.Windows.Forms.Button btnCadastroCafe;
        private System.Windows.Forms.Button btnCadastroEvento;
        private System.Windows.Forms.Button btnCadastroPessoa;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

