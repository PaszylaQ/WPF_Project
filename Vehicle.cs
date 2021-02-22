using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleWPF
{
    public class Vehicle : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Brand")); }
        }

        private DateTime dateOfProduction;
        public DateTime DateOfProduction
        {
            get { return dateOfProduction; }
            set { dateOfProduction = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateOfProduction")); }
        }

        private ulong maxSpeed;
        public ulong MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MaxSpeed")); }
        }

        public Vehicle(string brand, DateTime dateOfProduction, ulong maxSpeed)
        {
            Brand = brand;
            DateOfProduction = dateOfProduction;
            MaxSpeed = maxSpeed;
        }
    }
}