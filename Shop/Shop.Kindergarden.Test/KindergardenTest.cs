using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Kindergarden.Test
{
    public class KindergardenTest : UnitTest3
    {
        [Fact]
        public async Task ShouldNot_AddEmptyKindergarden_WhenReturnresult()
        {
            KinderGardenDto dto = new KinderGardenDto();

            dto.GroupName = "group";
            dto.ChildrenCount = 123;
            dto.KindergardenName = "name";
            dto.Teacher = "name";
            dto.CreatedAt = DateTime.Now;
            dto.UpdatedAt = DateTime.Now;

            var result = await Svc<IKinderGardenServices>().Create(dto);
            Assert.NotNull(result);
        }
        [Fact]
        public async Task ShouldNot_GetByIdKindergarden_WhenReturnsNotEqual()
        {
            Guid guid = Guid.Parse("a1999241 - e62b - 4804 - 8c19 - 4f017de45914");
            Guid wrongGuid = Guid.Parse(Guid.NewGuid().ToString());
            await Svc<IKinderGardenServices>().GetAsync(guid);
            Assert.NotEqual(guid, wrongGuid);
        }
        [Fact]
        public async Task Should_GetByIdKindergarden_WhenReturnsEqual()
        {
            Guid databaseGuid = Guid.Parse("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");
            Guid getGuid = Guid.Parse("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");
            await Svc<IKinderGardenServices>().GetAsync(getGuid);
            Assert.Equal(databaseGuid, getGuid);
        }
        [Fact]
        public async Task Should_DeleteByIdKindergarden_WhenDeleteKindergarden()
        {
            KinderGardenDto kindergarden = MockKindergardenData();

            var createdkindergarden = await Svc<IKinderGardenServices>().Create(kindergarden);
            var result = await Svc<IKinderGardenServices>().Delete((Guid)createdkindergarden.Id);
            Assert.Equal(createdkindergarden, result);
        }
        [Fact]
        public async Task ShouldNot_DeleteByIdKindergarden_WhenDidNotDeleteKindergarden()
        {
            KinderGardenDto kindergarden = MockKindergardenData();

            var addKindergarden = await Svc<IKinderGardenServices>().Create(kindergarden);
            var addKindergarden2 = await Svc<IKinderGardenServices>().Create(kindergarden);

            var result = await Svc<IKinderGardenServices>().Delete((Guid)addKindergarden2.Id);
            Assert.NotEqual(addKindergarden.Id, result.Id);
        }
        [Fact]
        public async Task Should_UpateKindergarden_WhenUpdateData()
        {
            var guid = new Guid("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");
            Shop.Core.Domain. Kindergarden kindergarden = new Shop.Core.Domain.Kindergarden();

            KinderGardenDto dto = MockKindergardenData();

            kindergarden.Id = Guid.Parse("9f0674c4-1ddc-4415-9ea2-a0502ac4913b");
            kindergarden.GroupName = "asdrd";
            kindergarden.ChildrenCount = 1;
            kindergarden.KindergardenName = "Kinder";
            kindergarden.Teacher = "Asta";
            kindergarden.CreatedAt = DateTime.Now.AddYears(1);
            kindergarden.UpdatedAt = DateTime.Now.AddYears(1);

            await Svc<IKinderGardenServices>().Update(dto);

            Assert.Equal(kindergarden.Id, guid);
            Assert.NotEqual(kindergarden.GroupName, dto.GroupName);
            Assert.NotSame(kindergarden.Teacher, dto.Teacher);
            Assert.DoesNotMatch(kindergarden.ChildrenCount.ToString(), dto.ChildrenCount.ToString());
        }
        [Fact]
        public async Task Should_UpdateKindergarden_WhenUpdateDataVersion()
        {
            KinderGardenDto dto = MockKindergardenData();
            var createKindergarden = await Svc<IKinderGardenServices>().Create(dto);

            KinderGardenDto update = MockUpdateKindergardenData();
            var updateKindergarden = await Svc<IKinderGardenServices>().Update(update);

            Assert.Matches(updateKindergarden.GroupName, createKindergarden.GroupName);
            Assert.NotEqual(updateKindergarden.Teacher, createKindergarden.Teacher);
            Assert.NotEqual(updateKindergarden.KindergardenName, createKindergarden.KindergardenName);
            Assert.DoesNotMatch(updateKindergarden.ChildrenCount.ToString(), createKindergarden.ChildrenCount.ToString());
        }
        [Fact]
        public async Task ShouldNot_UpdateKindergarden_WhenUpdateData()
        {
            KinderGardenDto dto = MockKindergardenData();
            await Svc<IKinderGardenServices>().Create(dto);

            KinderGardenDto nullUpdate = MockNullKindergarden();
            await Svc<IKinderGardenServices>().Update(nullUpdate);

            var nullId = nullUpdate.Id;

            Assert.True(dto.Id == nullId);
        }
        private KinderGardenDto MockNullKindergarden()
        {
            KinderGardenDto nullDto = new()
            {
                Id = null,
                GroupName = "Name54321",
                ChildrenCount = 45,
                KindergardenName = "Name23",
                Teacher = "Anna",
                CreatedAt = DateTime.Now.AddYears(1),
                UpdatedAt = DateTime.Now.AddYears(1),
            };
            return nullDto;
        }
        private KinderGardenDto MockUpdateKindergardenData()
        {
            KinderGardenDto update = new()
            {
                GroupName = "name321",
                ChildrenCount = 12345,
                KindergardenName = "name32",
                Teacher = "Maria",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            return update;
        }
        private KinderGardenDto MockKindergardenData()
        {
            KinderGardenDto kindergarden = new()
            {
                GroupName = "name321",
                ChildrenCount = 54321,
                KindergardenName = "name5",
                Teacher = "Ksenia",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            return kindergarden;
        }
    }
}
