using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleWPF.MVVM;

namespace VehicleWPF.ViewModels
{
    public class VehicleViewModel : MVVM.IViewModel
    {
        private VehiclesModel VehiclesModel { get; }
        private Vehicle Vehicle { get; }
        public Action Close { get; set; }

        public string Brand { get; set; }
        public DateTime DateOfProduction { get; set; }
        public ulong MaxSpeed { get; set; }

        public RelayCommand<VehicleViewModel> OkCommand { get; } = new RelayCommand<VehicleViewModel>
            (
                (vehicleViewModel) => { vehicleViewModel.Ok(); }
            );
        public RelayCommand<VehicleViewModel> CancelCommand { get; } = new RelayCommand<VehicleViewModel>
            (
                (vehicleViewModel) => { vehicleViewModel.Cancel(); }
            );

        public VehicleViewModel(VehiclesModel vehiclesModel, Vehicle vehicle)
        {
            VehiclesModel = vehiclesModel;
            Vehicle = vehicle;
            if (Vehicle != null)
            {
                Brand = Vehicle.Brand;
                DateOfProduction = Vehicle.DateOfProduction;
                MaxSpeed = Vehicle.MaxSpeed;
            }
        }

        public void Ok()
        {
            if (Vehicle == null)
            {
                Vehicle vehicle = new Vehicle(Brand, DateOfProduction, MaxSpeed);
                VehiclesModel.Vehicles.Add(vehicle);
            }
            else
            {
                Vehicle.Brand = Brand;
                Vehicle.DateOfProduction = DateOfProduction;
                Vehicle.MaxSpeed = MaxSpeed;
            }
            Close?.Invoke();
        }
        public void Cancel() => Close?.Invoke();
    }
}
