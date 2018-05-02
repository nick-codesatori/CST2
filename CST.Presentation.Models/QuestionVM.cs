using System.Collections.Generic;

namespace CST.Presentation.Models
{
	public class QuestionVM : VM_Base
	{
		public QuestionVM() { }

		public string Text { get; set; }
		public IEnumerable<AnswerVM> Answers { get; set; }
		public int? SelectedAnswerKey { get; set; }
		public string CustomAnswer { get; set; }
	}
}
