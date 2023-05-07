using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_The_App
{
    public class Van
    {
        private string id;
        private float numberOfSeats;

        public string Id { get => id; set => id = value; }
        public float NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }
    }
}
