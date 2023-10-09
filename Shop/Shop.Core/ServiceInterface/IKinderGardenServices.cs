using Shop.Core.Domain;
using Shop.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.ServiceInterface
{
    public interface IKinderGardenServices
    {
        Task<Kindergarden> Create(KinderGardenDto dto);

        Task<Kindergarden> GetAsync(Guid id);

        Task<Kindergarden> Update(KinderGardenDto dto);

        Task<Kindergarden> Delete(Guid id);
    }
}
