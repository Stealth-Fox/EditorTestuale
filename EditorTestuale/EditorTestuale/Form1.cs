using System;
using System.Drawing;
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

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBEditor.Text = ReadCSFile();
            txtBEditor.Enabled = true;
            lblNomefile.Text = "Percorso file: " + _currentFilePath;
            AddLineNumbers();
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileInPath();
        }

        private void indentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBEditor.Text = IndentaCSharp(txtBEditor.Text);
            AddLineNumbers();
        }

        public int getWidth()
        {
            int w = 25;
            int line = txtBEditor.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)txtBEditor.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)txtBEditor.Font.Size;
            }
            else
            {
                w = 50 + (int)txtBEditor.Font.Size;
            }

            return w;
        }

        public void AddLineNumbers()
        {
            Point pt = new Point(0, 0);
            int First_Index = txtBEditor.GetCharIndexFromPosition(pt);
            int First_Line = txtBEditor.GetLineFromCharIndex(First_Index);
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            int Last_Index = txtBEditor.GetCharIndexFromPosition(pt);
            int Last_Line = txtBEditor.GetLineFromCharIndex(Last_Index);
            LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Center; 
            LineNumberTextBox.Text = "";
            LineNumberTextBox.Width = getWidth();
            for (int i = First_Line; i <= Last_Line + 1; i++)
            {
                LineNumberTextBox.Text += i + 1 + "\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = txtBEditor.Font;
            txtBEditor.Select();
            AddLineNumbers();
        }

        private void txtBEditor_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = txtBEditor.GetPositionFromCharIndex(txtBEditor.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void txtBEditor_VScroll(object sender, EventArgs e)
        {
            LineNumberTextBox.Text = "";
            AddLineNumbers();
            LineNumberTextBox.Invalidate();
        }

        private void txtBEditor_TextChanged(object sender, EventArgs e)
        {
            if (txtBEditor.Text == "")
            {
                AddLineNumbers();
            }
        }

        private void txtBEditor_FontChanged(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = txtBEditor.Font;
            txtBEditor.Select();
            AddLineNumbers();
        }

        private void LineNumberTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            txtBEditor.Select();
            LineNumberTextBox.DeselectAll();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AddLineNumbers();
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
