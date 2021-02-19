
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnCloseOrganizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrganizar
            // 
            this.btnOrganizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizar.Location = new System.Drawing.Point(67, 119);
            this.btnOrganizar.Name = "btnOrganizar";
            this.btnOrganizar.Size = new System.Drawing.Size(225, 35);
            this.btnOrganizar.TabIndex = 0;
            this.btnOrganizar.Text = "Organizar Treinamento";
            this.btnOrganizar.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(64, 270);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(48, 17);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Status";
            // 
            // btnCloseOrganizar
            // 
            this.btnCloseOrganizar.Location = new System.Drawing.Point(35, 35);
            this.btnCloseOrganizar.Name = "btnCloseOrganizar";
            this.btnCloseOrganizar.Size = new System.Drawing.Size(30, 30);
            this.btnCloseOrganizar.TabIndex = 8;
            this.btnCloseOrganizar.Text = "X";
            this.btnCloseOrganizar.UseVisualStyleBackColor = true;
            this.btnCloseOrganizar.Click += new System.EventHandler(this.btnCloseOrganizar_Click);
            // 
            // Organizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btnCloseOrganizar);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnOrganizar);
            this.Name = "Organizar";
            this.Text = "Organizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrganizar;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnCloseOrganizar;
    }
}