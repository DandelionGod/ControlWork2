using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork2
{
	public class Text : File
	{
		//string _content;

		public override void Parce(string input)
		{
			base.Parce(input);
			//throw new NotImplementedException();
		}

		public override void Print(string input)
		{
			Console.WriteLine($"Name {Name} Ext {Extension} Size {Size}");

		}
	}
}
