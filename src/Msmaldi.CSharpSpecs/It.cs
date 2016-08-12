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

			try
			{
				action.Invoke();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"{text}\tSuccedded");
				Console.ResetColor();
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"{text}\tFailed");
				Console.ResetColor();
				System.Console.WriteLine("Exception");
				throw ex;
			}
		}
	}	
}