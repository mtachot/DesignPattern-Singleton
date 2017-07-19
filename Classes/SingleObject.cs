using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTest.Classes
{
    public class SingleObject
    {
        private static SingleObject instance = new SingleObject();

        // Le constructeur est rendu privé, ce qui empêche l'instanciation en dehors de la classe
        private SingleObject(){}

        public static SingleObject getInstance()
        {
            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello world !");
        }
    }
}
