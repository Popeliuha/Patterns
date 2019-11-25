using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Worker
    {
        private string name;
        private string post;
        public List<Worker> Subordinates { get; set; }

        public Worker(string name, string post)
        {
            this.name = name;
            this.post = post;
            Subordinates = new List<Worker>();
        }

        public void AddToSubordinates(Worker worker)
        {
            Subordinates.Add(worker);
        }

        public void RemoveFromSubordinates(Worker worker)
        {
            Subordinates.Remove(worker);
        }

        public string ShowInfo()
        {
            return $"Worker's name is {name}, post is {post}.";
        }
    }
}
