using System;
using System.ComponentModel;

namespace CSharpDiscovery.Quest04
{
    public class Car : Vehicule
    {
        public string Model { get; set; } = "";
        
        public override string ToString()
        {
            return $"{Color} {Brand} {Model}";
        }
        public Car() : base()
        {
            Model = "Unknown";
        }
        public Car(string _Model, string Brand, string Color, int CurrentSpeed = 0) : base(Brand, Color, CurrentSpeed)
        {
            Model = _Model;
        }

        public override void Accelerate(int Speed)
        {
            CurrentSpeed = CurrentSpeed + Speed <= 180 ? CurrentSpeed + Speed : 180;
        }
        public override void Brake(int BrakePower)
        {
            CurrentSpeed = CurrentSpeed - BrakePower >= 0 ? CurrentSpeed - BrakePower : 0;
        }
    }
}

