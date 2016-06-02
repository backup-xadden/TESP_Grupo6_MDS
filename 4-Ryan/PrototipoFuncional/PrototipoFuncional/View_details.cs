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
    public partial class View_details : Form
    {
        public View_details()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informationSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.informationSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infoDataSet);

        }

        private void View_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infoDataSet.InformationSet' table. You can move, or remove it, as needed.
            this.informationSetTableAdapter.Fill(this.infoDataSet.InformationSet);

        }
    }
}
