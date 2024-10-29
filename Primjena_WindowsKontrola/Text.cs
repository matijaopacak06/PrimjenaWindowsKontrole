using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primjena_WindowsKontrola
{
    public partial class Text : Form
    {
        public Text()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_Load(object sender, EventArgs e)
        {
            textBox1.Text = ProgramName;
            textBox2.Text = programDescription;
        }
    }
}
