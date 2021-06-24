using System;
using System.Windows.Forms;


namespace SDV601_App
{
    public partial class addingVehicleExtend : Form
    {
        private Vehicle _vehicle = new Vehicle();

        public addingVehicleExtend()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(Vehicle vehicle)
        {
            _vehicle = vehicle;
            UpdateDisplay();
            return ShowDialog();
        }

        private void UpdateDisplay()
        {
            addVehicleExtendRegoTxt.Text = _vehicle.Registration; //creating method called UpdateDisplay that connects the user inputs to 
            addVehicleExtendMakeTxt.Text = _vehicle.Make;         //Properties set in Vehicle class, allowing them to be used later in the code for saving etc.
            addVehicleExtendModelTxt.Text = _vehicle.Model;
            addVehicleExtendYearTxt.Text = Convert.ToString(_vehicle.Year);
            addVehicleExtendHireCostTxt.Text = Convert.ToString(_vehicle.HireCost);
            addVehicleEntryDate.Value = _vehicle._createdDate;
            addVehicleExtendMakeTxt.Enabled = String.IsNullOrEmpty(_vehicle.Registration);

        }

        private void addingVehicleExtend_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _vehicle.Registration = addVehicleExtendRegoTxt.Text; //creating an onclick event that sends the data to Vehicle when the button is pressed by user
            _vehicle.Make = addVehicleExtendMakeTxt.Text;
            _vehicle.Model = addVehicleExtendModelTxt.Text;
            _vehicle.Year = Convert.ToInt32(addVehicleExtendYearTxt.Text);
            _vehicle.HireCost = Convert.ToDecimal(addVehicleExtendHireCostTxt.Text); 
            _vehicle._createdDate = addVehicleEntryDate.Value;
            DialogResult = DialogResult.OK;
            this.Close();
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
