using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.ApplicationServices.Services;
using Shop.Data;
using Shop.Models.Spaceship;
using ShopCore.Domain;
using ShopCore.Dto;
using ShopCore.ServiceInterface;

namespace Shop.Controllers
{
    public class RealEstatesController : Controller
    {
        private readonly ShopContext _context;
        private readonly IRealEstateServices _realestateServices;
        public RealEstatesController
            (
                ShopContext context,
                IRealEstateServices realestateServices
            )
        {
            _context = context;
            _realestateServices = realestateServices;
        }
        public IActionResult Index()
        {
            var result = _context.RealEstates
                .Select(x => new RealEstateIndexViewModel
                {
                    Id = x.Id,
                    Address = x.Address,
                    SizeSqrM = x.SizeSqrM,
                    RoomCount = x.RoomCount,
                    Floor = x.Floor,
                    BuildingType = x.BuildingType,
                });
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            RealEstateCreateUpdateViewModel realestate = new RealEstateCreateUpdateViewModel();
            return View("CreateUpdate", realestate);
        }
        [HttpPost]
        public async Task<IActionResult> Create(RealEstateCreateUpdateViewModel vm)
        {
            var dto = new RealEstateDto()
            {
                Id = vm.Id,
                Address = vm.Address,
                SizeSqrM = vm.SizeSqrM,
                RoomCount = vm.RoomCount,
                Floor = vm.Floor,
                BuildingType = vm.BuildingType,
                /*Files = vm.Files,
                Image = vm.FileToApiViewModels
                    .Select(x => new FileToApiDto
                    {

                        Id = x.Id,
                        ExistingFilePath = x.FilePath,
                        RealEstateId = x.RealEstateId,

                    }).ToArray()*/

            };

            var result = await _realestateServices.Create(dto);

            if (result == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index), vm);
        }
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var realestate = await _realestateServices.GetAsync(id);

            if (realestate == null)
            {
                return NotFound();
            }

            /*var images = await _context.FileToApis
                .Where(x => x.RealEstateId == id)
                .Select(y => new FileToApiViewModel
                {

                    FilePath = y.ExistingFilePath,
                    Id = y.Id

                }).ToArrayAsync();*/

            var vm = new RealEstateDetailsViewModel();

            vm.Id = realestate.Id;
            vm.Address = realestate.Address;
            vm.SizeSqrM = realestate.SizeSqrM;
            vm.RoomCount = realestate.RoomCount;
            vm.Floor = realestate.Floor;
            vm.BuildingType = realestate.BuildingType;
            vm.BuiltInYear = realestate.Company;
            vm.CreatedAt = realestate.CreatedAt;
            vm.UpdatedAt = realestate.UpdatedAt;
            //vm.FileToApiViewModels.AddRange(images);

            return View(vm);

        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var realestate = await _realestateServices.GetAsync(id);
            if (realestate == null)
            {
                return NotFound();
            }

            var vm = new RealEstateCreateUpdateViewModel();

            vm.Id = realestate.Id;
            vm.Address = realestate.Address;
            vm.SizeSqrM = realestate.SizeSqrM;
            vm.RoomCount = realestate.RoomCount;
            vm.Floor = realestate.Crew;
            vm.BuildingType = realestate.BuildingType;
            vm.BuiltInYear = realestate.BuiltInYear;
            vm.CreatedAt = realestate.CreatedAt;
            vm.UpdatedAt = realestate.UpdatedAt;

            return View("CreateUpdate", vm);
        }
        [HttpPost]
        public async Task<IActionResult> Update(RealEstateCreateUpdateViewModel vm)
        {
            var dto = new RealEstateDto()
            {
                Id = vm.Id,
                Address = vm.Address,
                SizeSqrM = vm.SizeSqrM,
                RoomCount = vm.RoomCount,
                Floor = vm.Floor,
                BuildingType = vm.BuildingType,
                BuiltInYear = vm.BuiltInYear,
                CreatedAt = vm.CreatedAt,
                UpdatedAt = vm.UpdatedAt,
            };
            var result = await _realestateServices.Update(dto);
            if (result == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index), vm);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var realestate = await _realestateServices.GetAsync(id);
            if (realestate == null)
            {
                return NotFound();
            }
            var vm = new RealEstateDeleteViewModel();

            vm.Id = realestate.Id;
            vm.Address = realestate.Address;
            vm.SizeSqrM = realestate.SizeSqrM;
            vm.RoomCount = realestate.RoomCount;
            vm.Floor = realestate.Floor;
            vm.BuildingType = realestate.BuildingType;
            vm.BuiltInYear = realestate.BuiltInYear;
            vm.CreatedAt = realestate.CreatedAt;
            vm.UpdatedAt = realestate.UpdatedAt;

            return View("CreateUpdate", vm);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmation(Guid id)
        {

            var realestateId = await _realestateServices.Delete(id);
            if (realestateId == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
