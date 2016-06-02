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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void informationSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.informationSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infoDataSet);

        }

        private void Register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infoDataSet.InformationSet' table. You can move, or remove it, as needed.
            this.informationSetTableAdapter.Fill(this.infoDataSet.InformationSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            InfoDBContainer infodata = new InfoDBContainer();

            Information newinfo = new Information();

            newinfo.Name = nameTextBox.Text;
            newinfo.Gender = genderTextBox.Text;
            newinfo.Age = ageTextBox.Text;
            newinfo.Ocupation = ocupationTextBox.Text;
            newinfo.Symptoms = symptomsTextBox.Text;
            newinfo.Medication = medicationTextBox.Text;
            newinfo.Diagnoses = diagnosesTextBox.Text;
                
            infodata.InformationSet.Add(newinfo);

            infodata.SaveChanges();

            this.Close();

        }
    }
}
