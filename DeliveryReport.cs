using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04OOP
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance()}");
        }
    }
}
