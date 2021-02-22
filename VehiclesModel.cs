using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleWPF
{
    public class VehiclesModel
    {
        public ObservableCollection<Vehicle> Vehicles { get; private set; } = new ObservableCollection<Vehicle>();
        public VehiclesModel()
        {
            Vehicles.Add(new Vehicle("Audi", new DateTime(2008, 3, 7), 180));
            Vehicles.Add(new Vehicle("Toyota", new DateTime(2012, 3, 7), 170));
            Vehicles.Add(new Vehicle("Polonez", new DateTime(1997, 3, 7), 100));
        }
    }
}
