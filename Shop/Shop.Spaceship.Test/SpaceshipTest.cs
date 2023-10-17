using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Spaceship.Test
{
    public class SpaceshipTest : TestBase
    {
        [Fact]
        public async Task ShouldNot_AddEmptySpaceship_WhenReturnresult()
        {
            SpaceshipDto dto = new SpaceshipDto();

            dto.Name = "Name";
            dto.Type = "Type";
            dto.Passangers = 123;
            dto.EnginPower = 123;
            dto.Crew = 123;
            dto.Company = "LOL";
            dto.CargoWeight = 123;
            dto.CreatedAt = DateTime.Now;
            dto.Modifieted = DateTime.Now;

            var result = await Svc<ISpaceshipServices>().Create(dto);
            Assert.NotNull(result);
        }
        [Fact]
        public async Task ShouldNot_GetByIdSpaceship_WhenReturnsNotEqual()
        {
            Guid guid = Guid.Parse("a1999241 - e62b - 4804 - 8c19 - 4f017de45914");
            //kuidas teha automatselt guidi
            Guid wrongGuid = Guid.Parse(Guid.NewGuid().ToString());
        }
    }
}
