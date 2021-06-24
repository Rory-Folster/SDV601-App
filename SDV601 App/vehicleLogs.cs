using System;
using System.Windows.Forms;

namespace SDV601_App
{
    public partial class vehicleLogs : Form
    {
        private string[] _logSort = { "By Name", "By Date" }; //creating another array that can be used for my combobox in VehicleLogs
        public vehicleLogs()
        {
            InitializeComponent();
            vehicleLogComboBox.DataSource = _logSort; //setting combobox Datasource to the array above, giving each option a name in the combobox
            vehicleLogComboBox.SelectedIndex = 0; //setting it to start at 0 or By Name
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkLogExtend _checkLogExtend = new checkLogExtend(); //creating new instance of checkLogExtend used to manage logs and their details
            _checkLogExtend.ShowDialog(); //displaying form that was declared above
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form, in this case vehicleLogs
        }
    }
}
