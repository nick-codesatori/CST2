using CST.Interfaces;
using CST.Logic.Component;
using System.Collections.Generic;
using System.Linq;

namespace CST.Logic.Factory
{
	public static partial class Factory_EdApp
	{
		private class EdApp_Base : IEducatorApplication
		{
			public IEnumerable<IQuestion> Questions() => new List<IQuestion>();
		}

		private class EdApp_Decorator_Questions : Stackable<IEducatorApplication>, IEducatorApplication
		{
			private IEnumerable<IQuestion> _questions { get; }

			public EdApp_Decorator_Questions(IEducatorApplication component, IEnumerable<IQuestion> questions)
			{
				SetComponent(component);
				_questions = questions;
			}

			public IEnumerable<IQuestion> Questions() => Component.Questions().Concat(_questions);
		}
	}
}