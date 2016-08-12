namespace Msmaldi.CSharpSpecs
{
	public class SpecContext
	{
		public readonly Describe describe;
		public readonly It it;
		public readonly Context context;

		public SpecContext()
		{
			describe = new Describe();
			it = new It();
			context = new Context();
		}
	}
}
