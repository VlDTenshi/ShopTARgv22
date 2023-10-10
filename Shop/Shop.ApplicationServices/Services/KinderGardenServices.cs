using Microsoft.EntityFrameworkCore;
using Shop.Core.Domain;
using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ApplicationServices.Services
{
    public class KinderGardenServices : IKinderGardenServices
    {
        private readonly ShopContext _context;

        public KinderGardenServices
            (
                ShopContext context
            )
        {
            _context = context;
        }
        public async Task<Kindergarden> Create(KinderGardenDto dto)
        {
            Kindergarden kindergarden = new Kindergarden();

            kindergarden.Id = Guid.NewGuid();
            kindergarden.GroupName = dto.GroupName;
            kindergarden.ChildrenCount = dto.ChildrenCount;
            kindergarden.KindergardenName = dto.KindergardenName;
            kindergarden.Teacher = dto.Teacher;
            kindergarden.CreatedAt = DateTime.Now;
            kindergarden.UpdatedAt = DateTime.Now;

            await _context.Kindergardens.AddAsync(kindergarden);
            await _context.SaveChangesAsync();



            return kindergarden;
        }
        public async Task<Kindergarden> Update(KinderGardenDto dto)
        {
            var domain = new Kindergarden()
            {
                Id = dto.Id,
                GroupName = dto.GroupName,
                ChildrenCount = dto.ChildrenCount,
                KindergardenName = dto.KindergardenName,
                Teacher = dto.Teacher,

                CreatedAt = dto.CreatedAt,
                UpdatedAt = DateTime.Now,



            };

            _context.Kindergardens.Update(domain);
            await _context.SaveChangesAsync();


            return domain;
        }
        public async Task<Kindergarden> Delete(Guid id)
        {
            var kindergardenId = await _context.Kindergardens
                .FirstOrDefaultAsync(x => x.Id == id);

            _context.Kindergardens.Remove(kindergardenId);
            await _context.SaveChangesAsync();

            return kindergardenId;
        }
        public async Task<Kindergarden> GetAsync(Guid id)
        {
            var result = await _context.Kindergardens
                .FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }
    }
}
