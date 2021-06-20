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
    public partial class addingVehicle : Form
    {
        public addingVehicle()
        {
            InitializeComponent();
        }

        private void submitCarRegoBtn_Click(object sender, EventArgs e)
        {
            addingVehicleExtend newAddingExtend = new addingVehicleExtend();
            newAddingExtend.Show();
        }
    }
}
