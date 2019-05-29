using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Many_Func_Calculator
{
	class Program { 
		static void VV(int god, int godrozhdenya)
		{
			god = 2019;
			godrozhdenya = Convert.ToInt32(Console.ReadLine());
			int vozrast = god - godrozhdenya;
			Console.WriteLine(vozrast);
		}
		static void MC ()
		{
			int[] arr = new int[10];
			for (int i = 0; i < 10; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			if (arr[1] > arr[2])
			{
				while (arr[1] > arr[2]) {
					int pp = 0;
					arr[1] = pp;
					arr[1] = arr[2];
					arr[2] = pp;
					Console.WriteLine(arr[1]);
				}
			}
		}
		static void SEC ()
		{
			Console.Write("Введите коэффициэнт a: ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите коэффициэнт b: ");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите коэффициэнт c: ");
			double c = Convert.ToDouble(Console.ReadLine());
			Console.OutputEncoding = Encoding.Unicode;
			Console.Write("Ваше уравнение: ");

			if (a == 1)
			{
				Console.Write("x²");
			}
			else if (a == -1)
			{
				Console.Write("-x²");
			}
			else if (a == 0)
			{
				Console.WriteLine("Default");
			}
			else
			{
				Console.Write("{0}x²", a);
			}

			if (b == 1)
			{
				Console.Write(" + x");
			}
			else if (b == -1)
			{
				Console.Write(" -x");
			}
			else if (b == 0)
			{
				Console.Write("Default");
			}
			else if (b > 1)
			{
				Console.Write(" +{0}x", b);
			}
			else if (b < -1)
			{
				double breversed = (-1) * b;
				Console.Write(" - {0}x", breversed);
			}

			if (c > 0)
			{
				Console.Write(" + {0}", c);
			}
			else if (c == 0)
			{
				Console.Write("Default");
			}
			else if (c < 0)
			{
				Console.Write(" {0}", c);
			}

			Console.WriteLine(" = 0.");
			double d = (b * b);
			double d1 = (4 * a * c);
			double sqrtD = Math.Sqrt(d - d1);
			if (d - d1 < 0)
			{
				Console.WriteLine("default");
			}
			double x1 = ((-1) * b + sqrtD) / 2;
			double x2 = ((-1) * b - sqrtD) / 2;
			Console.WriteLine("x = {0}", x1);
			Console.WriteLine("x = {0}", x2);
		}
		static void add(double x, double y)

		{
			Console.WriteLine(x + y);
		}
		static void sub(double x, double y)
		{
			Console.WriteLine(x - y);
		}
		static void mul(double x, double y)
		{
			Console.WriteLine(x * y);
		}
		static void div(double x, double y)
		{
			Console.WriteLine(x / y);
		}
		static void UC()
		{
			while (true)
			{
				Console.WriteLine();
				Console.WriteLine("Условные обозначения функций:");
				Console.WriteLine("add is сложение, sub is вычитание, mul is умножение, div is деление . . .");
				Console.WriteLine("Введите первое число и нажмите Enter");
				double a = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Введите второе число и нажмите Enter");
				double b = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Введите функцию и нажмите Enter");
				string ArZn = Console.ReadLine();

				switch (ArZn)
				{
					case "add":
						add(a, b);
						break;
					case "sub":
						sub(a, b);
						break;
					case "mul":
						mul(a, b);
						break;
					case "div":
						if (b == 0)
						{
							Console.WriteLine("Делить на ноль нельзя . . .");
							break;
						}
						div(a, b);
						break;
					default:
						Console.WriteLine("Sorry, function {0} not define for our variables {1}, {2}...", ArZn, a, b);
						break;
				}
			}
		}
		public static double Factorial(double x)
		{
			if (x == 0)
			{
				return 1;
			}
			else
			{
				double y = x * Factorial(x - 1);
				Console.Clear();
				Console.WriteLine("Результат:");
				Console.WriteLine(y);
				return y;
			}

		}
		static void StepenC(double z)
		{
			Console.WriteLine("Введите степень(от -5 до 5):");
			int stepen = Convert.ToInt32(Console.ReadLine());
			double a = Convert.ToDouble(Console.ReadLine());
			double result = 1;
			for (int i = 0; i < stepen; i++)
			{
				result = result * a;
			}
		}
		static void SqrtC(double z)
		{
			Console.WriteLine("Введите степень корня, 2 или 4");
			int crn = Convert.ToInt32(Console.ReadLine());
			switch (crn)
			{
				case 2:
					Console.WriteLine(Math.Sqrt(z));
					break;
				case 4:
					Console.WriteLine(Math.Sqrt(Math.Sqrt(z)));
					break;
			} 
			
		}
		static void Power (int x) 
			{
			x = Convert.ToInt32(Console.ReadLine());
			double result = 0;
			result = x * x;
			Console.WriteLine(result);
			}

		static void CONCalc()
		{
			int ost = 0;
			int schetchik = 0;
			int a;
			Console.WriteLine("Введите число для конвертации:");
			a = Convert.ToInt32(Console.ReadLine());
			int[] vyvod = new int[32];
			int[] ReverseVyvod = new int[32];
			while (a > 0)
			{
				ost = a % 2;
				schetchik++;
				a = a / 2;
				vyvod[schetchik] = ost;
			}
			for (int i = 0; i < schetchik; i++)
			{
				while (schetchik > 0)
				{
					ReverseVyvod[i] = vyvod[schetchik];
					schetchik--;
					Console.Write(ReverseVyvod[i]);
				}
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			Console.WriteLine("0 is Converter Calculator, 1 is Power Calculator, 2 is PowerRoot Calculator, 3 is Usual Calculator");
			string choice = Console.ReadLine();
			switch (choice)
			{
				
				case "0":
					CONCalc();
					break;
				case "1":
					double z = Convert.ToDouble(Console.ReadLine());
					StepenC(z);
					break;
				case "2":
					double l = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Введите число");
					SqrtC(l);
					break;
				case "3":
					UC();
					break;
				case "4":
					double a = Convert.ToDouble(Console.ReadLine());
					Factorial(a);
					break;
				case "5":
					SEC();
					break;
				case "6":
					int x = 0;
					Power(x);
					break;
				case "7":
					MC();
					break;
				case "8":
					
					break;
				default:
					Console.WriteLine("Sorry that function isn't define");
					break;
						}
						Console.WriteLine("Press any key to continie");
						Console.ReadKey();
		}
	}
}