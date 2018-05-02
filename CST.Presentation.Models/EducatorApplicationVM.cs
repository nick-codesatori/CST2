using System.Collections.Generic;

namespace CST.Presentation.Models
{
	public class EducatorApplicationVM : VM_Base
	{
		public EducatorApplicationVM() { }

		public IEnumerable<QuestionVM> Questions { get; set; }
	}
}
