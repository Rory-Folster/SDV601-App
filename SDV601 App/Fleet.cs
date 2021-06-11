using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SDV601_App
{
    public static class Fleet
    {
        private static string fileName = "fleet.dat";

        private static Dictionary<string, Vehicle> _vehicles = new Dictionary<string, Vehicle>();

        public static Dictionary<string, Vehicle> Vehicles { get => _vehicles; }

        public static void Save()
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, _vehicles);
            }
        }

        public static void Retrieve()
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                _vehicles = (Dictionary<string, Vehicle>)formatter.Deserialize(fileStream);
            }
        }
    }

}
