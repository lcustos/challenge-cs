namespace CSharpDiscovery.Quest03
{
    public class HistoricalMonument : PointOfInterest
    {
        
        public int BuildYear { get; set; } = 0;

        public HistoricalMonument() { }

        public HistoricalMonument(string name, double latitude, double longitude, int buildYear) : base(name, latitude,
            longitude)
        {
            BuildYear = buildYear;
        }
        public override string ToString() {
            return $"{Name} is a historical monument built in {BuildYear}";
        }
    }

}

