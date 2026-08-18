namespace Assignment04OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Q1  Abstraction
            //a)  What is Abstraction in Object-Oriented Programming?
            /*
               Abstraction is the process of hiding the implementation details and showing only the important features for users
             */

            //b)  Why is abstraction considered one of the four pillars of OOP?

            /*
             because it makes program reduces complexity of program , make it easier and faster to maintain besides it works on the whole program (methods , classes , props)
             */
            #endregion

            #region Q2  Abstract Classes vs. Interfaces

            //a)  What is the difference between an Abstract Class and an Interface?

            /*
             - Abstract Class use keyword : abstract , Interface use keyword : Interface
             - Abstract Class can have signitures and fully implemented methods ,Interface can have both too (after C#8)
             - Abstract Class can have fields , Interface Can't have Fields (except Consts (const int x= 10;))
             - Abstract Class can use any Access Modifier (Default Access Modifier inside is Private) , Interface can only use (public , private , internal , protected) Default Access Modifier for members inside Interface is Public
             - Abstract Class's Default Access Modifier is Internal , Interface's Default Access Modifier is Internal
             - Abstract Class Can have (Fields , CTORs , Methods (Concrete or Abstract), Props) , Interfaces can only hve (Methods, Props , Indexers, Events)
             - A Class can inherit one Abstract Class, A Class can Implement more than one Interface
             */

            //b)  When would you choose an Interface instead of an Abstract Class?

            /*
             you Can use Interface over Abstract Class When u have unrelated Classes (NO Inheritance) to make A Contract Between Them 
             */

            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

            /*
             A Class Can't Inherit from Multible Classes (Multible Inheritance => Wrong) , A class can Implement Multible Interfaces => True
             */

            #endregion

            #endregion

            #region Part 02 — Practical

            DeliveryCenter center = new DeliveryCenter();

            StandardShipment standard = new StandardShipment("SH001", "Laptop", 3, 80, new DeliveryAddress("Cairo", "Tahrir", 10));

            ExpressShipment express = new ExpressShipment("SH002","Phone",2,60,new DeliveryAddress("Cairo", "Nasr St", 1),30);

            InternationalShipment international = new InternationalShipment("SH003", "Television", 8, 120, new DeliveryAddress("Cairo", "Nile St", 18), "Germany", 100);

            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");

            center.PrintAllShipments();

            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine("==========================================");

            center.PrintTrackingStatuses();


            Console.WriteLine("==========================================");
            Console.WriteLine("Insurance");
            Console.WriteLine("==========================================");

            DeliveryReport D1= new DeliveryReport();
            D1.PrintInsurance(standard);
            D1.PrintInsurance(express);
            D1.PrintInsurance(international);


            Console.WriteLine("===============================");

            ITrackable[] trackableShipments ={standard,express,international};

            foreach (ITrackable shipment in trackableShipments)
            {
                Console.WriteLine(shipment.GetTrackingStatus());
            }

            Console.WriteLine("=================================");

            IInsurable[] insurableShipments ={standard,express,international};


            foreach (IInsurable shipment in insurableShipments)
            {
                Console.WriteLine(
                    $"Insurance : {shipment.CalculateInsurance()} EGP"
                );
            }


            Console.WriteLine("==========================================");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");


            #endregion
        }
    }
}
