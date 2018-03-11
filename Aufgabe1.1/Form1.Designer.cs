namespace Aufgabe1._1
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
            this.lblGutenTag = new System.Windows.Forms.Label();
            this.btnTschuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGutenTag
            // 
            this.lblGutenTag.AutoSize = true;
            this.lblGutenTag.Location = new System.Drawing.Point(33, 44);
            this.lblGutenTag.Name = "lblGutenTag";
            this.lblGutenTag.Size = new System.Drawing.Size(176, 13);
            this.lblGutenTag.TabIndex = 0;
            this.lblGutenTag.Text = "Guten Tag! mein erstes C#-Projekt. ";
            // 
            // btnTschuess
            // 
            this.btnTschuess.Location = new System.Drawing.Point(248, 179);
            this.btnTschuess.Name = "btnTschuess";
            this.btnTschuess.Size = new System.Drawing.Size(102, 28);
            this.btnTschuess.TabIndex = 1;
            this.btnTschuess.Text = "Tschüss";
            this.btnTschuess.UseVisualStyleBackColor = true;
            this.btnTschuess.Click += new System.EventHandler(this.btnTschuess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 233);
            this.Controls.Add(this.btnTschuess);
            this.Controls.Add(this.lblGutenTag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGutenTag;
        private System.Windows.Forms.Button btnTschuess;
    }
}

