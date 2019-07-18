using AhorcadoApp.AhorcadoReference;
using System;

namespace AhorcadoApp

{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");

            //Console.WriteLine(client.GetData(67));
            //Console.ReadLine();

            //XDocument doc = XDocument.Load("palabras.xml");
            //var count = doc.Descendants("palabras")
            //               .Descendants("palabra")
            //               .Count();

            //Console.WriteLine(count);
            //Console.ReadLine();


            //XElement node = doc.XPathSelectElement("palabras/palabra");
            //string text = node.Value;
            //Console.WriteLine(text);



            //XmlTextReader reader = new XmlTextReader("palabras.xml");


            //while (reader.Read())
            //{
            //    switch (reader.NodeType)
            //    {
            //        //case XmlNodeType.Element: // The node is an element.
            //        //    Console.Write("<" + reader.Name);
            //        //    Console.WriteLine(">");
            //        //    break;
            //        case XmlNodeType.Text: //Display the text in each element.
            //            Console.WriteLine(reader.Value);
            //            break;
            //        //case XmlNodeType.EndElement: //Display the end of the element.
            //        //    Console.Write("</" + reader.Name);
            //        //    Console.WriteLine(">");
            //        //    break;
            //    }
            //}
            Console.ReadLine();







            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
