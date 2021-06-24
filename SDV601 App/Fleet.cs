/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SDV601_App //Class that was created to serilize the application.
{
    public static class Fleet
    {
        private static string fileName = "fleet1.dat"; //initializing a file to be saved to, by default location is in \bin.

        private static List<Vehicle> _vehicles = new List<Vehicle>(); //creating a list that will contain entries 

        public static List<Vehicle> Vehicles { get => _vehicles; } //initalizing the list

        public static void Save() //creating Save method that can be called in the application to save current state of application to the file
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, _vehicles);
            }
        }

        public static void Retrieve() //retrieve method that would be used to retrieve data from text file, usually on the initilization of application.
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                if (fileStream.Length == 0)
                {
                    Save();
                }
                else
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    _vehicles = (List<Vehicle>)formatter.Deserialize(fileStream);
                }
            }

        }
    }
}
*/