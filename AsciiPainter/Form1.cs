using AsciiPainter.Convert;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsciiPainter
{
    public partial class Form1 : Form
    {
        private int ASCIIFontIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Text = Converter.GetAsciiArtToText(textBox1.Text.ToLower());
        }
    }
}
