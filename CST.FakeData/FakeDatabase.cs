using CST.FakeData.Models;
using CST.FakeData.TypeCodes;
using System.Collections.Generic;
using static CST.Common.Enumerations;

namespace CST.FakeData
{
	public static class FakeDatabase
	{
		public static IEnumerable<AppQuestionDM> GetRelevantQuestionsByEdAppType(EducatorApplications edAppType)
		{
			switch (edAppType)
			{
				case EducatorApplications.Credential: return GetApplicationQuestions_Credential();
				case EducatorApplications.Endorsement: return GetApplicationQuestions_Endorsement();
				case EducatorApplications.Entitlement: return GetApplicationQuestions_Entitlement();
				case EducatorApplications.Default: return GetApplicationQuestions_Default();
				default: throw new System.Exception();
			}
		}

		public static IEnumerable<AppQuestionDM> GetApplicationQuestions_Default()
		{
			return new List<AppQuestionDM>
			{
				new AppQuestionDM
				{
					Question = new QuestionTC
					{
						Key = 1,
						Value = "Something generic about contact info?"
					}
				}
			};
		}

		public static IEnumerable<AppQuestionDM> GetApplicationQuestions_Credential()
		{
			return new List<AppQuestionDM>
			{
				new AppQuestionDM
				{
					Question = new QuestionTC
					{
						Key = 1,
						Value = "Which Credential are you applying for?"
					},
					PredefinedAnswers = new List<AnswerTC>
					{
						new AnswerTC
						{
							Key = 1,
							Value = "PEL"
						},
						new AnswerTC
						{
							Key = 2,
							Value = "ELS"
						},
						new AnswerTC
						{
							Key = 3,
							Value = "SUB"
						}
					},
					SelectedAnswerKey = null
				},
				new AppQuestionDM
				{
					Question = new QuestionTC
					{
						Key = 2,
						Value = "Do you have an existing out of state License?"
					},
					PredefinedAnswers = new List<AnswerTC>
					{
						new AnswerTC
						{
							Key = 1,
							Value = "Yes"
						},
						new AnswerTC
						{
							Key = 2,
							Value = "No"
						},
						new AnswerTC
						{
							Key = 3,
							Value = "Unsure"
						}
					},
					SelectedAnswerKey = null
				}
			};
		}

		public static IEnumerable<AppQuestionDM> GetApplicationQuestions_Endorsement()
		{
			return new List<AppQuestionDM>
			{
				new AppQuestionDM
				{
					Question = new QuestionTC
					{
						Key = 1,
						Value = "Which Endorsement are you applying for?"
					},
					PredefinedAnswers = new List<AnswerTC>
					{
						new AnswerTC
						{
							Key = 1,
							Value = "Geography"
						},
						new AnswerTC
						{
							Key = 2,
							Value = "Literature"
						},
						new AnswerTC
						{
							Key = 3,
							Value = "Spanish"
						}
					}
				}
			};
		}

		public static IEnumerable<AppQuestionDM> GetApplicationQuestions_Entitlement()
		{
			return new List<AppQuestionDM>
			{
				new AppQuestionDM
				{
					Question = new QuestionTC
					{
						Key = 1,
						Value = "Which Entitlement are you redeeming?"
					},
					PredefinedAnswers = new List<AnswerTC>
					{
						new AnswerTC
						{
							Key = 1,
							Value = "Your First Entitlement"
						},
						new AnswerTC
						{
							Key = 2,
							Value = "Your Second Entitlement"
						}
					}
				}
			};
		}
	}
}
