using Microsoft.Net.Http.Headers;

namespace EmptyASPNETCore.Models
{
    public class Birthday
    {
        public Birthday(DateTime birthDate, string name)
        {
            BirthDate = birthDate;
            Name = name;
        }
        public DateTime BirthDate { get;}
        public string Name { get;}

        public override string ToString()
        {
            return $"{Name}: {BirthDate.Day} of {monthToString(BirthDate.Month)}";
        }

        private string monthToString(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1: return "January";

                case 2: return "February";

                case 3: return "March";

                case 4: return "April";

                case 5: return "May";

                case 6: return "June";

                case 7: return "July";

                case 8: return "August";

                case 9: return "September";

                case 10: return "October";

                case 11: return "November";

                case 12: return "December";

                default: return "Invalid month";
            }
        }
    }
}
