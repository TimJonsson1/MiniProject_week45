using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_week45_081122
{
    internal class LaptopClass : ElectronicsClass
    {
        public LaptopClass(string type, string operatingSystem, string modelName, double price, DateOnly purchaseDate, string office) : base(type, modelName, price, purchaseDate, office)
        {
            this.OperatingSystem = operatingSystem; 
        }

        public string OperatingSystem { get; set; }


        public override void Show()
        {
            Console.WriteLine(Type + " " + OperatingSystem + " " + ModelName + " " + Price + " " + PurchaseDate.ToString("dd-MM-yyyy") + "\n");
        }
    }
}
