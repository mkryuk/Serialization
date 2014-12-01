using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsCar = new JamesBondCar();
            var bf = new BinaryFormatter();

            using (var writer = new FileStream("data.dat",FileMode.Create,FileAccess.ReadWrite))
            {
                bf.Serialize(writer,jsCar);
                writer.Seek(0, SeekOrigin.Begin);
                var data = (JamesBondCar) bf.Deserialize(writer);
                Console.WriteLine(data);
            }
        }
    }
}
