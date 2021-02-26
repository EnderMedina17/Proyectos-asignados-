using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string info = "";
            int edad = 0;
            double estatura = 0.0;


            Console.WriteLine("ingresar tu edad:");
            info= Console.ReadLine();
            edad = Convert.ToInt32(info);


            if (edad >= 16)
            {
                Console.WriteLine("No podra entrar al parque, esta muy viejo vaya a una licoreria .");
            }
            else
            {


                Console.WriteLine("Bienvenido");

                Console.WriteLine("¿ cual es tu estatura ?");
                info = Console.ReadLine();
                estatura = Convert.ToDouble(info);

                if (estatura < 1.6)
                {
                    Console.WriteLine("Podra entrar a los carritos chocones, la caja de bateo y el lanza pelotas");
                }
                else
                {
                    Console.WriteLine("Podra entrar a los carritos chocones, la caja de bateo ,el lanza pelotas y a la casa embrujada");
                    

                }

                Console.Write("Siga adelante disfrute el parque ...");
                Console.ReadKey();
            }

        }
    }
}
