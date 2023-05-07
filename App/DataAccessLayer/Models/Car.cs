using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_The_App
{
    public class Car
    {
        private string _id;
        private string _bodyType;
        private float _numberOfSeats;

        public string Id { get => _id; set => _id = value; }
        public string BodyType { get => _bodyType; set => _bodyType = value; }
        public float NumberOfSeats { get => _numberOfSeats; set => _numberOfSeats = value; }
    }
}
