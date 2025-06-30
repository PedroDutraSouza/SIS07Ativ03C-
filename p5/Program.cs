/*
 * Created by SharpDevelop.
 * User: Pedro Dutra
 * Date: 21/05/2025
 * Time: 09:28
 */
using System;

namespace p5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite o primeiro número: ");
			double num = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite o segundo número: ");
			double ndois = Convert.ToDouble(Console.ReadLine());
			Console.Clear();
			if(num > ndois)
			{
				Console.WriteLine(num + " é maior do que " + ndois);
			}
			
			else if(num == ndois)
			{
				Console.WriteLine(num + " é igual a " + ndois);
			}
			else
			{
				Console.WriteLine(num + " não e maior é nem igual a " + ndois);
			}
			Console.ReadKey(true);
		}
	}
}