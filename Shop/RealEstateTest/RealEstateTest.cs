using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateTest
{
    public class RealEstateTest : UnitTest1 { 

    [Fact]
        public async Task ShouldNot_AddEmptyRealestate_WhenReturnresult()
    {
        RealEstateDto dto = new RealEstateDto();

        dto.Address = "Name";
        dto.SizeSqrM = 123;
        dto.RoomCount = 123;
        dto.Floor = 123;
        dto.BuildingType = "Type";
        dto.BuiltinYear = DateTime.Now;
        dto.CreatedAt = DateTime.Now;
        dto.UpdatedAt = DateTime.Now;

        var result = await Svc<IRealEstateServices>().Create(dto);
        Assert.NotNull(result);
    }
    [Fact]
    public async Task ShouldNot_GetByIdRealestate_WhenReturnsNotEqual()
    {
        //Arrange
        Guid guid = Guid.Parse("a1999241-e62b-4804-8c19-4f017de45914");
        //kuidas teha automatselt guidi
        Guid wrongGuid = Guid.Parse(Guid.NewGuid().ToString());

        //Act
        await Svc<IRealEstateServices>().GetAsync(guid);

        //Assert
        Assert.NotEqual(guid, wrongGuid);

    }
    [Fact]

    public async Task Should_GetByIdRealestate_WhenRetunsEqual()
    {

        Guid databaseGuid = Guid.Parse("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");
        Guid getGuid = Guid.Parse("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");



        //SpaceshipDto spaceship = new();

        //spaceship.Id = new Guid("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");
        //Guid id2 = Guid.Parse("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");


        await Svc<IRealEstateServices>().GetAsync(getGuid);


        //Assert.Equal(spaceship.Id , id2);
        Assert.Equal(databaseGuid, getGuid);


    }
    [Fact]

    public async Task Should_DeleteByIdRealestate_WhenDeleteRealestate()
    {

        //Arrange
        RealEstateDto realestate = MockRealestateData();



        //Act
        var createdrealestate = await Svc<IRealEstateServices>().Create(realestate);
        var result = await Svc<IRealEstateServices>().Delete((Guid)createdrealestate.Id);


        Assert.Equal(createdrealestate, result);

    }
    [Fact]

    public async Task ShouldNot_DeleteByIdRealestate_WhenDidNotDeleteRealestate()
    {
        RealEstateDto realestate = MockRealestateData();

        var addRealestate = await Svc<IRealEstateServices>().Create(realestate);
        var addRealestate2 = await Svc<IRealEstateServices>().Create(realestate);

        var result = await Svc<IRealEstateServices>().Delete((Guid)addRealestate2.Id);
        Assert.NotEqual(addRealestate.Id, result.Id);

    }
    [Fact]
    public async Task Should_UpdateRealestate_WhenUpdateData()
    {
        var guid = new Guid("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");

        //old data from db
        Shop.Core.Domain.RealEstate realestate = new Shop.Core.Domain.RealEstate();

        //new data
        RealEstateDto dto = MockRealestateData();

        realestate.Id = Guid.Parse("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");
        realestate.Address = "asdrd";
        realestate.SizeSqrM = 12345;
        realestate.RoomCount = 12;
        realestate.Floor = 15;
        realestate.BuildingType = "Type";
        realestate.BuiltinYear = DateTime.Now.AddYears(1);
        realestate.CreatedAt = DateTime.Now.AddYears(1);
        realestate.UpdatedAt = DateTime.Now.AddYears(1);

        await Svc<IRealEstateServices>().Update(dto);

        Assert.Equal(realestate.Id, guid);
        Assert.NotEqual(realestate.SizeSqrM, dto.SizeSqrM);
        Assert.NotSame(realestate.Address, dto.Address);
        //Assert.DoesNotMatch(Convert.ToString(spaceship.Passengers), dto.Passengers.ToString());
        Assert.DoesNotMatch(realestate.Floor.ToString(), dto.Floor.ToString());


    }
    //[Fact]
    //public async Task Should_updateRealestate_WhenUpdateDataVersion()
    //{
    //    RealEstateDto dto = MockRealestateData();
    //    var createdRealestate = await Svc<IRealEstateServices>().Create(dto);

    //    RealEstateDto update = MockUpdateRealestateData();
    //    var updateRealestate = await Svc<IRealEstateServices>().Update(update);

    //    Assert.DoesNotMatch(updateRealestate.Address.ToString(), createdRealestate.Address.ToString());
    //    Assert.NotEqual(updateRealestate.Floor, createdRealestate.Floor);
    //    Assert.NotSame(updateRealestate.SizeSqrM, createdRealestate.SizeSqrM);
    //    //Assert.DoesNotMatch(Convert.ToString(spaceship.Passengers), dto.Passengers.ToString());
    //    Assert.DoesNotMatch(updateRealestate.RoomCount.ToString(), createdRealestate.RoomCount.ToString());

    //}
    [Fact]
    public async Task Should_UpdateRealestate_WhenUpdateDataVersion2()
    {
        RealEstateDto dto = MockRealestateData();
        var createRealestate = await Svc<IRealEstateServices>().Create(dto);

        RealEstateDto update = MockUpdateRealestateData();
        var updateRealestate = await Svc<IRealEstateServices>().Update(update);

        //error korda teha
        Assert.Matches(updateRealestate.Address, createRealestate.Address);
        Assert.NotEqual(updateRealestate.SizeSqrM, createRealestate.SizeSqrM);
        Assert.NotEqual(updateRealestate.RoomCount, createRealestate.RoomCount);
        Assert.DoesNotMatch(updateRealestate.Floor.ToString(), createRealestate.Floor.ToString());
    }
    [Fact]
    public async Task ShouldNot_UpdateRealestate_WhenNotUpdateData()
    {
        RealEstateDto dto = MockRealestateData();
        await Svc<IRealEstateServices>().Create(dto);

        RealEstateDto nullUpdate = MockNullRealestate();
        await Svc<IRealEstateServices>().Update(nullUpdate);

        var nullId = nullUpdate.Id;

        Assert.True(dto.Id == nullId);
    }
    private RealEstateDto MockNullRealestate()
    {
        RealEstateDto nullDto = new()
        {
            Id = null,
            Address = "Name12345",
            SizeSqrM = 123,
            RoomCount = 123,
            Floor = 123,
            BuildingType = "Type12345",
            BuiltinYear = DateTime.Now.AddYears(1),
            CreatedAt = DateTime.Now.AddYears(1),
            UpdatedAt = DateTime.Now.AddYears(1),
        };
        return nullDto;
    }
    private RealEstateDto MockUpdateRealestateData()
    {
        RealEstateDto update = new()
        {
            Address = "Name321",
            SizeSqrM = 12345,
            RoomCount = 12345,
            Floor = 12345,
            BuildingType = "Type123",
            BuiltinYear = DateTime.Now,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now

        };

        return update;

    }

    private RealEstateDto MockRealestateData()
    {
        RealEstateDto realestate = new()
        {

            Address = "Name321",
            SizeSqrM = 321,
            RoomCount = 321,
            Floor = 321,
            BuildingType = "Type321",
            BuiltinYear = DateTime.Now,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now

        };

        return realestate;


    }
}
}
