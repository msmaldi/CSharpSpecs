using System;

namespace Msmaldi.CSharpSpecs
{
	public class It : Spec
	{
		internal override void Before()
		{
			_ident = 8;
		}
		internal override void Invoke(Action action, string text)
		{
			text = text.PadLeft(_ident + text.Length, ' ');
			action.Invoke();
			Console.WriteLine(text);
		}
	}	
}