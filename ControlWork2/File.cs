using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork2
{
	public abstract class File
	{
		//string _name;
		//string _expantion;
		//string _size;

		public string Name { get; private set; }
		public string Extension { get; private set; }
		public string Size { get; private set; }

		public virtual void Parce(string input)
		{
			string[] splitInput = input.Split(new char[] { '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);

			string nameWithExt = splitInput[0];
			//"name.so.me.txt".Substring("name.so.me.txt")
			Size = splitInput[1];
		}

		public virtual void Print(string input)
		{
			Console.WriteLine($"Name {Name} Ext {Extension} Size {Size}");
			Console.ReadKey();
		}
		//public override string ToString = "";

	}
}
