/*
 * Created by SharpDevelop.
 * User: Pedro Dutra
 * Date: 21/05/2025
 * Time: 09:46
 */
using System;

namespace p6
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			int num = Convert.ToInt32(Console.ReadLine());
			
			if(num % 2 == 0)
			{
			Console.WriteLine("O número é par.");
			}
			   
			else
			{
				Console.WriteLine("O número é impar.");
			}
			Console.ReadKey(true);
		}
	}
}