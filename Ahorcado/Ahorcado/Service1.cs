using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ahorcado
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public void Ahorcado()
        {
            string palabra = "cascada";
            char[] palabraAsChars = palabra.ToCharArray();
            string palabraOculta = "";
            char letra;
            int letrasCorrectas = 0;
            int letrasIncorrectas = 0;


            for (int i = 1; i <= palabra.Length; i++)
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
                else
                {
                    Console.WriteLine("\nDigita una letra valida");
                }


                Console.ReadLine();

                Console.WriteLine("\n" + palabraOculta);


            }
            Console.WriteLine("\nFelicidades Ganaste");

            Console.ReadLine();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
