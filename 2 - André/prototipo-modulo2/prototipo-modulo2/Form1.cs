using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo_modulo2
{
    public partial class Form1 : Form
    {
        PatientDataContainer patientDB;
        public Form1()
        {
            InitializeComponent();

            patientDB = new PatientDataContainer();
            comboBoxGender.SelectedIndex = 0;
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text) || string.IsNullOrWhiteSpace(textBoxAddress.Text) || string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Fill all the fields");
            }
            else
            {
                Patient newPatient = new Patient();

                newPatient.Nome = textBoxNome.Text;
                newPatient.Gender = (string)comboBoxGender.SelectedItem;
                newPatient.Birthday = dateTimePickerBirthday.Value;
                newPatient.Address = textBoxAddress.Text;
                newPatient.Phone = textBoxPhone.Text;

                patientDB.Patients.Add(newPatient);

                patientDB.SaveChanges();

                MessageBox.Show("Patient added with success");
            }
        }
    }
}
