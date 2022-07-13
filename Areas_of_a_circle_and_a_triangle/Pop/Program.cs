using System;
using System.Linq;

namespace Собес
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите фигуру Круг или Треугольник : ");
			string si = Console.ReadLine();
			var array = new decimal[3];
			if (si == "Круг")
			{
				Console.WriteLine("Введите радиус");
				float rad = Console.Read();
				double oi = Math.PI * Math.Pow(rad, 2);
				Console.WriteLine(oi);
			}
			else if (si == "Треугольник" || si == "треугольник")
			{
				for (int i = 0; i < 3; i++)
				{

					Console.Write("Введите {0} сторону : ", i + 1);
					array[i] = Convert.ToDecimal(Console.ReadLine());
					double pola1 = Convert.ToDouble(array[0]);
					double pola2 = Convert.ToDouble(array[1]);
					double pola3 = Convert.ToDouble(array[2]);
					double p = pola1 + pola2 + pola3;
					double prov = pola1 + pola2;
					p /= 2;
					double los = Math.Sqrt(p * (p - pola1) * (p - pola2) * (p - pola3));
					if ((array[0] * array[0] + array[1] * array[1] == array[2] * array[2]) || (array[0] * array[0] + array[2] * array[2] == array[1] * array[1]) || (array[2] * array[2] + array[1] * array[1] == array[0] * array[0]))
					{
						Console.WriteLine($"Треугольник прямоугольный: {los}");
					}
					else if (pola3 > prov)
					{
						Console.WriteLine("Cумма 2 сторон не должна превышать 3");
						return;
					}
					else
					{
						Console.WriteLine(los);
					}

				}

			}

			else
			{
				Console.WriteLine("Не введена фигура");
			}
			Console.ReadLine();
		}
	}

}