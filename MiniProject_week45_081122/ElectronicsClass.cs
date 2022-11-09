using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_week45_081122
{
    internal class ElectronicsClass
    {
        public ElectronicsClass(string type, string modelName, double price, DateOnly purchaseDate, string office)
        {
            Type = type;
            ModelName = modelName;
            Price = price;
            PurchaseDate = purchaseDate;
            Office = office;
        }

        public string Office { get; set; }

        public string Type { get; set; }

        public string ModelName { get; set; }
        public double Price { get; set; }

        public DateOnly PurchaseDate { get; set; }

        public virtual void Show()
        {
            
        }

       

    }
}
