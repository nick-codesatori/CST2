using CST.Logic.Factory;
using CST.Presentation.Models;
using CST.Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using static CST.Common.Enumerations;

namespace CST
{
	static public class Program
	{
		static public void Main(/*string[] args*/)
		{
			EducatorApplicationVM EA_CRED = CSTMapping.ToVM(Factory_EdApp.ForAppType(EducatorApplications.Credential));
			PrintQuestionsAndAnswers(EA_CRED.Questions);

			EducatorApplicationVM EA_END = CSTMapping.ToVM(Factory_EdApp.ForAppType(EducatorApplications.Endorsement));
			PrintQuestionsAndAnswers(EA_END.Questions);

			EducatorApplicationVM EA_ENT = CSTMapping.ToVM(Factory_EdApp.ForAppType(EducatorApplications.Entitlement));
			PrintQuestionsAndAnswers(EA_ENT.Questions);
		}

		private static void PrintQuestionsAndAnswers(IEnumerable<QuestionVM> questions)
		{
			foreach (QuestionVM question in questions)
			{
				Console.WriteLine(question.Text);
				PrintAnswers(question.Answers);
				Console.WriteLine(String.Empty);
			}
		}

		private static void PrintAnswers(IEnumerable<AnswerVM> answers)
		{
			if (answers.ToList().Count > 0)
			{
				foreach (AnswerVM answer in answers)
				{
					Console.WriteLine(answer.Text);
				}
			}
			else
			{
				Console.WriteLine("No Predefined Answers");
			}
		}
	}
}
