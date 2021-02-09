using System;

namespace символи_2
{
    class Program
    {
        static void Main(string[] args)
		{
			char char_literal = 'A';
			char hexadecimal = '\x0041';
			char integer = (char)65;
			char unicode = '\u0041';

			Console.WriteLine(char_literal + " " + hexadecimal + " " + integer + " " + unicode);

			Console.ReadKey();
		}
	}
}
