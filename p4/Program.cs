/*
 * Created by SharpDevelop.
 * User: Pedro Dutra
 * Date: 21/05/2025
 * Time: 09:15
 */
using System;

namespace p4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite o primeiro número: ");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite o segundo número: ");
			int ndois = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite o terceiro número: ");
			int ntres = Convert.ToInt32(Console.ReadLine());
			Console.Clear();
			if(num < ndois && ndois > ntres)
			{
				Console.WriteLine(num + " é menor que " + ndois + ".\n" + ndois + " é maior que " + ntres + ".");
			}
			
			else if(num >= ndois && ndois > ntres)
			{
				Console.WriteLine(num + " não é menor que " + ndois + ".\n" + ndois + " é maior que " + ntres + ".");
			}
			
			else if(num < ndois && ndois <= ntres)
			{
				Console.WriteLine(num + " é menor que " + ndois + ".\n" + ndois + " não é maior que " + ntres + ".");
			}
			
			else if(num >= ndois && ndois <= ntres)
			{
				Console.WriteLine(num + " não é menor que " + ndois + ".\n" + ndois + " não é maior que " + ntres + ".");
			}
			
			Console.ReadKey(true);
		}
	}
}