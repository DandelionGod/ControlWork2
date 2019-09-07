using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork2
{
	public class Image : File
	{
		//string _resolution;
		public string Resolution { get; private set; }

		public override void Parce(string input)
		{

			base.Parce(input);
			//string splitInput = input.Split(';');
			throw new NotImplementedException();
		}

		public override void Print(string input)
		{
			Console.WriteLine($"Name {Name} Ext {Extension} Size {Size}");

		}
	}
}
