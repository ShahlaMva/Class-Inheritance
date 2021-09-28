using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    class Car
    {
        public string Brand;
        public string Model;
        public int Distance;
        //aggregation
        public Person driver;
        public Car(string brand,string model,int distance)
        {
            Brand = brand;
            Model = model;
            Distance = distance;
        }
    }
}
