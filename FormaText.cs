using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimjenaWindowsKontrola
{
    public partial class FormaText : Form
    {
        public FormaText()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1 = (Form1)Application.OpenForms["Form1"];
            form1.textBoxProgramName.Text = textBoxProgramName2.Text;
            form1.textBoxProgramDescription.Text = textBoxProgramDescription2.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
