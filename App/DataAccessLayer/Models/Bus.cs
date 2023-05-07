using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_The_App
{
    public class Bus
    {
        private string _id;
        private float _numberOfSeats;
        private string _storage;

        public string Id { get => _id; set => _id = value; }
        public float NumberOfSeats { get => _numberOfSeats; set => _numberOfSeats = value; }
        public string Storage { get => _storage; set => _storage = value; }
    }
}
