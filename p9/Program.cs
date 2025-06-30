/*
 * Created by SharpDevelop.
 * User: Pedro Dutra
 * Date: 21/05/2025
 * Time: 10:11
 */
using System;

namespace p9
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite o primeiro número: ");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite o segundo número: ");
			int ndois = Convert.ToInt32(Console.ReadLine());
			int dif = Math.Abs(num - ndois);
			
			Console.Clear();
			
			if(dif > 10)
			{
				Console.WriteLine("A diferença entre " + num + " e " + ndois + " é maior do que 10.");
			}
			else if(dif == 10)
			{
				Console.WriteLine("A diferença entre " + num + " e " + ndois + " é igual a 10.");
			}
			else
			{
				Console.WriteLine("A diferença entre " + num + " e " + ndois + " é menor do que 10.");
			}
	
			Console.ReadKey(true);
		}
	}
}