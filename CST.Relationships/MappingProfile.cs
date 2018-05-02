using AutoMapper;
using CST.Interfaces;
using CST.Presentation.Models;

namespace CST.Relationships
{
	public static class MappingProfile
	{
		public static IConfigurationProvider GetInit()
		{
			return new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<IAnswer, AnswerVM>();
				cfg.CreateMap<IQuestion, QuestionVM>();
				cfg.CreateMap<IEducatorApplication, EducatorApplicationVM>();
			});
		}
	}
}
