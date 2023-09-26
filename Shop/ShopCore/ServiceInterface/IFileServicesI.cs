using ShopCore.Domain;
using ShopCore.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.ServiceInterface
{
    public interface IFileServicesI
    {
        void FilesTiApi(RealEstateDto dto, RealEstate realestate);
    }
}
