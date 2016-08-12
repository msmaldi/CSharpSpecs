using System;

namespace Msmaldi.CSharpSpecs
{
	public abstract class Spec
	{
		protected int _ident;

		public Action this[string text]
		{
			set
			{
				Before();
				Invoke(value, text);
				After();
			}
		}

		internal virtual void After() { }
		internal virtual void Before() { }

		internal virtual void Invoke(Action action, string text)
		{
			text = text.PadLeft(_ident + text.Length, ' ');

			Console.WriteLine(text);
			action.Invoke();
		}
	}	
}
	