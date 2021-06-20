using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV601_App
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            string message = "Simple MessageBox";
            MessageBox.Show(message);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f1 = new addingVehicle();
            f1.ShowDialog();
        }

        private void vehicleExtendRichTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
