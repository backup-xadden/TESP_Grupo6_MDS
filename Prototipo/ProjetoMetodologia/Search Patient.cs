using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProjetoMetodologia
{
    public partial class Search_Patient : Form
    {
        public Search_Patient()
        {
            InitializeComponent();
            PatientDataContainer container = new PatientDataContainer();
            (from PatientDemographicData in container.PatientDemographicDatas orderby PatientDemographicData.Id select PatientDemographicData).Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //search patient
            PatientDataContainer container = new PatientDataContainer();


            string data;
            string value = comboBox1.SelectedItem.ToString();
            data = textBoxData.Text;        
            switch(value){
                case "ID":
                    (from PatientDemographicData in container.PatientDemographicDatas where PatientDemographicData.Id.ToString().Contains(data) orderby PatientDemographicData.Id select PatientDemographicData).ToList();
                    ListBoxPatient.DataSource = container.PatientDemographicDatas.Local.ToBindingList();
                    break;
                case "Nome":
                    (from PatientDemographicData in container.PatientDemographicDatas where PatientDemographicData.Name.Contains(data) orderby PatientDemographicData.Id select PatientDemographicData).ToList();
                    ListBoxPatient.DataSource = container.PatientDemographicDatas.Local.ToBindingList();
                    break;
                case "Gender":
                    (from PatientDemographicData in container.PatientDemographicDatas where PatientDemographicData.Gender.Contains(data) orderby PatientDemographicData.Id select PatientDemographicData).ToList();
                    ListBoxPatient.DataSource = container.PatientDemographicDatas.Local.ToBindingList();
                    break;
                case "BirthDate":
                    data = dateTimePicker1.Value.ToString();
                    (from PatientDemographicData in container.PatientDemographicDatas where PatientDemographicData.Birthday.ToString().Contains(data) orderby PatientDemographicData.Id select PatientDemographicData).ToList();
                    ListBoxPatient.DataSource = container.PatientDemographicDatas.Local.ToBindingList();
                    break;
                case "Address":
                    (from PatientDemographicData in container.PatientDemographicDatas where PatientDemographicData.Address.Contains(data) orderby PatientDemographicData.Id select PatientDemographicData).ToList();
                    ListBoxPatient.DataSource = container.PatientDemographicDatas.Local.ToBindingList();
                    break;
                case "Phone":
                    (from PatientDemographicData in container.PatientDemographicDatas where PatientDemographicData.Phone.Contains(data) orderby PatientDemographicData.Id select PatientDemographicData).ToList();
                    ListBoxPatient.DataSource = container.PatientDemographicDatas.Local.ToBindingList();
                    break;
            }
            

         
        }

        private void Search_Patient_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
        }

        private void ListBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatientDemographicData selectedCliente = (PatientDemographicData)ListBoxPatient.SelectedItem;

            label7.Text = selectedCliente.Id.ToString();
            label8.Text = selectedCliente.Name;
            label9.Text = selectedCliente.Gender;
            label10.Text = selectedCliente.Birthday.ToShortDateString();
            label11.Text = selectedCliente.Address;
            label12.Text = selectedCliente.Phone;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value;
            value = comboBox1.SelectedItem.ToString();
            if (value == "BirthDate")
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
