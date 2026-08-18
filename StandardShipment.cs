using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04OOP
{
    internal class StandardShipment : Shipment , ITrackable , IInsurable
    {
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight}");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }


        public override string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }

        public override decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05M;
        }

        public StandardShipment(string trackingcode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingcode, description, weight, deliveryFee, destination)
        {

        }
    }
}
