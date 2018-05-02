using System.Collections.Generic;

namespace CST.Interfaces
{
	public interface IQuestion
	{
		string Text();
		IEnumerable<IAnswer> Answers();
		int? SelectedAnswerKey();
		string CustomAnswer();
	}
}
