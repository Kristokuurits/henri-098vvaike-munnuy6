using Microsoft.AspNetCore.Mvc;

namespace TARpe21ShopVaitmaa.Models.Cars
{
    public class FileToApiViewModelCars : Controller
    {
        public Guid ImageId { get; set; }
        public string FilePath { get; set; }
        public Guid RealEstateId { get; set; }
    }
}
