using Microsoft.AspNetCore.Mvc;
using Wordle.Data;

namespace Wordle.Controllers;

public class WordleController : Controller
{
    // GET
    public IActionResult Index()
    {
        var words = WordleContext.GetWordsByLength(5);
       
        
        var random = new Random();
        var word = words[random.Next(words.Count)];
        ViewBag.Word = word;
        
       
        return View();
    }
}