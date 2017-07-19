using SingletonTest.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemple d'instanciation interdite avec un singleton :
            // SingleObject obj = new SingleObject();

            SingleObject obj = SingleObject.getInstance();
            obj.ShowMessage();
            Console.ReadLine();
        }
    }
}
