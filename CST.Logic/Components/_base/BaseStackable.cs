namespace CST.Logic.Component
{
	public abstract class Stackable<T>
	{
		protected T Component;

		public void SetComponent(T component)
		{
			Component = component;
		}
	}
}
