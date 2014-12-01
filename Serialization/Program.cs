using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        private static void Main(string[] args)
        {
            var jsCar = new List<JamesBondCar>();
            for (int i = 0; i < 10; i++)
            {
                jsCar.Add(new JamesBondCar(radioId: i.ToString()));
            }
            var bf = new BinaryFormatter();

            using (var writer = new FileStream("data.dat", FileMode.Create, FileAccess.ReadWrite))
            {
                bf.Serialize(writer, jsCar);                
            }
        }
    }
}
