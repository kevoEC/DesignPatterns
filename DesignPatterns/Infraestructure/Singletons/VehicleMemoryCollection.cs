using DesignPatterns.Models;
using System.Collections.Generic;

namespace DesignPatterns.Infraestructure.Singletons
{
    public class VehicleMemoryCollection
    {
        private static VehicleMemoryCollection _instance;

        public ICollection<Vehicle> Vehicles { get; set; }

        public VehicleMemoryCollection()
        {
            Vehicles = new List<Vehicle>();
        }
        public static VehicleMemoryCollection Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new VehicleMemoryCollection();
                }
                return _instance;
            }
            
        }
    }
}
