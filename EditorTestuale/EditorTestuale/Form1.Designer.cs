namespace EditorTestuale
{
    partial class EditorTestuale
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBEditor = new System.Windows.Forms.TextBox();
            this.btnScelta = new System.Windows.Forms.Button();
            this.btnIndenta = new System.Windows.Forms.Button();
            this.lblNomefile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBEditor
            // 
            this.txtBEditor.Location = new System.Drawing.Point(12, 12);
            this.txtBEditor.Multiline = true;
            this.txtBEditor.Name = "txtBEditor";
            this.txtBEditor.Size = new System.Drawing.Size(272, 200);
            this.txtBEditor.TabIndex = 0;
            // 
            // btnScelta
            // 
            this.btnScelta.Location = new System.Drawing.Point(12, 243);
            this.btnScelta.Name = "btnScelta";
            this.btnScelta.Size = new System.Drawing.Size(75, 23);
            this.btnScelta.TabIndex = 2;
            this.btnScelta.Text = "Scegli il file";
            this.btnScelta.UseVisualStyleBackColor = true;
            this.btnScelta.Click += new System.EventHandler(this.btnScelta_Click);
            // 
            // btnIndenta
            // 
            this.btnIndenta.Location = new System.Drawing.Point(304, 12);
            this.btnIndenta.Name = "btnIndenta";
            this.btnIndenta.Size = new System.Drawing.Size(75, 23);
            this.btnIndenta.TabIndex = 3;
            this.btnIndenta.Text = "Indenta";
            this.btnIndenta.UseVisualStyleBackColor = true;
            // 
            // lblNomefile
            // 
            this.lblNomefile.AutoSize = true;
            this.lblNomefile.Location = new System.Drawing.Point(93, 248);
            this.lblNomefile.Name = "lblNomefile";
            this.lblNomefile.Size = new System.Drawing.Size(0, 13);
            this.lblNomefile.TabIndex = 4;
            // 
            // EditorTestuale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 278);
            this.Controls.Add(this.lblNomefile);
            this.Controls.Add(this.btnIndenta);
            this.Controls.Add(this.btnScelta);
            this.Controls.Add(this.txtBEditor);
            this.Name = "EditorTestuale";
            this.Text = "Editor Testuale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBEditor;
        private System.Windows.Forms.Button btnScelta;
        private System.Windows.Forms.Button btnIndenta;
        private System.Windows.Forms.Label lblNomefile;
    }
}

