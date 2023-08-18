using CarTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarTask.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Car> _cars;

        public CarController()
        {
            _cars = new()
            {
            new(){Id=1,CarName="supra",ModelId=1},
            new(){Id=2,CarName="Challenger",ModelId=2},
            new(){Id=3,CarName="Charger",ModelId=3},
            new(){Id=4,CarName="Mustang-Red",ModelId=4},
            };
        }
        public IActionResult Index(int?id)
        {
            if (id == null) return BadRequest();
            if (_cars.Exists(m => m.ModelId == id))
            {
                return View(_cars.FindAll(m => m.ModelId == id));

            }
            return NotFound();
        }
    }
}
