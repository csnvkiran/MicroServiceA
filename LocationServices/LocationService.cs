using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceA.LocationServices
{
    public class LocationService
    {

        public LocationService(double latitude, double longitude, int pid)
        {

            PersonID = pid;
            PersonName = "Kiran Chalancharls";
            Latitude = latitude;
            Longitude = longitude;
        }

        public int PersonID { get; }
        public string PersonName { get; }
        public double Latitude { get; }
        public double Longitude { get; }

    }
 
}
