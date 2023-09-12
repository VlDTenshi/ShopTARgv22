using Shop.Data;
using ShopCore.Domain;
using ShopCore.Dto;
using ShopCore.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ApplicationServices.Services
{
    
    public class SpaceshipServices : ISpaceshipServices
    {
        private readonly ShopContext _context;

        public SpaceshipServices
            (

            ShopContext context

            )
        {
            _context = context;
        }

        public async Task<Spaceship>Create(SpaceshipDto dto)
        {
            Spaceship spaceship = new Spaceship();

            spaceship.Id = Guid.NewGuid();
            spaceship.Name = dto.Name;
            spaceship.Type = dto.Type;
            spaceship.Passengers = dto.Passengers;
            spaceship.EnginePower = dto.EnginePower;
            spaceship.Crew = dto.Crew;
            spaceship.Company = dto.Company;
            spaceship.FuelCapacity = dto.FuelCapacity;
            spaceship.FuelType = dto.FuelType;
            spaceship.CargoWeight = dto.CargoWeight;
            spaceship.CreatedAt = DateTime.Now;
            spaceship.ModifiedAt = DateTime.Now;

            await _context.Spaceships.AddAsync( spaceship );
            await _context.SaveChangesAsync();

            return spaceship;
        }
    }
}
