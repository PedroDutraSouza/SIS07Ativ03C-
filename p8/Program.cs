/*
 * Created by SharpDevelop.
 * User: Pedro Dutra
 * Date: 21/05/2025
 * Time: 10:05
 */
using System;

namespace p8
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			int num = Convert.ToInt32(Console.ReadLine());
			if(num < 0)
			{
				Console.WriteLine("O número é negativo.");
			}
			else
			{
				Console.WriteLine("O número é positivo.");
			}
			Console.ReadKey(true);
		}
	}
}