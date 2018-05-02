using CST.Interfaces;

namespace CST.FakeData.TypeCodes
{
	public class AnswerTC : IAnswer
	{
		public int Key { get; set; }
		public string Value { get; set; }

		public string Text() => Value;
	}
}