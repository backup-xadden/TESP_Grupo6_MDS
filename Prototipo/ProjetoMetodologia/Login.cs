using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ekxilled\Documents\Data.mdf; Integrated Security = True; Connect Timeout = 30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from [Table] where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                //opens homepage, corre quando o login for true
                Homepage homepage = new Homepage();

                if (homepage.ShowDialog() != DialogResult.OK)
                    return;
            }
            else
            { MessageBox.Show("Please check your Credentials"); }
        }
    }
}
