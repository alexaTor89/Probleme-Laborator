using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    class Program
    {
        static void Main(string[] args)
        {
            P1();

            P2();

            P3();

            P4();

            P5();

            P6();
        }

        private static void P6()
        {
            Console.WriteLine("P6 . Să se afişeze primele n numere prime.");
            int start = 1;
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int i = 1;

            Console.WriteLine($"Numerele prime pana la {n}");

            for (start = start; start <= n; start++)
            {
                for (i = 1; i <= start; i++)
                {
                    if (start % i == 0)
                        count++;
                }
                if (count == 2)
                    Console.WriteLine($"{start}");
                count = 0;
            }
        }

        private static void P5()
        {
            Console.WriteLine("P5 Să se determine cel mai mare divizor comun şi cel mai mic multiplu comun pentru două numere întregi a şi b");
            int a, b, x, y, cmmmc;

            Console.Write("a = ");
            x = a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            y = b = int.Parse(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            cmmmc = (x * y) / a;
            Console.WriteLine($"Cel mai mare divizor comun este {a}");
            Console.WriteLine($"Cel mai mic multiplu comun este {cmmmc}");
        }

        private static void P4()
        {
            Console.WriteLine("P4 Să se determine numerele perfecte din intervalul [a,b], pentru a,b date");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int i = 1;
            int total = 0;
            int x = 0;

            Console.WriteLine($"Numere perfecte din intervalul [{a},{b}]");
            for (a = a; a <= b; a++)
            {
                for (i = 1; i < a; i++)
                {
                    if (a % i == 0)
                        total += i;
                }
                if ((total == a) && (a != 0))
                {
                    x = 1;
                    Console.Write(a + " ");
                }
                total = 0;
            }
            if (x == 0)
                Console.WriteLine("Nu exista nici un numar pefect in acest interval");
        }
    

        private static void P3()
        {
            Console.WriteLine("P3 Să se verifice dacă numărul n este perfect. (Un număr n este perfect dacă este egal cu suma divizorilor lui diferiţi de n; exemplu: 6 = 1 + 2 + 3).");
            Console.WriteLine("Introduceti un numar ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int total = 0;

            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                    total += i;
            }
            if (total == n)
                Console.WriteLine($"{n} este un numar pefect");
            else
                Console.WriteLine($"{n} nu este un numar pefect");
        }

        private static void P2()
        {
            Console.WriteLine("Fie i,j,k. Să se determine restul împărţirii numărului natural i^j la k.");
            Console.WriteLine();

            Console.WriteLine("Introduceti valoarea lui i:");
            var i = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui j:");
            var j = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui k:");
            var k = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"{i}^{j}/{k} are restul = {Math.Pow(i, j) % k}" );

        }

        private static void P1()
        {
            Console.WriteLine("P1 1. Sa se scrie un program care converteste temperatura din grade celsius in grade fahrenheit si invers utilizand instructiunea switch.");
            double F, C, temp;
            
            Console.WriteLine("Introduceti temperatura din care trasnformati: 1 pt °C sau 2 pt °F");
            temp = double.Parse(Console.ReadLine());

            switch (temp)
            {
                case 1:
                    Console.WriteLine("Introduceti valoarea pt grade Celsius:");
                    C = Convert.ToDouble(Console.ReadLine());
                    F = C * 9 / 5 + 32;
                    Console.WriteLine($"{C}°C in Fahrenheit este: {F}°F");
                    break;
                case 2:
                    Console.WriteLine("Enter the value of Fahrenheit:");
                    F = Convert.ToDouble(Console.ReadLine());
                    C = (F - 32) * 5 / 9;
                    Console.WriteLine($"{F}°F in Fahrenheit este: {C}°C");
                    break;

            }
           
            
        }
    }
}
