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
    }
}
