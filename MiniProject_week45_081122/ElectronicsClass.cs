using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_week45_081122
{
    internal class ElectronicsClass
    {
        public ElectronicsClass(string type, string modelName, double price, DateTime purchaseDate, string office)
        {
            Type = type;
            ModelName = modelName;
            Price = price;
            PurchaseDate = purchaseDate;
            Office = office;

            if (office.Equals("Sweden"))
            {
                Currency = "SEK";
            } 
            else if (office.Equals("USA"))
            {
                Currency = "USD";
            }
            else if (office.Equals("Spain"))
            {
                Currency = "EUR";
            }
        }

        public string Office { get; set; }

        public string Type { get; set; }

        public string ModelName { get; set; }

        public double Price { get; set; }

        public DateTime PurchaseDate { get; set; }

        public string Currency { get; set; }

        public virtual void Show()
        {
            
        }

       

    }
}
