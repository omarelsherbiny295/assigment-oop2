using System;
using System.Collections.Generic;
using System.Text;

namespace smartsystemdelivery
{
    public class DeliveryCenter
    {
        public string CenterName { get; set; }

        private Shipment[] Shipments = new Shipment[20];

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < Shipments.Length)
                {
                    return Shipments[index];
                }

                return null;
            }

            set
            {
                if (index >= 0 && index < Shipments.Length)
                {
                    Shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < Shipments.Length; i++)
                {
                    if (Shipments[i] != null &&
                        Shipments[i].TrackingCode == trackingCode)
                    {
                        return Shipments[i];
                    }
                }

                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] == null)
                {
                    Shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] != null &&
                    Shipments[i].TrackingCode == trackingCode)
                {
                    Shipments[i] = null;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] != null)
                {
                    Console.WriteLine();
                    Shipments[i].PrintShipment();
                }
            }
        }
    }
}
