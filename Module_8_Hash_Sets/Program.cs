using System;
using System.Collections.Generic;

namespace Module_8_Hash_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            DMV myDMV = new DMV();
            Vehicle myVehicle = new Vehicle();
            myVehicle.LicensePlate = "1ABC23";
            myVehicle.VehicleType = "2017 Chevrolet Volt";
            myDMV.AddVehicle(myVehicle);
            Vehicle myVehicle2 = new Vehicle();
            myVehicle2.LicensePlate = "2DEF34";
            myVehicle2.VehicleType = "2015 Hyundai Elantra";
            myDMV.AddVehicle(myVehicle2);
            Vehicle myVehicle3 = new Vehicle();
            myVehicle3.LicensePlate = "3GHI45";
            myVehicle3.VehicleType = "1995 Ford Ranger";
            myDMV.AddVehicle(myVehicle3);
        }
    }
}
public class DMV
{
    public HashSet<Vehicle> mySet = new HashSet<Vehicle>();
    public void AddVehicle(Vehicle vehicle)
    {
        bool LicensePlateAlreadyExists = mySet.Add(vehicle);
        if (!LicensePlateAlreadyExists)
        {
            Console.WriteLine("License plate number " + vehicle + "already exists.");
        }
        else
        {
            Console.WriteLine("License plate was added into the system.");
        }
    }

}
public class Vehicle
{
    public string LicensePlate { get; set; }
    public string VehicleType { get; set; }
    public override bool Equals(object obj)
    {
        Vehicle CompareLicensePlate = obj as Vehicle;
        return this.LicensePlate.Equals(CompareLicensePlate.LicensePlate);
    }
    public override int GetHashCode()
    {
        return this.LicensePlate.GetHashCode();
    }
}
