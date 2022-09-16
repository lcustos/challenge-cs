using System;
using System.ComponentModel;

namespace CSharpDiscovery.Quest04
{
    public class Car : Vehicule
    {
        public string Model = "Unknow";
        public Car()
        {
            Brand = "Unknow";
        }
        public Car(string _Model, string _Brand,string _Color, int _CurrentSpeed = 0)
        {
            Brand = _Brand;
            Model = _Model;
            Color = _Color;
            CurrentSpeed = _CurrentSpeed;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", Color, Brand, Model);
        }
    }
}

