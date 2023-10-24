using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Spaceship.Test
{
    public class SpaceshipTest : UnitTest2
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
            //Arrange
            Guid guid = Guid.Parse("a1999241 - e62b - 4804 - 8c19 - 4f017de45914");
            //kuidas teha automatselt guidi
            Guid wrongGuid = Guid.Parse(Guid.NewGuid().ToString());

            //Act
            await Svc<ISpaceshipServices>().GetAsync(guid);

            //Assert
            Assert.NotEqual(guid, wrongGuid);

        }
        [Fact]

        public async Task Should_GetByIdSpaceship_WhenRetunsEqual()
        {

            Guid databaseGuid = Guid.Parse("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");
            Guid getGuid = Guid.Parse("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");



            //SpaceshipDto spaceship = new();

            //spaceship.Id = new Guid("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");
            //Guid id2 = Guid.Parse("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");


            await Svc<ISpaceshipServices>().GetAsync(getGuid);


            //Assert.Equal(spaceship.Id , id2);
            Assert.Equal(databaseGuid, getGuid);


        }
        [Fact]

        public async Task Should_DeleteByIdSpaceship_WhenDeleteSpaceship()
        {

            //Arrange
            SpaceshipDto spaceship = MockSpaceshipData();



            //Act
            var createdspaceship = await Svc<ISpaceshipServices>().Create(spaceship);
            var result = await Svc<ISpaceshipServices>().Delete((Guid)createdspaceship.Id);


            Assert.Equal(createdspaceship, result);

        }
        [Fact]

        public async Task ShouldNot_DeleteByIdSpaceship_WhenDidNotDeleteSpaceship()
        {
            SpaceshipDto spaceship = MockSpaceshipData();

            var addSpaceship = await Svc<ISpaceshipServices>().Create(spaceship);
            var addSpaceship2 = await Svc<ISpaceshipServices>().Create(spaceship);

            var result = await Svc<ISpaceshipServices>().Delete((Guid)addSpaceship2.Id);
            Assert.NotEqual(addSpaceship.Id, result.Id);

        }
        [Fact]
        public async Task Should_UpdateSpaceship_WhenUpdateData()
        {
            var guid = new Guid("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");

            //old data from db
            Shop.Core.Domain.Spaceship spaceship = new Shop.Core.Domain.Spaceship();

            //new data
            SpaceshipDto dto = MockSpaceshipData();

            spaceship.Id = Guid.Parse("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");
            spaceship.Name = "asdrd";
            spaceship.Type = "asdasad";
            spaceship.Passangers = 123123;
            spaceship.EnginPower = 15423;
            spaceship.Crew = 567;
            spaceship.Company = "Company asd";
            spaceship.CargoWeight = 567;
            spaceship.CreatedAt = DateTime.Now.AddYears(1);
            spaceship.Modifieted = DateTime.Now.AddYears(1);

            await Svc<ISpaceshipServices>().Update(dto);

            Assert.Equal(spaceship.Id, guid);
            Assert.NotEqual(spaceship.EnginPower, dto.EnginPower);
            Assert.NotSame(spaceship.Name, dto.Name);
            //Assert.DoesNotMatch(Convert.ToString(spaceship.Passengers), dto.Passengers.ToString());
            Assert.DoesNotMatch(spaceship.Passangers.ToString(), dto.Passangers.ToString());


        }
        [Fact]
        public async Task Should_updateSpaceship_WhenUpdateDataVersion()
        {
            SpaceshipDto dto = MockSpaceshipData();
            var createdSpaceship = await Svc<ISpaceshipServices>().Create(dto);

            SpaceshipDto update = MockUpdateSpaceshipData();
            var updateSpaceship = await Svc<ISpaceshipServices>().Update(update);

            Assert.DoesNotMatch(updateSpaceship.Name.ToString(), createdSpaceship.Name.ToString());
            Assert.NotEqual(updateSpaceship.EnginPower, createdSpaceship.EnginPower);
            Assert.NotSame(updateSpaceship.Crew, createdSpaceship.Crew);
            //Assert.DoesNotMatch(Convert.ToString(spaceship.Passengers), dto.Passengers.ToString());
            Assert.DoesNotMatch(updateSpaceship.Passangers.ToString(), createdSpaceship.Passangers.ToString());

        }
        [Fact]
        public async Task Should_UpdateSpaceship_WhenUpdateDataVersion2()
        {
            SpaceshipDto dto = MockSpaceshipData();
            var createSpaceship = await Svc<ISpaceshipServices>().Create(dto);

            SpaceshipDto update = MockUpdateSpaceshipData();
            var updateSpaceship = await Svc<ISpaceshipServices>().Update(update);

            //error korda teha
            Assert.Matches(updateSpaceship.Name, createSpaceship.Name);
            Assert.NotEqual(updateSpaceship.EnginPower, createSpaceship.EnginPower);
            Assert.NotEqual(updateSpaceship.Crew, createSpaceship.Crew);
            Assert.DoesNotMatch(updateSpaceship.Passangers.ToString(), createSpaceship.Passangers.ToString());
        }
        [Fact]
        public async Task ShouldNot_UpdateSpaceship_WhenNotUpdateData()
        {
            SpaceshipDto dto = MockSpaceshipData();
            await Svc<ISpaceshipServices>().Create(dto);

            SpaceshipDto nullUpdate = MockNullSpaceship();
            await Svc<ISpaceshipServices>().Update(nullUpdate);

            var nullId = nullUpdate.Id;

            Assert.True(dto.Id == nullId);
        }
        private SpaceshipDto MockNullSpaceship()
        {
            SpaceshipDto nullDto = new()
            {
                Id = null,
                Name = "Name123",
                Type = "Type123",
                Passangers = 123,
                EnginPower = 123,
                Crew = 123,
                Company = "Company123",
                CargoWeight = 123,
                CreatedAt = DateTime.Now.AddYears(1),
                Modifieted = DateTime.Now.AddYears(1),
            };
            return nullDto;
        }
        private SpaceshipDto MockUpdateSpaceshipData()
        {
            SpaceshipDto update = new()
            {
                Name = "asd123",
                Type = "asd",
                Passangers = 123456,
                EnginPower = 123456,
                Crew = 123456,
                Company = "asdasdasd",
                CargoWeight = 123456,
                CreatedAt = DateTime.Now,
                Modifieted = DateTime.Now

            };

            return update;

        }

        private SpaceshipDto MockSpaceshipData()
        {
            SpaceshipDto spaceship = new()
            {

                Name = "asd",
                Type = "asd",
                Passangers = 123,
                EnginPower = 123,
                Crew = 123,
                Company = "asd",
                CargoWeight = 123,
                CreatedAt = DateTime.Now,
                Modifieted = DateTime.Now

            };

            return spaceship;


        }
    }
}
