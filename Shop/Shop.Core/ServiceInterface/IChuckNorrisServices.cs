using Shop.Core.Dto.Chuck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.ServiceInterface
{
	public interface IChuckNorrisServices
	{
		Task<OpenChuckNorrisResultDto> OpenChuckNorrisResult(OpenChuckNorrisResultDto dto);

	}
}
