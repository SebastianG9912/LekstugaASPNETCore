using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmptyASPNETCore.Controllers
{
    public class Snippet : Controller
    {
        /**
         * Kallas för "Action Metod".
         * Är en endpoint.
         */
        public IActionResult Index()
        {
            return Content("Test");
        }

        /**
         * Kallas för "Action Metod".
         * Är en endpoint.
         */
        public string Welcome(string name)
        {
            return $"Hej och Välkommen {name}!";
        }

        /**
         * Skapa en action metod "Flip" som använder Random klassen
         * för att antingen returnera "heads" eller "tails".
         */
        public string Flip()
        {
            Random random = new Random();

            int randomNmbr = random.Next(0, 2);
            if (randomNmbr > 0)
            {
                return "Heads";
            }

            return "Tails";
        }

        /**
         * Skapa en action metod "Missing" som
         * använder NotFound(), vad händer när
         * rutten besöks?
         */
        public IActionResult Missing()
        {
            return NotFound("404");
        }

        /**
         * Skapa en action metod "Search" som använder Redirect()
         * och en queryparameter för att skicka besökaren till
         * https://www.google.se?q=[sökning].
         * (Det finns en Uri klass i .NET motsvarande URL i
         * javascript)
         */
        public IActionResult Search(string searchParam)
        {
            return Redirect("https://www.google.se?q=" + searchParam);
        }

        /**
         * Skapa en action metod "Person" som använder Json()
         * och en POCO C# klass Person som du hittar på, för
         * att skicka tillbaka en JSON text.
         */
        public IActionResult Person()
        {
            var person = new Person
            {
                Name = "Basse",
                Age = 22
            };

            return Json(person);
        }
    }
}

public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }
}