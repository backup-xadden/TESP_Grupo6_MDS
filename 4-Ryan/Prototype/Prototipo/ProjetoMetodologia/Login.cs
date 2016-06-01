using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMetodologia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnenter_Click(object sender, EventArgs e)
        {

            //opens homepage, corre quando o login for true
            Homepage homepage = new Homepage();

            if (homepage.ShowDialog() != DialogResult.OK)
                return;
        }
    }
}
