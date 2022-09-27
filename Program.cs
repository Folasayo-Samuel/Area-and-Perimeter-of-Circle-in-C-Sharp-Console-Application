// using Internal;
using System;

namespace AreaPerimeterCircle
{
	class Program
	{
		static void Main(string[]args)
		{
			double r, perimeter, area;
			Console.Write("Please write the radius of your circle: ");
			r = Convert.ToDouble(Console.ReadLine());
			perimeter = 2 * 3.14 * r;
			area = 3.14 * Math.Pow(r, 2); // area = 3.14 * r * r;
			Console.WriteLine("============================================================");
			Console.WriteLine($"The perimeter of your circle : {perimeter}");
			Console.WriteLine($"The area of your circle: {area}");
            Console.ReadKey();
        }
	}
}