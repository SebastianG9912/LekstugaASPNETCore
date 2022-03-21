using EmptyASPNETCore.Data;
using EmptyASPNETCore.Models;

namespace EmptyASPNETCore.Services
{
    public class BirthdayHandler
    {
        //Förvara lista på alla födelsedagar
        public List<Birthday> Birthdays { get; init; }

        public BirthdayHandler()
        {
            var today = DateTime.Today;

                Birthdays = new List<Birthday>(){
                new Birthday(new DateTime(1999, 04, 12), "Sebastian"),
                new Birthday(new DateTime(2000, 05, 10), "Oscar"),
                new Birthday(new DateTime(2000, 03, 10), "Carl"),
                new Birthday(new DateTime(1987, 03, 9), "Maria"),
                new Birthday(new DateTime(2010, 12, 30), "Simon")
            };

                /*using var ctx = new BirthdayDbContext();
                Birthdays = ctx.Birthdays.ToList();*/

            // sortera så närmsta födelsedag är först
            Birthdays.Sort((birthdayA, birthdayB) =>
                DateTime
                    .Compare(birthdayA.ThisYear(today), birthdayB.ThisYear(today)));
        }

        //Hämta kommande födelsedagar inom X dagar från givet datum
        public List<Birthday> GetBirthdaysWithinXDaysFromDate(int days, DateTime date)
        {
            return Birthdays
                // hämta bara födelsedagar som ligger i framtiden
                .Where(birthday => (birthday.ThisYear(date) - date).Days >= 0)
                // hämta bara födelsedagar som ligger inom två månader från idag
                .Where(birthday => (birthday.ThisYear(date) - date).Days <= 60)
                .ToList(); ;
        }
    }
}
