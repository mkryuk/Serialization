using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsCar = new JamesBondCar[10];
            for (int i = 0; i < 10; i++)
            {
                jsCar[i] = new JamesBondCar(radioId:i.ToString());
            }
            var bf = new XmlSerializer(typeof(JamesBondCar));
            

            using (var writer = new FileStream("data.dat",FileMode.Create,FileAccess.ReadWrite))
            {
                foreach (var jamesBondCar in jsCar)
                {
                    bf.Serialize(writer, jamesBondCar);
                }
                
                //writer.Seek(0, SeekOrigin.Begin);
                //var data = (JamesBondCar[]) bf.Deserialize(writer);
                //Console.WriteLine(data);
            }
        }
    }
}
