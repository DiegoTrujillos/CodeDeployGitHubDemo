using System;

namespace PROMEDIOSW
{
    class Program
    {
        static void Main(string[] args)
        {
            Double I, A, B, C;
            Console.WriteLine("Favor de ingresar cuantas calificaciones quiere ingresar");
            A= int.Parse(Console.ReadLine());
            I = 1;
            C = 0;
            while (I<=A) {
                Console.WriteLine("Ingresar promedio "+I);
                B = Double.Parse(Console.ReadLine());
                C = C + B;
                I = I + 1;
            }
            Console.WriteLine("el promedio es " + C/A);
        }
    }
}
