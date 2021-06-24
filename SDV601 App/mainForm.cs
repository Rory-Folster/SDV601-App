using System;
using System.Windows.Forms;
using System.IO;

namespace SDV601_App
{
    public partial class mainForm : Form
    {
        private Vehicle _vehicle; //creating new instance of Vehicle class to be used in MainForm 
        private addingVehicleExtend _addingVehicleExtend = new addingVehicleExtend(); //creating new instances of addVehicle, along with inherited activity forms.
        private addingVehicleExtend _hireForm = new NewHireForm();
        private addingVehicleExtend _relocateForm = new NewRelocateForm();
        private addingVehicleExtend _serviceForm = new NewServiceForm();

        private string[] _activityType = {"Add a new vehicle", "Hire", "Relocation", "Service" }; //creating an array of 'options' that can be used in the combobox to control which forms are opened

        public mainForm()
        {
            InitializeComponent();

            activityType.DataSource = _activityType; //setting combobox Datasource to the array above, giving each option a name in the combobox
            activityType.SelectedIndex = 0; //setting the comobobox to initially start the the first position of array

/*            Fleet.Retrieve();*/ //would be used to retrieve data from file when the application is starting up

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            string message = "Entry has been selected";
            MessageBox.Show(message); //trialing how i would make the entries clickable on mainform to display information about each entry


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (activityType.SelectedIndex == 0) //creating an if/else statement that will determine which form is created based on the user's choice
            {
                addingVehicleExtend _newVehicleExtend = new addingVehicleExtend();
                _newVehicleExtend.ShowDialog();
            }
            if (activityType.SelectedIndex == 1) // Because _activityType was set up as an array and has 4 parameters, you can select the correct response based on the user input by uing an if/else
            {                                    //statement to check the index of the listbox.
                _addingVehicleExtend = _hireForm;
            }
            else if (activityType.SelectedIndex == 2)
            {
                _addingVehicleExtend = _relocateForm;
            }
            else 
            {
                _addingVehicleExtend = _serviceForm;
            }
            _vehicle = new Vehicle(); //creating a new instance of Vehicle when an option is selected.
            EditVehicle(); //calling EditVehicle method
        }

        private void EditVehicle() //checking to make sure _vehicle is empty, and that dialog result returns ok
        {
            if (_vehicle != null && _addingVehicleExtend.ShowDialog(_vehicle) == DialogResult.OK)
            {
                string vehicleText = "Vehicle:\n";
                vehicleExtendRichTxt.Text = vehicleText + _vehicle.ToString();
                vehicleExtendSmallRichTxt1.Text = _vehicle.ToString();
            }
        }

    private void vehicleExtendRichTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainFormQuitBtn_Click(object sender, EventArgs e)
        {
/*            Fleet.Save();*/ //Would be used to save state of application to our file before it is completely shut down
            Close(); //closes application when user pressed button
        }

        private void activityType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            vehicleLogs _vehicleLogs = new vehicleLogs(); //Ran out of time but decided to code in new instance of vehicleLogs so you can see what would
            _vehicleLogs.ShowDialog();                    //happen if it was connected properly. Creating new instance then displaying form.
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string message = "Entry has been selected";
            MessageBox.Show(message);
        }

        private void listBox3_Click(object sender, EventArgs e)
        {
            string message = "Entry has been selected";
            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) /* Creating a way to read from text file. tried to use my serilize class "Fleet" but was met with an error; 'The process cannot access the file 'C:\Users\envoh\Desktop\2021\SDV\Assessments\Assessment 2 - Project\SDV601 App\SDV601 App\bin\Debug\fleet.dat' because it is being used by another process.'*/
            {
                vehicleExtendSmallRichTxt1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }
    }
}
