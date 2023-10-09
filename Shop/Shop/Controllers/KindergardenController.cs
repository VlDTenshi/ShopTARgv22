using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.ApplicationServices.Services;
using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using Shop.Data;
using Shop.Models.Kindergarden;
using Shop.Models.Realestate;
using Shop.Models.Spaceship;

namespace Shop.Controllers
{
    public class KindergardenController : Controller
    {
        private readonly ShopContext _context;
        private readonly IKinderGardenServices _kindergardenService;
        // GET: KindergardenController
        public KindergardenController
           (
           ShopContext context,

           IKinderGardenServices kindergardenService
           )
        {
            _context = context;

            _kindergardenService = kindergardenService;
        }


        public IActionResult Index()
        {
            var result = _context.Kindergardens
                .Select(x => new KinderGardenViewModel
                {
                    Id = x.Id,
                    GroupName = x.GroupName,
                    ChildrenCount = x.ChildrenCount,
                    KindergardenName = x.KindergardenName,
                    Teacher = x.Teacher,
                });

            return View(result);
        }


        [HttpGet]
        public IActionResult Create()
        {
            KinderGardenCreateUpdateViewModel kindergarden = new KinderGardenCreateUpdateViewModel();

            return View("CreateUpdate", kindergarden);
        }


        [HttpPost]
        public async Task<IActionResult> Create(KinderGardenCreateUpdateViewModel vm)
        {
            var dto = new KinderGardenDto()
            {
                Id = vm.Id,
                GroupName = vm.GroupName,
                ChildrenCount = vm.ChildrenCount,
                KindergardenName = vm.KindergardenName,
                Teacher = vm.Teacher,
                CreatedAt = vm.CreatedAt,
                UpdatedAt = vm.UpdatedAt,
            };

            var result = await _kindergardenService.Create(dto);

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
            var kindergarden = await _kindergardenService.GetAsync(id);

            if (kindergarden == null)
            {
                return NotFound();

            }
            var vm = new KinderGardenDetailsViewModel();

            vm.Id = kindergarden.Id;
            vm.GroupName = kindergarden.GroupName;
            vm.ChildrenCount = kindergarden.ChildrenCount;

            vm.KindergardenName = kindergarden.KindergardenName;

            vm.Teacher = kindergarden.Teacher;

            vm.CreatedAt = kindergarden.CreatedAt;
            vm.UpdatedAt = kindergarden.UpdatedAt;




            return View(vm);



        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var kindergarden = await _kindergardenService.GetAsync(id);

            if (kindergarden == null)
            {
                return NotFound();
            }


            var vm = new KinderGardenCreateUpdateViewModel();

            vm.Id = kindergarden.Id;
            vm.GroupName = kindergarden.GroupName;
            vm.ChildrenCount = kindergarden.ChildrenCount;

            vm.KindergardenName = kindergarden.KindergardenName;

            vm.Teacher = kindergarden.Teacher;

            vm.CreatedAt = kindergarden.CreatedAt;
            vm.UpdatedAt = kindergarden.UpdatedAt;

            return View("CreateUpdate", vm);
        }
        [HttpPost]
        public async Task<IActionResult> Update(KinderGardenCreateUpdateViewModel vm)
        {
            var dto = new KinderGardenDto()
            {
                Id = vm.Id,
                GroupName = vm.GroupName,
                ChildrenCount = vm.ChildrenCount,
                KindergardenName = vm.KindergardenName,
                Teacher = vm.Teacher,
                CreatedAt = vm.CreatedAt,
                UpdatedAt = DateTime.Now,
            };
            var result = await _kindergardenService.Update(dto);
            if (result == null)
            {
                return RedirectToAction(nameof(Index), vm);

            }
            return RedirectToAction(nameof(Index), vm);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var kindergarden = await _kindergardenService.GetAsync(id);
            if (kindergarden == null)
            {
                return NotFound();
            }
            var vm = new KinderGardenDeleteViewModel();

            vm.Id = kindergarden.Id;
            vm.GroupName = kindergarden.GroupName;
            vm.ChildrenCount = kindergarden.ChildrenCount;

            vm.KindergardenName = kindergarden.KindergardenName;

            vm.Teacher = kindergarden.Teacher;
            vm.CreatedAt = kindergarden.CreatedAt;
            vm.UpdatedAt = kindergarden.UpdatedAt;

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmation(Guid id)
        {
            var kindergardenId = await _kindergardenService.Delete(id);

            if (kindergardenId == null)
            {
                return RedirectToAction(nameof(Index));

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
