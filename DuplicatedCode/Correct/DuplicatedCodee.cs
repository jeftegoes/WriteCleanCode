namespace DuplicatedCode
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public static Time Parse(string str)
        {
            int time;
            int hours = 0;
            int minutes = 0;

            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentNullException("scr");
            }
            
            if (int.TryParse(str.Replace(":", ""), out time))
            {
                hours = time / 100;
                minutes = time % 100;
            }
            else
            {
                throw new ArgumentException("scr");
            }

            return new Time(hours, minutes);
        }
    }

    public class DuplicatedCodee
    {
        public void AdmitGuest(string name, string admissionDateTime)
        {
            var time = Time.Parse(admissionDateTime);

            if (time.Hours < 10)
            {

            }
        }

        public void UpdateAdmission(int admissionId, string name, string admissionDateTime)
        {
            var time = Time.Parse(admissionDateTime);

            if (time.Hours < 10)
            {

            }
        }
    }
}