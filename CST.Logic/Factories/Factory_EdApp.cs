using CST.FakeData;
using CST.Interfaces;
using static CST.Common.Enumerations;

namespace CST.Logic.Factory
{
	public static partial class Factory_EdApp
	{
		//Handler
		public static IEducatorApplication ForAppType(EducatorApplications appType)
		{
			switch (appType)
			{
				case EducatorApplications.Credential: return ForCredential();
				case EducatorApplications.Endorsement: return ForEndorsement();
				case EducatorApplications.Entitlement: return ForEntitlement();
				default: throw new System.Exception();
			}
		}

		//Builders
		private static IEducatorApplication ForCredential()
		{
			var defaultApp = new EdApp_Decorator_Questions(new EdApp_Base(), FakeDatabase.GetApplicationQuestions_Default());
			return new EdApp_Decorator_Questions(defaultApp, FakeDatabase.GetApplicationQuestions_Credential());
		}

		private static IEducatorApplication ForEndorsement()
		{
			var defaultApp = new EdApp_Decorator_Questions(new EdApp_Base(), FakeDatabase.GetApplicationQuestions_Default());
			return new EdApp_Decorator_Questions(defaultApp, FakeDatabase.GetApplicationQuestions_Endorsement());
		}

		private static IEducatorApplication ForEntitlement()
		{
			var defaultApp = new EdApp_Decorator_Questions(new EdApp_Base(), FakeDatabase.GetApplicationQuestions_Default());
			return new EdApp_Decorator_Questions(defaultApp, FakeDatabase.GetApplicationQuestions_Entitlement());
		}
	}
}