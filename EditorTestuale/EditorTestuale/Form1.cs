using System;
using System.Windows.Forms;
using Microsoft.CodeAnalysis.CSharp;

namespace EditorTestuale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Business Logic
        public String indentaCSharp(String text)
        {
           return CSharpSyntaxTree.ParseText(text).GetRoot().ToFullString();
        }
        #endregion
    }
}
