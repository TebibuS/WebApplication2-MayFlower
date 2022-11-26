using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using WebApplication2_MayFlower.Models;

namespace WebApplication2_MayFlower.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            FileGateway aGateway = new FileGateway();
            List<Person> aListOfPeople = aGateway.GetPeople("C:\\Users\\tebib\\source\\repos\\WebApplication2 MayFlower\\Mayflower.csv");


       

            ViewBag.ListOfPeople = aListOfPeople;


            return View();
        }
    }
}
