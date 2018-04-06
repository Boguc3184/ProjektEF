using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.ClientConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Generycznosc<object> generycznoscInt =
                new Generycznosc<object>();


        }
    }

    class Generycznosc<Cokolwiek> //generycznosc - zwracamy rozne typy jedna klasa
    {
        public Cokolwiek GetData(Cokolwiek i)
        {
            return i;
        }

        //public int GetData(int i)
        //{
        //    return i;
        //}

        //public string GetData(string i)
        //{
        //    return i;
        //}


    }
}
