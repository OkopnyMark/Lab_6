using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pryamougo;
namespace lab6
{
    class Program
    {
        static double Plus(double p1, int p2)
        {
            return p1 + p2;
        }
        static double Multiply(double p1, int p2)
        {
            return p1 * p2;
        }
        delegate double PlusOrMultiply(double p1, int p2);
        static void PlusOrMultiplyMethod(string str, double p1, int p2, PlusOrMultiply PlusOrMultiplyParam) 
        {
            double Result = PlusOrMultiplyParam(p1, p2); Console.WriteLine(str + Result.ToString()); 
        }
        static void PlusOrMultiplyMethod2(string str , double a, int b , Func<double,int,double> f )        {            double Result = f(a,b);            Console.WriteLine(str+Result);        }
    
        static void Main(string[] args)
        {
            double m = 5.1;
            int n = 4;
            Console.WriteLine("m = " + m + "  ,  n = " + n);
            PlusOrMultiplyMethod(" Плюс:", m , n , Plus);
            PlusOrMultiplyMethod(" Плюс:", m, n, Multiply);
            PlusOrMultiplyMethod2(" Создание экземпляра делегата c Func<> " , m, n,
                (double x, int y) =>
                {
                double z = x + y;
                return z;
                 }
                );
            PlusOrMultiplyMethod2("Plus:  ", m, n, Plus);
            Console.WriteLine("\nПример группового делегата");
            Action<double, int> a1 = (x, y) =>
            {
                Console.WriteLine("{0} + {1} = {2}",
                    x, y, x + y);
            };
            Action<double, int> a2 = (x, y) =>
            {
                Console.WriteLine("{0} - {1} = {2}",
                    x, y, x - y);
            };
            Action<double, int> a3 = (x, y) =>
            {
                Console.WriteLine("{0} * {1} = {2}",
                    x, y, x*y);
            };
            Action<double, int> group = a1 + a2;
            group += a3;  
            Console.WriteLine("добавление вызова метода из группового делегата\n");
            group(5.2, 3);
            Console.WriteLine("\nудаление вызова метода из группового делегата\n");
            group -= a3;
            group(5.2, 3);



            pryamoug p1 = new pryamoug(2, 3);
            //System.Type tp1 = p1.GetType();

            //System.Reflection.Assembly tp2 = typeof(System.Int32).Assembly;

            //Mes            MessageBoxsageBox.Show(tp1.ToString()+"\n"+tp2.ToString());
            Console.WriteLine(Reflect.MethodReflectInfo<pryamoug>(p1));
                



            Console.WriteLine("Нажмите любую клавишу для завершения");

            Console.ReadKey();
        }
        
    }
}
