namespace CSharpDiscovery.Quest04
{
    public class Truck : Vehicule
    {
        public int Tonnage { get; set; } = 0;
        
        public Truck() : base()
        {
                Tonnage = 0;
        }
        public Truck(int _Tonnage, string Brand, string Color, int CurrentSpeed = 0) : base(Brand, Color, CurrentSpeed)
        {
            Tonnage = _Tonnage;
        }
        
        public override string ToString()
        {
            return $"{Color} {Brand} {Tonnage}T Truck";
        }
        
        public override void Accelerate(int Speed)
        {
            CurrentSpeed = CurrentSpeed + Speed <= 100 ? CurrentSpeed + Speed : 100;
        }
        
        public override void Brake(int BrakePower)
        {
            CurrentSpeed = CurrentSpeed - BrakePower >= 0 ? CurrentSpeed - BrakePower : 0;
        }
    }
}

