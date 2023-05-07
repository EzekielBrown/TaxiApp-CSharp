using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_The_App
{
    public class Driver
    {
        private string _id;
        private string _name;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
    }
}
