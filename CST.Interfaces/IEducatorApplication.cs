using System.Collections.Generic;

namespace CST.Interfaces
{
	public interface IEducatorApplication
	{
		IEnumerable<IQuestion> Questions();
	}
}
