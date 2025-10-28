using Microsoft.AspNetCore.Mvc;

namespace Wordle.Controllers;

public class WordleController : Controller
{
    // GET
    public IActionResult Index()
    {
        //return view with the chosen word
        var words = new List<string>
        {
            "apple",
            "grape",
            "peach",
            "mango",
            "berry",
            "lemon",
            "melon",
            "cherry",
            "plum",
            "apricot"
        };
        var random = new Random();
        var word = words[random.Next(words.Count)];
        ViewBag.Word = word;
        
       
        return View();
    }
}