using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Primjena_WindowsKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRunProgram_Click(object sender, EventArgs e)
        {
            string selectedProgram = comboBox.SelectedItem.ToString();
            Process.Start(selectedProgram);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = checkBox1.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxProgramName.Clear();
            textBoxProgramDescription.Clear();

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li želite nastaviti?", "Potvrda", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);


        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li želite nastaviti?", "Potvrda", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            switch (result)
            {
                case DialogResult.Yes:
                    // Akcija za "Da"
                    break;
                case DialogResult.No:
                    // Akcija za "Ne"
                    break;
                case DialogResult.Cancel:
                    // Akcija za "Otkaži"
                    break;

            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text formaText = new Text();
            formaText.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

