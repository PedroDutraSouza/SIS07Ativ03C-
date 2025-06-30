/*
 * Created by SharpDevelop.
 * User: Pedro Dutra
 * Date: 21/05/2025
 * Time: 08:40
 */
using System;

namespace Lista_03
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
			if(num > ndois)
			{
				Console.WriteLine(num + " é maior do que " + ndois);
			}
			
			else if(ndois > num)
			{
				Console.WriteLine(num + " não é maior do que " + ndois);
			}
			
			Console.ReadKey(true);
		}
	}
}