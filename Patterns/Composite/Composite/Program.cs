using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        public static void ShowWorkersInfo(Worker e)
        {
            Console.WriteLine($"HeadMaster: {e.ShowInfo()}");
            foreach(var sub in e.Subordinates)
            {
                Console.WriteLine(sub.ShowInfo()); 
            }
        }
        public static void Main(string[] args)
        {
            Worker director = new Worker("Anna", "Head of Beauty salon");
            Worker hairMaster = new Worker("Kateryna", "Hair professional master");
            Worker nailsMaster = new Worker("Nastya", "Nails professional master");

            Worker hairStylist = new Worker("Vasyl", "Hair stylist");
            Worker hairTrainee = new Worker("Galyna", "Hair trainee");
            Worker nailStylist = new Worker("Mark", "Nail stylist");
            Worker nailTrainee = new Worker("Maryna", "Nail trainee");

            director.AddToSubordinates(hairMaster);
            director.AddToSubordinates(nailsMaster);

            hairMaster.AddToSubordinates(hairStylist);
            hairMaster.AddToSubordinates(hairTrainee);

            nailsMaster.AddToSubordinates(nailStylist);
            nailsMaster.AddToSubordinates(nailTrainee);

            ShowWorkersInfo(director);
            ShowWorkersInfo(hairMaster);
            ShowWorkersInfo(nailsMaster);
            hairMaster.RemoveFromSubordinates(hairTrainee);
            ShowWorkersInfo(director);
            ShowWorkersInfo(hairMaster);
            ShowWorkersInfo(nailsMaster);
        }
    }
}
