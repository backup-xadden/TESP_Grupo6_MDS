using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoFuncional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_details view = new View_details();
            if (view.ShowDialog() != DialogResult.OK)
                return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register resgis = new Register();
            if (resgis.ShowDialog() != DialogResult.OK)
                return;
        }
    }
}
