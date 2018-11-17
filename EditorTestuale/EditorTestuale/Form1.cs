using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.CodeAnalysis.CSharp;
using System.Text;

namespace EditorTestuale
{
    public partial class EditorTestuale : Form
    {

        string currentFilePath = string.Empty;

        public EditorTestuale()
        {
            InitializeComponent();
        }

        private void btnScelta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CS Files|*.cs";
            openFileDialog1.Title = "Select a CS File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog1.FileName;
                txtBEditor.Enabled = true;
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                txtBEditor.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void btnIndenta_Click(object sender, EventArgs e)
        {
            txtBEditor.Text = indentaCSharp(txtBEditor.Text);
        }


        #region Business Logic
        public String indentaCSharp(String text)
        {
            return CSharpSyntaxTree.ParseText(text).GetRoot().ToFullString();
        }
        #endregion

        private void btnSalva_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "File di testo|*.txt";
            saveFileDialog1.Title = "Salva file di testo";
            saveFileDialog1.ShowDialog();
            saveFileDialog1.InitialDirectory = "C:\\Desktop";
            if (saveFileDialog1.FileName != "")
            {  
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();  
            }     
        }
    }
}
