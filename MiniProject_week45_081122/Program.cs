
//initilize variables here

using Microsoft.VisualBasic;
using MiniProject_week45_081122;
using System.Runtime.Serialization;

//Console.WriteLine("Current window width: {0}", Console.WindowWidth);

Console.WindowWidth = 150;

List<ElectronicsClass> ElectronicsArray = new List<ElectronicsClass>();


MobileClass nokia = new MobileClass("Moblie","Nokia","X30", 550, new DateTime(2022,05,01),"Sweden");
MobileClass samsung = new MobileClass("Moblie", "Samsung", "Galaxy S22", 650, new DateTime(2020, 02, 15),"Spain");
MobileClass iphone = new MobileClass("Moblie", "Nokia", "3", 1550, new DateTime(2019, 12, 23),"USA");
LaptopClass asus = new LaptopClass("Laptop", "Windows", "Asus", 750, new DateTime(2019,11,13),"Sweden");
LaptopClass macbook = new LaptopClass("Laptop", "macOS", "McBook 13", 1750, new DateTime(2022, 03, 05), "Spain");
LaptopClass lenovo = new LaptopClass("Laptop", "Windows", "Lenovo", 350, new DateTime(2021, 07, 26),"USA");


ElectronicsArray.Add(nokia);
ElectronicsArray.Add(samsung);
ElectronicsArray.Add(iphone);
ElectronicsArray.Add(asus);
ElectronicsArray.Add(macbook);
ElectronicsArray.Add(lenovo);


//-----------------------------------------

bool isRunning = true;


while (isRunning)
{

    Console.WriteLine("press 1 to view all the assets\n" + "press 2 to create new asset\n" +
        "press 3 to quit");
    string choice = Console.ReadLine();

    switch (choice)
    {
                  
        case "1":

            string type = "Type";
            string brand = "Brand";
            string model = "Model";
            string office = "Office";
            string purchaseDate = "Purchase Date";
            string priceUSD = "Price in USD";
            string currency = "Currency";
            string localPrice = "Local price today";

            int spacing = 15;

            Console.WriteLine("");

            Console.WriteLine(type.PadRight(spacing) + brand.PadRight(spacing) + model.PadRight(spacing) + office.PadRight(spacing) + purchaseDate.PadRight(spacing)
                + priceUSD.PadRight(spacing) + currency.PadRight(spacing) + localPrice.PadRight(spacing) + "\n" +
                type.Replace(type,"----").PadRight(spacing) + brand.Replace(brand, "-----").PadRight(spacing) + model.Replace(model, "-----").PadRight(spacing) + 
                office.Replace(office, "------").PadRight(spacing) + purchaseDate.Replace(purchaseDate, "-------------").PadRight(spacing) + 
                priceUSD.Replace(priceUSD, "------------").PadRight(spacing) + currency.Replace(currency, "--------").PadRight(spacing) + 
                localPrice.Replace(localPrice, "-----------------").PadRight(spacing));



            List<ElectronicsClass> sortedElectronics = ElectronicsArray.OrderBy(asset => asset.PurchaseDate).ToList();
            List<ElectronicsClass> sortedElectronics2 = sortedElectronics.OrderBy(asset => asset.Office).ToList();
            //sortedElectronics.OrderBy(asset => asset.PurchaseDate).ToList();


            DateTime dt = DateTime.Now;
            

            foreach(ElectronicsClass e in sortedElectronics2)
            {

                TimeSpan diff = dt - e.PurchaseDate;
                //Console.WriteLine(diff);

                
                if(diff.Days > 1004)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                } 
                else if (diff.Days > 913)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                } 
                e.Show();

                Console.ResetColor();

            }
            

            break;

        case "2":

            Console.WriteLine("What typ of asset do you want to create?\n" +
                "(1) for Laptop\n" +
                "(2) for Mobile");

            createAsset(Console.ReadLine());

            break;
        
        case "3":

            isRunning = false;
            Console.WriteLine("quiting");

            break;

            
        default:

            Console.WriteLine("Please input the numbers displayed");

            break;
    }

}


void createAsset(string type)
{
    switch (type)
    {
        case"1":

            try
            {
                Console.Write("Assets Operating system: ");
                string assetOS = Console.ReadLine().Trim();

                Console.Write("Assets name: ");
                string assetName = Console.ReadLine().Trim();

                Console.Write("Assets Price in USD: ");
                double assetPrice = Double.Parse(Console.ReadLine());
                
                Console.Write("What office is this from: ");
                string assetOffice = Console.ReadLine().Trim();
                
                Console.Write("Assets purchase date (write like this -> dd/MM/yyyy): ");
                string input = Console.ReadLine();
                DateTime assetDate = Convert.ToDateTime(input);

               
                string assetType = "Laptop";

                LaptopClass laptop = new LaptopClass(assetType, assetOS, assetName, assetPrice, assetDate, assetOffice);

                ElectronicsArray.Add(laptop);




            }
            catch (System.Exception e)
            {
                Console.WriteLine("Check you have the right inputs, You can only use numbers for price and date is entered like 'dd/MM/yyyy'");
                Console.WriteLine(e);
            }
                break;

        case "2":

            try
            {
                Console.Write("Assets brand: ");
                string assetBrand = Console.ReadLine().Trim();

                Console.Write("Assets name: ");
                string assetName = Console.ReadLine().Trim();

                Console.Write("Assets Price in USD: ");
                double assetPrice = Double.Parse(Console.ReadLine());
 
                Console.Write("What office is this from: ");
                string assetOffice = Console.ReadLine().Trim();
                
                Console.Write("Assets purchase date (write like this -> dd/MM/yyyy): ");
                string input = Console.ReadLine();
                DateTime assetDate = Convert.ToDateTime(input);
             

                string assetType = "Phone";

                MobileClass mobile = new MobileClass(assetType, assetBrand, assetName, assetPrice, assetDate, assetOffice);

                ElectronicsArray.Add(mobile);

            }
            catch (System.Exception e)
            {
                Console.WriteLine("Check you have the right inputs, You can only use numbers for price and date is entered like 'dd/MM/yyyy'");
                Console.WriteLine(e);

            }

            break;

        default:

            Console.WriteLine("Can only use the choice of 1 or 2");

            break;
    }
}




