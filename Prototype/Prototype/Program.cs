using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = new Prototype();
            prototype.Class = "Стрижка";
            prototype.State = "";

            var Haircut = prototype.Clone() as Prototype;
            Haircut.Class = "Середня стрижка";
            Haircut.State = "Середня";
            Console.WriteLine($"Cloned {Haircut.Class}");

            var BobHaircut = Haircut.Clone();
            BobHaircut.Class = "Боб";
            BobHaircut.State = "Коротка";
            Console.WriteLine($"Cloned {BobHaircut.Class}");

            var CareHaircut = Haircut.Clone();
            CareHaircut.Class = "Каре";
            CareHaircut.State = "Не коротка";
            Console.WriteLine($"Cloned {CareHaircut.Class}");
        }
    }
}
