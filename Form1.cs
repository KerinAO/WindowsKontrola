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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxShowProgramAction_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowProgramAction.Checked)
            {
                groupBoxRunProgram.Visible = true;
            }
            else
            {
                groupBoxRunProgram.Visible = false;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (comboBoxRunProgram.Text == "Notepad")
            {
                System.Diagnostics.Process.Start(@"notepad.exe");
            }
            if (comboBoxRunProgram.Text == "Paint")
            {
                System.Diagnostics.Process.Start(@"mspaint.exe");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxProgramName.Clear();
            textBoxProgramDescription.Clear();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Odaberite neko dugme", "Obavijest", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaText formaText = new FormaText();
            formaText.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Dali ste sigurni da želite zatvoriti aplikaciju?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
