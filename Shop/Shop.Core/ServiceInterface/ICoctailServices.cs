using Shop.Core.Dto.CoctailDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.ServiceInterface
{
	public interface ICoctailServices
	{
		Task<CoctailResultDto> CoctailResult(CoctailResultDto dto);
	}
}
