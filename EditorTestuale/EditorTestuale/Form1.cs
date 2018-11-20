using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace EditorTestuale
{
    public partial class EditorTestuale : Form
    {
        public EditorTestuale()
        {
            InitializeComponent();
        }

        #region  Events Management

        private void indentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBEditor.Text = IndentaCSharp(txtBEditor.Text);
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBEditor.Text = ReadCSFile();
            txtBEditor.Enabled = true;
            lblNomefile.Text = "Percorso file: " + _currentFilePath;
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileInPath();
        }

        private void numeraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Business Logic
        public string IndentaCSharp(string text)
        {
            return CSharpSyntaxTree.ParseText(text).GetRoot().NormalizeWhitespace().ToFullString();
        }

        #region File Management
        private string _currentFilePath = string.Empty;

        private string ReadCSFile()
        {
            string csText = string.Empty;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "CS Files|*.cs",
                Title = "Select a CS File"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _currentFilePath = openFileDialog1.FileName;              
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                csText = sr.ReadToEnd();
                sr.Close();
            }

            return csText;
        }

        private void SaveFileInPath()
        {
            using (StreamWriter writer = new StreamWriter(_currentFilePath, false))
            {
                writer.Write(txtBEditor.Text);
            }
        }
        #endregion

        #endregion

    }
}
