using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastLatex
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetLatexBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OutputBox.Text = Latex.GetFromText(InputBox.Text)
                    .SetParagraph(CreateWithParagraphCBox.Checked)
                    .Build();
            }
            catch(Exception ex)
            {
                MessageBox.Show("We have a problem...", ex.Message);
            }
        }

       
    }
}
