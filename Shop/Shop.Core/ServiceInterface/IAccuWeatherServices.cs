using Shop.Core.Dto.AccuWeatherDtos;
using Shop.Core.Dto.OpenWetaherDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.ServiceInterface
{
    public interface IAccuWeatherServices
    {
        //Task<AccuWeatherResultDto>GetCityKeyAsync(AccuWeatherResultDto dto);
        Task<AccuWeatherResultDto> AccuWeatherResult(AccuWeatherResultDto dto);
    }
}
