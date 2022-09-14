namespace CSharpDiscovery.Quest03
{
public class PointOfInterest
{
    public static string GoogleMapsUrlTemplate { get; set; } = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";
    public double Latitude { get; set; } = 0.0;
    public double Longitude { get; set; } = 0.0;
    public string Name { get; set; } = "";
    public PointOfInterest() {
        Name = "Bordeaux Ynov Campus";
        Latitude = 44.854186;
        Longitude = -0.5663056;
    }
    public PointOfInterest(string _name, double _latitude, double _longitude) {
        Name = _name;
        Latitude = _latitude;
        Longitude = _longitude;
    }
}

}