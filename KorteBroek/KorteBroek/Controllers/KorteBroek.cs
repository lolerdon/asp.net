using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace KorteBroek.Controllers;

public class KorteBroek : Controller
{

    [HttpPost]
    public IActionResult Weer(int temp, int rainChance, int id)
    {
        bool isHot;
        bool overWrite = false;
        if (temp >= 20 && rainChance >= 50)
        {
            isHot = true;
        }
        else
        {
            isHot = false;
        }

        if (id == 3)
        {
            overWrite = true;
        }
        ViewBag.IsHot = isHot;
        ViewBag.OverWrite = overWrite;
        return View();
    }
}