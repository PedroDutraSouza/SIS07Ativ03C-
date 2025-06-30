/*
 * Created by SharpDevelop.
 * User: Pedro Dutra
 * Date: 21/05/2025
 * Time: 09:09
 */
using System;

namespace p3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite o primeiro número: ");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite o segundo número: ");
			int ndois = Convert.ToInt32(Console.ReadLine());
			Console.Clear();
			if(num == ndois)
			{
				Console.WriteLine(num + " é " + ndois + " são iguais");
			}
			
			else
			{
				Console.WriteLine(num + " é " + ndois + " não são iguais");
			}
			
			Console.ReadKey(true);
		}
	}
}