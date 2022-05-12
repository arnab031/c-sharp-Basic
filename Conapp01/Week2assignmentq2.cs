using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogicLayer;
using DataAccessLayer;

namespace Conapp01
{
    enum VehicleType
    {
        TwoWheeler, FourWheeler, HeavyVehicle
    }
    class ParkingArea
    {
        private VehicleType type;
        private int count, price;
        int amount;
        public ParkingArea(VehicleType type, int count)
        {
            this.type = type; this.count = count;
        }
        public void GetDetails()
        {
            if (type == VehicleType.TwoWheeler)
                price = 20;
            else if (type == VehicleType.FourWheeler)
                price = 40;
            else if (type == VehicleType.HeavyVehicle)
                price = 100;
            amount = price * count;
            Console.WriteLine($"Vehicle Type: {type}, Count of vehicles: {count}");
            Console.WriteLine($"Price of each vehicle: {price}, Amount: {amount}");
        }
        public void BigCount (ParkingArea v)
        {
            if(this.count>v.count)
                Console.WriteLine($"{type} vehicle count is hig");
            else if(this.count<v.count)
            {
                Console.WriteLine($"{v.type} vehicle count is high");
            }
            else
                Console.WriteLine("Both counts are same");
        }
        public void BigAmount(ParkingArea v)
        {
            if (this.count > v.count)
                Console.WriteLine($"{type} vehicle amount is hig");
            else if (this.count < v.count)
            {
                Console.WriteLine($"{v.type} vehicle amount is high");
            }
            else
                Console.WriteLine("Both amounts are same");
        }
    }
    class Week2assignmentq2
    {
        static void Main(string[] args)
        {
            ParkingArea tw = new ParkingArea(VehicleType.TwoWheeler, 25);
            ParkingArea fw = new ParkingArea(VehicleType.FourWheeler, 10);
            ParkingArea hw = new ParkingArea(VehicleType.HeavyVehicle, 8);
            tw.GetDetails();
            fw.GetDetails();
            hw.GetDetails();
            tw.BigAmount(fw);
            fw.BigCount(tw);
        }
    }

}
