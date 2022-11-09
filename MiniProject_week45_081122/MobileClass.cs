using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_week45_081122
{
    internal class MobileClass : ElectronicsClass
    {

        public MobileClass(string type, string brand, string modelName, double price, DateOnly purchaseDate, string office) : base(type, modelName, price, purchaseDate, office)
        {
            this.Brand = brand;
        }

        public string Brand { get; set; }

        public override void Show()
        {
            Console.WriteLine(Type + " " +Brand + " " + ModelName + " " + Price + " " + PurchaseDate.ToString("dd-MM-yyyy") + "\n");
        }
    }
}
