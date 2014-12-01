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
            var prefs = new UserPrefs();
            prefs.BackgroundColor = ConsoleColor.Black;
            prefs.ForegroundColor = ConsoleColor.Red;
            prefs.FontSize = 25;

            var binaryFormatter = new BinaryFormatter();
            using (Stream fStream = new FileStream("user.dat", FileMode.Create, FileAccess.ReadWrite, FileShare.None))
            {
                binaryFormatter.Serialize(fStream, prefs);
                fStream.Seek(0, SeekOrigin.Begin);
                var data = (UserPrefs) binaryFormatter.Deserialize(fStream);
                Console.WriteLine("ForegroundColor:{0} BackgroundColor:{1} FontSize:{2}", data.ForegroundColor, data.BackgroundColor, data.FontSize);
            }
        }
    }
}
