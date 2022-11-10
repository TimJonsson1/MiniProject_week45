using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_week45_081122
{
    
    internal class MobileClass : ElectronicsClass
    {

        public MobileClass(string type, string brand, string modelName, double price, DateTime purchaseDate, string office) : base(type, modelName, price, purchaseDate, office)
        {
            this.Brand = brand;
        }

        public string Brand { get; set; }

        int spacing = 15;

        public override void Show()
        {

            

            Console.WriteLine(Type.PadRight(spacing) + "" + Brand.PadRight(spacing) + "" + ModelName.PadRight(spacing) + Office.PadRight(spacing) + 
                ""  + PurchaseDate.ToString("dd-MM-yyyy").PadRight(spacing) + "" + Price.ToString().PadRight(spacing) + "" + Currency.PadRight(spacing) +
                localPrice.ToString().PadRight(spacing) + "\n");
        }
    }
}
