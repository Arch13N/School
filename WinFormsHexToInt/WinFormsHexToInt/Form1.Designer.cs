
namespace WinFormsHexToInt
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDezZahl = new System.Windows.Forms.Label();
            this.txtDezZahl = new System.Windows.Forms.TextBox();
            this.txtHexZahl = new System.Windows.Forms.TextBox();
            this.lblHexZahl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDezZahl
            // 
            this.lblDezZahl.AutoSize = true;
            this.lblDezZahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDezZahl.Location = new System.Drawing.Point(25, 36);
            this.lblDezZahl.Name = "lblDezZahl";
            this.lblDezZahl.Size = new System.Drawing.Size(116, 24);
            this.lblDezZahl.TabIndex = 0;
            this.lblDezZahl.Text = "Dezimalzahl:";
            // 
            // txtDezZahl
            // 
            this.txtDezZahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDezZahl.Location = new System.Drawing.Point(159, 31);
            this.txtDezZahl.MaxLength = 9;
            this.txtDezZahl.Name = "txtDezZahl";
            this.txtDezZahl.Size = new System.Drawing.Size(113, 29);
            this.txtDezZahl.TabIndex = 1;
            this.txtDezZahl.Text = "255";
            this.txtDezZahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDezZahl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDezZahl_KeyPress);
            // 
            // txtHexZahl
            // 
            this.txtHexZahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHexZahl.Location = new System.Drawing.Point(159, 95);
            this.txtHexZahl.MaxLength = 9;
            this.txtHexZahl.Name = "txtHexZahl";
            this.txtHexZahl.Size = new System.Drawing.Size(113, 29);
            this.txtHexZahl.TabIndex = 4;
            this.txtHexZahl.Text = "FF";
            this.txtHexZahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHexZahl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHexZahl_KeyPress);
            // 
            // lblHexZahl
            // 
            this.lblHexZahl.AutoSize = true;
            this.lblHexZahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexZahl.Location = new System.Drawing.Point(25, 100);
            this.lblHexZahl.Name = "lblHexZahl";
            this.lblHexZahl.Size = new System.Drawing.Size(84, 24);
            this.lblHexZahl.TabIndex = 3;
            this.lblHexZahl.Text = "Hexzahl:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 168);
            this.Controls.Add(this.txtHexZahl);
            this.Controls.Add(this.lblHexZahl);
            this.Controls.Add(this.txtDezZahl);
            this.Controls.Add(this.lblDezZahl);
            this.Name = "Form1";
            this.Text = "Zahlensysteme konvertieren";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDezZahl;
        private System.Windows.Forms.TextBox txtDezZahl;
        private System.Windows.Forms.TextBox txtHexZahl;
        private System.Windows.Forms.Label lblHexZahl;
    }
}

