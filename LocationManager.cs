using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LocationManager
{
    private List<Location> _locations;

    public LocationManager()
    {
        InitializeLocations();
    }

    private void InitializeLocations()
    {
        // Create the locations with their descriptions
        Location station1 = new Location("Station 1", "Description for Station 1.");
        Location station2 = new Location("Station 2", "Description for Station 2.");
        Location station3 = new Location("Station 3", "Description for Station 3.");
        // Add more stations as needed

        _locations = new List<Location> { station1, station2, station3 };

        // Set HasThang and HasCannedTuna properties randomly for each location
        Random random = new Random();
        foreach (var location in _locations)
        {
            location.HasThang = random.Next(0, 100) < 25; // 25% chance to have a Thang
            location.HasCannedTuna = random.Next(0, 100) < 50; // 50% chance to have a Canned Tuna
        }
    }

    public List<Location> GetAllLocations()
    {
        return _locations;
    }

    public Location GetLocationByName(string name)
    {
        return _locations.FirstOrDefault(loc => loc.Name == name);
    }
}