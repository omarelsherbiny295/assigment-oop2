namespace smartsystemdelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1 
            //A
            //class is refrence type
            //struct is value type
            //B
            //Classes are more suitable for large applications because they support inheritance polymorphism and code reuse
            #endregion

            #region question2
            //a/ shipmnet is the parent class
            //b/ expessshipmnet is the child 
            //c/ expressShipment inherits the TrackingCode property from the Shipment class
            //d/ inheritance reduces code duplication and makes the code easier to maintain and reuse
            #endregion

            #region Create Delivery Center
            DeliveryCenter center = new DeliveryCenter();
            #endregion

            #region Read Center Name
            Console.Write("Enter Delivery Center Name: ");
            center.CenterName = Console.ReadLine();
            #endregion

            #region Create Standard Shipment
            Console.WriteLine("Enter Standard Shipment");

            Console.Write("Tracking Code: ");
            string trackingCode1 = Console.ReadLine();

            Console.Write("Description: ");
            string description1 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight1 = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee1 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city1 = Console.ReadLine();

            Console.Write("Street: ");
            string street1 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building1 = int.Parse(Console.ReadLine());

            DeliveryAddress address1 =
                new DeliveryAddress(city1, street1, building1);

            StandardShipment standard =
                new StandardShipment(
                    trackingCode1,
                    description1,
                    weight1,
                    fee1,
                    address1
                );
            #endregion

            #region Create Express Shipment
            Console.WriteLine("Enter Express Shipment");

            Console.Write("Tracking Code: ");
            string trackingCode2 = Console.ReadLine();

            Console.Write("Description: ");
            string description2 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight2 = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee2 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city2 = Console.ReadLine();

            Console.Write("Street: ");
            string street2 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building2 = int.Parse(Console.ReadLine());

            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress address2 =
                new DeliveryAddress(city2, street2, building2);

            ExpressShipment express =
                new ExpressShipment(
                    trackingCode2,
                    description2,
                    weight2,
                    fee2,
                    address2,
                    extraFee
                );
            #endregion

            #region Create International Shipment
            Console.WriteLine("Enter International Shipment");

            Console.Write("Tracking Code: ");
            string trackingCode3 = Console.ReadLine();

            Console.Write("Description: ");
            string description3 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight3 = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee3 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city3 = Console.ReadLine();

            Console.Write("Street: ");
            string street3 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building3 = int.Parse(Console.ReadLine());

            Console.Write("Destination Country: ");
            string country = Console.ReadLine();

            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress address3 =
                new DeliveryAddress(city3, street3, building3);

            InternationalShipment international =
                new InternationalShipment(
                    trackingCode3,
                    description3,
                    weight3,
                    fee3,
                    address3,
                    country,
                    customsFee
                );
            #endregion

            #region Read Shipment Data
            Console.WriteLine("Shipment data entered successfully.");
            #endregion

            #region Add Shipments
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);
            #endregion

            #region Print All Shipments
            Console.WriteLine();
            Console.WriteLine("All Shipments:");
            center.PrintAllShipments();
            #endregion

            #region Search Shipment
            Console.WriteLine();
            Console.Write("Enter Tracking Code to Search: ");
            string search = Console.ReadLine();

            Shipment shipment = center[search];

            if (shipment != null)
            {
                shipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment Not Found");
            }
            #endregion

            #region Remove Shipment
            Console.WriteLine();
            Console.Write("Enter Tracking Code to Remove: ");
            string remove = Console.ReadLine();

            if (center.RemoveShipment(remove))
            {
                Console.WriteLine("Shipment Removed");
            }
            else
            {
                Console.WriteLine("Shipment Not Found");
            }
            #endregion

            #region Print Remaining Shipments
            Console.WriteLine();
            Console.WriteLine("Remaining Shipments:");
            center.PrintAllShipments();
            #endregion

            Console.ReadKey();


        }
    }
}
