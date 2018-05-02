using CST.FakeData.TypeCodes;
using CST.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CST.FakeData.Models
{
	public class AppQuestionDM : IQuestion
	{
		public virtual QuestionTC Question { get; set; }
		public virtual ICollection<AnswerTC> PredefinedAnswers { get; set; }
		public string CustomAnswer { get; set; }
		public int? SelectedAnswerKey { get; set; }

		public AppQuestionDM()
		{
			PredefinedAnswers = null;
			CustomAnswer = null;
			SelectedAnswerKey = null;
		}

		//interface methods
		public string Text() => Question.Value;
		IEnumerable<IAnswer> IQuestion.Answers() => PredefinedAnswers?.ToList() ?? new List<AnswerTC>();
		int? IQuestion.SelectedAnswerKey() => SelectedAnswerKey;
		string IQuestion.CustomAnswer() => CustomAnswer;
	}
}