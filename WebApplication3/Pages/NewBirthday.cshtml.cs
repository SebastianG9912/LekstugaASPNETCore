using EmptyASPNETCore.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmptyASPNETCore.Pages
{
    public class NewBirthdayModel : PageModel
    {
        private readonly Services.BirthdayHandler _birthdayHandler;

        public NewBirthdayModel(Services.BirthdayHandler birthdayHandler)
        {
            _birthdayHandler = birthdayHandler;
        }

        [BindProperty]
        public Birthday BDay { get; set; }
        public void OnGet()
        {
            BDay = new Birthday();
            BDay.BirthDate = DateTime.Now;
            BDay.Name = "Name";
        }

        public void onPost()
        {
            _birthdayHandler.Birthdays.Add(BDay);
        }
    }
}
