using System;

namespace Msmaldi.CSharpSpecs
{
	public class Describe : Spec
	{
		internal override void Before()
		{
			Console.WriteLine();
		}

		internal override void After()
		{
			Console.WriteLine();
		}
	}	
}
	