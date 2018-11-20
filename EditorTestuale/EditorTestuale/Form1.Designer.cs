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
            this.lblNomefile = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strumentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBEditor
            // 
            this.txtBEditor.BackColor = System.Drawing.SystemColors.Window;
            this.txtBEditor.Enabled = false;
            this.txtBEditor.Location = new System.Drawing.Point(12, 48);
            this.txtBEditor.Multiline = true;
            this.txtBEditor.Name = "txtBEditor";
            this.txtBEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBEditor.Size = new System.Drawing.Size(408, 279);
            this.txtBEditor.TabIndex = 0;
            // 
            // lblNomefile
            // 
            this.lblNomefile.AutoSize = true;
            this.lblNomefile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNomefile.Location = new System.Drawing.Point(12, 330);
            this.lblNomefile.Name = "lblNomefile";
            this.lblNomefile.Size = new System.Drawing.Size(65, 13);
            this.lblNomefile.TabIndex = 4;
            this.lblNomefile.Text = "Percorso file";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.strumentiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(432, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriToolStripMenuItem,
            this.salvaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.apriToolStripMenuItem.Text = "Apri";
            this.apriToolStripMenuItem.Click += new System.EventHandler(this.apriToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salvaToolStripMenuItem.Text = "Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // strumentiToolStripMenuItem
            // 
            this.strumentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indentaToolStripMenuItem,
            this.numeraToolStripMenuItem});
            this.strumentiToolStripMenuItem.Name = "strumentiToolStripMenuItem";
            this.strumentiToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.strumentiToolStripMenuItem.Text = "Strumenti";
            // 
            // indentaToolStripMenuItem
            // 
            this.indentaToolStripMenuItem.Name = "indentaToolStripMenuItem";
            this.indentaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.indentaToolStripMenuItem.Text = "Indenta";
            this.indentaToolStripMenuItem.Click += new System.EventHandler(this.indentaToolStripMenuItem_Click);
            // 
            // numeraToolStripMenuItem
            // 
            this.numeraToolStripMenuItem.Name = "numeraToolStripMenuItem";
            this.numeraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.numeraToolStripMenuItem.Text = "Numera";
            this.numeraToolStripMenuItem.Click += new System.EventHandler(this.numeraToolStripMenuItem_Click);
            // 
            // EditorTestuale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(432, 352);
            this.Controls.Add(this.lblNomefile);
            this.Controls.Add(this.txtBEditor);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EditorTestuale";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Testuale";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBEditor;
        private System.Windows.Forms.Label lblNomefile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strumentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numeraToolStripMenuItem;
    }
}

