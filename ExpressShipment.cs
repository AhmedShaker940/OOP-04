using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04OOP
{
    internal class ExpressShipment : Shipment , ITrackable,IInsurable
    {
        private decimal extrafee;

        public decimal ExtraFee
        {
            get { return extrafee; }
            set
            {
                if (value >= 0)
                    extrafee = value;
            }
        }

        public ExpressShipment(string trackingcode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extrafee) : base(trackingcode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extrafee;
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight}");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine($"Extra Fee     : {ExtraFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }

        public override string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }

        public override decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}
