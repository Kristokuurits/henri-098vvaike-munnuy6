using Microsoft.AspNetCore.Mvc;

namespace TARpe21ShopVaitmaa.Models.Cars
{
    public class CarsCreateUpdateViewModel : Controller
    {
        public string Model { get; set; }
        public int Price { get; set; }
        public  string Mark { get; set; }
        public Guid Id { get; set; }
        public int PassengerCount { get; set; }
        public int EnginePower { get; set; }
        public DateTime CreateAt { get; set; }

    }
}
