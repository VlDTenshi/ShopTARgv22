﻿using Shop.Core.Dto.OpenWetaherDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.ServiceInterface
{
	public interface IWeatherForecastServices
	{
		Task<OpenWeatherResultDto> OpenWeatherResult(OpenWeatherResultDto dto);
	}
}
