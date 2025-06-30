/*
 * Created by SharpDevelop.
 * User: Pedro Dutra
 * Date: 22/05/2025
 * Time: 08:22
 */
using System;

namespace p10
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			double num = Convert.ToDouble(Console.ReadLine());
			
			Console.Clear();
			
			if(num == 0)
			{
				Console.WriteLine("O número é igual a zero.");
			}
			else
			{
				Console.WriteLine("O número não e igual a zero.");
			}
	
			Console.ReadKey(true);
		}
	}
}