using System;
using System.Windows.Forms;
using Microsoft.CodeAnalysis.CSharp;

namespace EditorTestuale
{
    public partial class EditorTestuale : Form
    {
        public EditorTestuale()
        {
            InitializeComponent();
        }


        #region Business Logic
        public String indentaCSharp(String text)
        {
           return CSharpSyntaxTree.ParseText(text).GetRoot().ToFullString();
        }
        #endregion

        private void btnScelta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CS Files|*.cs";
            openFileDialog1.Title = "Select a CS File";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
        }
    }
}
