
//initilize variables here

using Microsoft.VisualBasic;
using MiniProject_week45_081122;
using System.Runtime.Serialization;

//Console.WriteLine("Current window width: {0}", Console.WindowWidth);

Console.WindowWidth = 150;

List<ElectronicsClass> ElectronicsArray = new List<ElectronicsClass>();


MobileClass nokia = new MobileClass("Moblie","Nokia","X30", 550, new DateTime(2022,05,01),"Sweden");
MobileClass samsung = new MobileClass("Moblie", "Samsung", "Galaxy S22", 650, new DateTime(2021, 03, 15),"Spain");
MobileClass iphone = new MobileClass("Moblie", "Nokia", "3", 1550, new DateTime(2019, 12, 23),"USA");
LaptopClass asus = new LaptopClass("Laptop", "Windows", "Asus", 750, new DateTime(2019,11,13),"Sweden");
LaptopClass macbook = new LaptopClass("Laptop", "macOS", "McBook 13", 1750, new DateTime(2022, 03, 05), "Spain");
LaptopClass lenovo = new LaptopClass("Laptop", "Windows", "Lenovo", 350, new DateTime(2017, 07, 26),"USA");


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

    Console.WriteLine("press 1 to view all the assets\n" +
        "press 2 to quit");
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
            sortedElectronics = ElectronicsArray.OrderBy(asset => asset.Office).ToList();
            //sortedElectronics.OrderBy(asset => asset.PurchaseDate).ToList();


            DateTime dt = DateTime.Now;
            

            foreach(ElectronicsClass e in sortedElectronics)
            {

                TimeSpan diff = dt - e.PurchaseDate;
                //Console.WriteLine(diff);

                
                if(diff.Days > 1004)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                e.Show();

                Console.ResetColor();

            }
            

            break;
        
        case "2":

            isRunning = false;
            Console.WriteLine("quiting");

            break;

            
        default:

            Console.WriteLine("Please input the numbers displayed");

            break;
    }

}







