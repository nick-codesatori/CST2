using AutoMapper;
using CST.Interfaces;
using CST.Presentation.Models;

namespace CST.Relationships
{
	//public static class CSTMapper
	//{
	//	private 
	//}
	public static class CSTMapping
	{
		private static IMapper _mapper;

		private static IMapper Mapping
		{
			get
			{
				return _mapper ?? (_mapper = new Mapper(MappingProfile.GetInit()));
			}
		}

		public static AnswerVM ToVM(IAnswer iThis)
		{
			var rVM = new AnswerVM();
			Mapping.Map(iThis, rVM);
			return rVM;
		}

		public static QuestionVM ToVM(IQuestion iThis)
		{
			var rVM = new QuestionVM();
			Mapper.Map(iThis, rVM);
			return rVM;
		}

		public static EducatorApplicationVM ToVM(IEducatorApplication iThis)
		{
			var rVM = new EducatorApplicationVM();
			Mapping.Map(iThis, rVM);
			return rVM;
		}
	}
}
