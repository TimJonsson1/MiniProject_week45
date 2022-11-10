using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_week45_081122
{
    internal class LaptopClass : ElectronicsClass
    {
        public LaptopClass(string type, string operatingSystem, string modelName, double price, DateTime purchaseDate, string office) : base(type, modelName, price, purchaseDate, office)
        {
            this.OperatingSystem = operatingSystem; 
        }

        public string OperatingSystem { get; set; }

        int spacing = 15;
        public override void Show()
        {

            Console.WriteLine(Type.PadRight(spacing) + "" + OperatingSystem.PadRight(spacing) + "" + ModelName.PadRight(spacing) + Office.PadRight(spacing) +
                "" + PurchaseDate.ToString("dd-MM-yyyy").PadRight(spacing) + "" + Price.ToString().PadRight(spacing) + "" + Currency.PadRight(spacing) + "\n");
        }
    }
}
