using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SDV601_App
{
    public partial class addingVehicleExtend : Form
    {

        public addingVehicleExtend()
        {
            InitializeComponent();
        }

        private void addingVehicleExtend_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle newVehicle = new Vehicle();
            newVehicle._make = addVehicleExtendMakeTxt.Text;
            newVehicle._model = addVehicleExtendModelTxt.Text;
            newVehicle._year = addVehicleExtendYearTxt.TabIndex;
            newVehicle._hireCost = addVehicleExtendHireCostTxt.TabIndex;

            listBox1.Items.Add(newVehicle._make);
            listBox1.Items.Add(newVehicle._model);
            listBox1.Items.Add(newVehicle._year);
            listBox1.Items.Add(newVehicle._hireCost);

            using (StreamWriter sw = new StreamWriter("myfile.txt"))
            {
                sw.WriteLine(newVehicle._make + Environment.NewLine + newVehicle._model + Environment.NewLine + newVehicle._year + Environment.NewLine + newVehicle._hireCost);
            }
        }
    }
}
