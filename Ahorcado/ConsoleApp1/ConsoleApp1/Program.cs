using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            string palabra = "cascada";
            char[] palabraAsChars = palabra.ToCharArray();
            string palabraOculta = "";
            char letra;
            int letrasCorrectas = 0;
            int letrasIncorrectas = 0;



            for (int i = 1; i <= palabra.Length; i ++)
            {
                palabraOculta = palabraOculta + "_ ";

            }
            //Console.WriteLine("La palabra es: " + palabra.ToUpper());

            Console.WriteLine("\nLa palabra oculta es: " + palabraOculta);

            while (letrasCorrectas != palabra.Length)
            {

                Console.WriteLine("\nIntroduzca una letra");

                letra = Console.ReadKey().KeyChar;

                if (char.IsLetter(letra))
                {
                    bool bandera = false;
                    char[] palabraOcultaAsChars = palabraOculta.ToArray();

                    for (int i = 0; i < palabra.Length; i++)
                    {
                        if (palabraAsChars[i].Equals(char.ToLower(letra)))
                        {
                            letrasCorrectas++;
                            palabraOcultaAsChars[i * 2] = letra;

                            palabraOculta = new string(palabraOcultaAsChars).ToUpper();
                            bandera = true;
                        }
                    }
                    if (!bandera)
                    {
                        Console.WriteLine("\nLo siento la letra " + letra + " no se encuentra en la palabra");


                        letrasIncorrectas++;
                    }
                }
                else{
                    Console.WriteLine("\nDigita una letra valida");
                }
               

                Console.ReadLine();

                Console.WriteLine("\n"+palabraOculta);


            }
            Console.WriteLine("\nFelicidades Ganaste");

            Console.ReadLine();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        
       

    }
}
