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
    public partial class RegisterCliente : Form
    {
        public RegisterCliente()
        {
            InitializeComponent();
            //auto selects a value
            comboBoxGender.SelectedIndex = 0;
        }

        private void btnsaveclient_Click(object sender, EventArgs e)
        {
            PatientDataContainer patientData = new PatientDataContainer();

            if (string.IsNullOrWhiteSpace(txtname.Text) || comboBoxGender.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBoxAddress.Text) || string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Fill all the fiels");
            }
            else
            {
                PatientDemographicData newPatient = new PatientDemographicData();

                newPatient.Name = txtname.Text;
                newPatient.Gender = (string)comboBoxGender.SelectedItem;
                newPatient.Birthday = dateTimePickerBirthDay.Value;
                newPatient.Address = textBoxAddress.Text;
                newPatient.Phone = textBoxPhone.Text;

                patientData.PatientDemographicDatas.Add(newPatient);

                patientData.SaveChanges();

                this.Close();
            }
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
