﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.ApplicationServices.Services;
using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using Shop.Data;
using Shop.Models.Realestate;
using Shop.Models.Spaceship;

namespace Shop.Controllers
{
    
    public class RealestateController : Controller
    {
        private readonly ShopContext _context;
        private readonly IRealEstateServices _realstateService; // Inject the RealEstate service
        private readonly IFileServices _fileServices;
         // Add the RealEstate service to constructor


        public RealestateController
           (
           ShopContext context,

           IRealEstateServices realstateService,
           IFileServices fileServices
           )
        {
            _context = context;
            
            _realstateService = realstateService;
            _fileServices = fileServices;
        }


        public IActionResult Index()
        {
            var result = _context.RealEstates
                .Select(x => new RealEstateViewModel
                {
                    Id = x.Id,
                    Address = x.Address,
                    SizeSqrM = x.SizeSqrM,
                    RoomCount = x.RoomCount,
                    Floor = x.Floor,
                });

            return View(result);
        }


        [HttpGet]
        public IActionResult Create()
        {
            RealEstateCreateUpdateViewModel realstate = new RealEstateCreateUpdateViewModel();

            return View("CreateUpdate", realstate);
        }


        [HttpPost]
        public async Task<IActionResult> Create(RealEstateCreateUpdateViewModel vm)
        {
            var dto = new RealEstateDto()
            {
                Id = vm.Id,
                Address = vm.Address,
                SizeSqrM =Convert.ToSingle( vm.SizeSqrM),
                RoomCount = vm.RoomCount,
                Floor = vm.Floor,

                BuildingType = vm.BuildingType,
                BuiltinYear = vm.BuiltinYear,
                
                CreatedAt=vm.CreatedAt,
                UpdatedAt=vm.UpdatedAt,
                Files = vm.Files,
                Image = vm.Image.Select(x=> new FileToDatabaseDto
                {
                    Id = x.ImageId,
                    ImageData = x.ImageData,
                    ImageTitle = x.ImageTitle,
                    RealEstateId = x.RealEstateId
                }).ToArray()

            };

            var result = await _realstateService.Create(dto);

            if (result == null)
            {
                return RedirectToAction(nameof(Index));

            }
            return RedirectToAction(nameof(Index), vm);
            //return index

        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var realestate = await _realstateService.GetAsync(id);

            if (realestate == null)
            {
                return NotFound();

            }
            var photos = await _context.FileToDatabases
                .Where(x => x.RealEstateId == id)
                .Select(y => new ImageToDatabaseViewModel
                {

                    RealEstateId = y.Id,
                    ImageId = y.Id,
                    ImageData = y.ImageData,
                    ImageTitle = y.ImageTitle,
                    Image = string.Format("data:image/gif;base64,{0}", Convert.ToBase64String(y.ImageData))

                }).ToArrayAsync();
            

            var vm = new RealEstateDetailsViewModel();

            vm.Id = realestate.Id;
            vm.Address = realestate.Address;
            vm.SizeSqrM = (float)realestate.SizeSqrM;

            vm.RoomCount = realestate.RoomCount;

            vm.Floor = realestate.Floor;
            vm.BuildingType = realestate.BuildingType;
            vm.BuiltinYear = realestate.BuiltinYear;
     
            vm.CreatedAt = realestate.CreatedAt;
            vm.UpdatedAt = realestate.UpdatedAt;
            vm.Image.AddRange(photos);
            



            return View(vm);



        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var realstate = await _realstateService.GetAsync(id);

            if (realstate == null)
            {
                return NotFound();
            }

            var photos = await _context.FileToDatabases
                .Where(x => x.RealEstateId == id)
                .Select(y => new ImageToDatabaseViewModel
                {
                    RealEstateId = y.Id,
                    ImageId = y.Id,
                    ImageData = y.ImageData,
                    ImageTitle = y.ImageTitle,
                    Image = string.Format("data:image/gif;base64, {0}" , Convert.ToBase64String(y.ImageData))
                }).ToArrayAsync();

            var vm = new RealEstateCreateUpdateViewModel();

            vm.Id = realstate.Id;
            vm.Address = realstate.Address;
            vm.SizeSqrM = (float)realstate.SizeSqrM;

            vm.RoomCount = realstate.RoomCount;

            vm.Floor = realstate.Floor;
            vm.BuildingType = realstate.BuildingType;
            vm.BuiltinYear = realstate.BuiltinYear;
            
            vm.CreatedAt = realstate.CreatedAt;
            vm.UpdatedAt = realstate.UpdatedAt;
            vm.Image.AddRange(photos);

            return View("CreateUpdate", vm);
        }
        [HttpPost]
        public async Task<IActionResult> Update(RealEstateCreateUpdateViewModel vm)
        {
            var dto = new RealEstateDto()
            {
                Id = vm.Id,
                Address = vm.Address,
                SizeSqrM = Convert.ToSingle( vm.SizeSqrM),
                RoomCount = vm.RoomCount,
                Floor = vm.Floor,

                BuildingType = vm.BuildingType,
                BuiltinYear = vm.BuiltinYear,
                
                CreatedAt = vm.CreatedAt,
                UpdatedAt = DateTime.Now,
                Files = vm.Files,
                Image = vm.Image.Select(x  => new FileToDatabaseDto
                {
                    Id = x.ImageId,
                    ImageData = x.ImageData,
                    ImageTitle = x.ImageTitle,
                    RealEstateId = x.RealEstateId,
                }).ToArray()
            };
            var result = await _realstateService.Update(dto);
            if (result == null)
            {
                return RedirectToAction(nameof(Index), vm);

            }
            return RedirectToAction(nameof(Index), vm);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var realstate = await _realstateService.GetAsync(id);
            if (realstate == null)
            {
                return NotFound();
            }

            var photos = await _context.FileToDatabases
                .Where(x => x.RealEstateId == id)
                .Select(y => new ImageToDatabaseViewModel
                {
                    RealEstateId = y.Id,
                    ImageId = y.Id,
                    ImageData = y.ImageData,
                    ImageTitle = y.ImageTitle,
                    Image = string.Format("data:image/gif;base64, {0}", Convert.ToBase64String(y.ImageData))
                }).ToArrayAsync();

            var vm = new RealEstateDeleteViewModel();

            vm.Id = realstate.Id;
            vm.Address = realstate.Address;
            vm.SizeSqrM = (float)realstate.SizeSqrM;

            vm.RoomCount = realstate.RoomCount;

            vm.Floor = realstate.Floor;
            vm.BuildingType = realstate.BuildingType;
            vm.BuiltinYear = realstate.BuiltinYear;
            
            vm.CreatedAt = realstate.CreatedAt;
            vm.UpdatedAt = realstate.UpdatedAt;

            vm.ImageToDatabase.AddRange(photos);

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmation(Guid id)
        {
            var realestateId = await _realstateService.Delete(id);

            if (realestateId == null)
            {
                return RedirectToAction(nameof(Index));

            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> RemoveImage(ImageToDatabaseViewModel file)
        {
            var dto = new FileToDatabaseDto()
            {
                Id = file.ImageId
            };

            var image = await _fileServices.RemoveImageFromDatabase(dto);
            
            if(image==null)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
        //[HttpPost]
        //public async Task<IActionResult> RemoveImages(ImageToDatabaseViewModel[] files)
        //{
        //    foreach (var file in files)
        //    {
        //        var dto = new FileToDatabaseDto()
        //        {
        //            Id = file.ImageId
        //        };

        //        var image = await _fileServices.RemoveImageFromDatabase(dto);
        //    }

        //    return RedirectToAction(nameof(Index));
        //}
        //public async Task<IActionResult> RemoveImages(List<int> imageIds)
        //{
        //    if (imageIds != null && imageIds.Any())
        //    {
        //        foreach (int imageId in imageIds)
        //        {
        //            var dto = new FileToDatabaseDto
        //            {
        //                Id = imageId
        //            };
        //            await _fileServices.RemoveImageFromDatabase(dto);
        //        }
        //    }

        //    return RedirectToAction(nameof(Index));
        //}
        //teha meetod, mis kustutab mitu pilti  korraga ära






    }
}

