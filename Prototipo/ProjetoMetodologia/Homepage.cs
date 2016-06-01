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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void buttonRegisterPatient_Click(object sender, EventArgs e)
        {
            RegisterCliente registerCliente = new RegisterCliente();

            if (registerCliente.ShowDialog() != DialogResult.OK)
                return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search_Patient search = new Search_Patient();
            if (search.ShowDialog() != DialogResult.OK)
                return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_patient_details view = new View_patient_details();
            if (view.ShowDialog() != DialogResult.OK)
                return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register_medical_details reg = new Register_medical_details();
            if (reg.ShowDialog() != DialogResult.OK)
                return;
        }
    }
}
