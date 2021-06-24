using System;

namespace SDV601_App
{
    [Serializable]
    public class Activity
    {
        public Activity _activity; //creating Activity class that contains generic properties that will be inherited by sub activities

        public string _activityName { get; set; } //creating properties that we need
        public string _activityType { get; set; }

        public DateTime _activityDate { get; set; } = DateTime.Today;
        public float _activityValue { get; set; }

        public string ActivityName { get => _activityName; set => _activityName = value; } //initializing properties

        public string ActivityType { get => _activityType; set => _activityType = value; }

        public DateTime ActivityDate { get => _activityDate; set => _activityDate = value; }

        public float ActivityValue { get => _activityValue; set => _activityValue = value; }

        public override string ToString()
        {
            return _activityName + "\n" + _activityType + "\n" + _activityDate + '\n' + _activityValue; //creating a method that provides the data about vehicles to mainForm Textbox
        }
    }
}
