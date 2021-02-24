
namespace EventoGestao
{
    partial class Organizar
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
            this.btnOrganizar = new System.Windows.Forms.Button();
            this.btnCloseOrganizar = new System.Windows.Forms.Button();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.lvStatus = new System.Windows.Forms.ListView();
            this.labelOrganizar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrganizar
            // 
            this.btnOrganizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnOrganizar.Location = new System.Drawing.Point(67, 171);
            this.btnOrganizar.Name = "btnOrganizar";
            this.btnOrganizar.Size = new System.Drawing.Size(225, 35);
            this.btnOrganizar.TabIndex = 0;
            this.btnOrganizar.Text = "Organizar Treinamento";
            this.btnOrganizar.UseVisualStyleBackColor = true;
            this.btnOrganizar.Click += new System.EventHandler(this.btnOrganizar_Click);
            // 
            // btnCloseOrganizar
            // 
            this.btnCloseOrganizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseOrganizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCloseOrganizar.Location = new System.Drawing.Point(35, 35);
            this.btnCloseOrganizar.Name = "btnCloseOrganizar";
            this.btnCloseOrganizar.Size = new System.Drawing.Size(30, 30);
            this.btnCloseOrganizar.TabIndex = 8;
            this.btnCloseOrganizar.Text = "X";
            this.btnCloseOrganizar.UseVisualStyleBackColor = true;
            this.btnCloseOrganizar.Click += new System.EventHandler(this.btnCloseOrganizar_Click);
            // 
            // pbStatus
            // 
            this.pbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbStatus.Location = new System.Drawing.Point(67, 257);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(524, 23);
            this.pbStatus.TabIndex = 9;
            // 
            // lvStatus
            // 
            this.lvStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lvStatus.HideSelection = false;
            this.lvStatus.Location = new System.Drawing.Point(67, 286);
            this.lvStatus.Name = "lvStatus";
            this.lvStatus.Size = new System.Drawing.Size(524, 181);
            this.lvStatus.TabIndex = 10;
            this.lvStatus.UseCompatibleStateImageBehavior = false;
            // 
            // labelOrganizar
            // 
            this.labelOrganizar.AutoSize = true;
            this.labelOrganizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrganizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelOrganizar.Location = new System.Drawing.Point(30, 101);
            this.labelOrganizar.Name = "labelOrganizar";
            this.labelOrganizar.Size = new System.Drawing.Size(229, 25);
            this.labelOrganizar.TabIndex = 25;
            this.labelOrganizar.Text = "Organizar o Treinamento";
            // 
            // Organizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.labelOrganizar);
            this.Controls.Add(this.lvStatus);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.btnCloseOrganizar);
            this.Controls.Add(this.btnOrganizar);
            this.Name = "Organizar";
            this.Text = "Organizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrganizar;
        private System.Windows.Forms.Button btnCloseOrganizar;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.ListView lvStatus;
        private System.Windows.Forms.Label labelOrganizar;
    }
}