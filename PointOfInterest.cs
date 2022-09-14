using System;

namespace CSharpDiscovery.Quest03
{
public class PointOfInterest
{
    public static string GoogleMapsUrlTemplate { get; set; } = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";
    public double Latitude { get; set; } = 0.0;
    public double Longitude { get; set; } = 0.0;
    public string Name { get; set; } = "";

    public string GetGoogleMapsUrl()
    {
        return String.Format(GoogleMapsUrlTemplate, Name.Replace(" ", "+"), Latitude, Longitude);
    }
    
    public override string ToString()
    {
        return String.Format("{0} (Lat={1}, Long={2})", Name, Latitude, Longitude);
    }
    
    public int GetDistance(PointOfInterest other) {
        return (int) calculate(this, other);
    }
    public static int GetDistance(PointOfInterest p1, PointOfInterest p2) {
        return (int) calculate(p1, p2);
    }
    
    private static double calculate(PointOfInterest p1, PointOfInterest p2) {
        int earthRadiusKm = 6371;
        double dLat = (p2.Latitude - p1.Latitude)* Math.PI / 180;
        double dLon = (p2.Longitude - p1.Longitude)* Math.PI / 180;

        double lat1 = p1.Latitude * Math.PI / 180;
        double lat2 = p2.Latitude * Math.PI / 180;

        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        return Math.Round(earthRadiusKm * c);
    }
    
    
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