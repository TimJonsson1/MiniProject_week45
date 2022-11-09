
//initilize variables here

using MiniProject_week45_081122;

List<ElectronicsClass> ElectronicsArray = new List<ElectronicsClass>();

MobileClass nokia = new MobileClass("Moblie","Nokia","X30", 550, new DateOnly(2022,05,01),"Sweden");
MobileClass samsung = new MobileClass("Moblie", "Samsung", "Galaxy S22", 650, new DateOnly(2021, 03, 15),"Spain");
MobileClass iphone = new MobileClass("Moblie", "Nokia", "3", 1550, new DateOnly(2017, 12, 23),"USA");
LaptopClass asus = new LaptopClass("Laptop", "Windows", "Asus", 750, new DateOnly(2019,11,13),"Sweden");
LaptopClass macbook = new LaptopClass("Laptop", "macOS", "McBook 13", 1750, new DateOnly(2022, 03, 05), "Spain");
LaptopClass lenovo = new LaptopClass("Laptop", "Windows", "Lenovo", 350, new DateOnly(2015, 07, 26),"USA");


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

    Console.WriteLine("Press 1 to make a new asset\n" +
        "press 2 to view all the assets\n" +
        "press 3 to quit");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":

            Console.WriteLine("(1) for laptop\n" +
                "(2) for phone");
            CreateAsset(Console.ReadLine());
            
        
            break;
            
        case "2":

            string type = "Type";
            string brand = "Brand";
            string model = "Model";
            string office = "Office";
            string purchaseDate = "Purchase Date";
            string priceUSD = "Price in USD";
            string currency = "Currency";
            string localPrice = "Local price today";

            int spacing = 12;

            Console.WriteLine(type.PadRight(spacing) + brand.PadRight(spacing) + model.PadRight(spacing) + office.PadRight(spacing) + purchaseDate.PadRight(spacing + 3)
                + priceUSD.PadRight(spacing + 3) + currency.PadRight(spacing) + localPrice.PadRight(spacing) + "\n" +
                type.Replace(type,"----").PadRight(spacing) + brand.Replace(brand, "-----").PadRight(spacing) + model.Replace(model, "-----").PadRight(spacing) + 
                office.Replace(office, "------").PadRight(spacing) + purchaseDate.Replace(purchaseDate, "-------------").PadRight(spacing + 3) + 
                priceUSD.Replace(priceUSD, "------------").PadRight(spacing + 3) + currency.Replace(currency, "--------").PadRight(spacing) + 
                localPrice.Replace(localPrice, "-----------------").PadRight(spacing));


            List<ElectronicsClass> sortedElectronics = ElectronicsArray.OrderBy(asset => asset.Type).ToList();

            foreach(ElectronicsClass e in sortedElectronics)
            {
                              
                e.Show();                

            }
            

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

void CreateAsset(string type)
{
   

    switch (type)
    {
        //if choice is laptop
        case "1":


            try
            {
                Console.Write("Assets Operating system: ");
                string assetOS = Console.ReadLine().Trim();

                Console.Write("Assets name: ");
                string assetName = Console.ReadLine().Trim();

                Console.Write("Assets Price: ");
                double assetPrice = Double.Parse(Console.ReadLine());

                Console.Write("Assets purchase date (write like this -> dd/MM/yyyy): ");
                string input = Console.ReadLine();
                DateTime Date = Convert.ToDateTime(input);
                DateOnly assetDate = DateOnly.FromDateTime(Date);

                Console.Write("What office is this from: ");
                string assetOffice = Console.ReadLine().Trim();

                string assetType = "Laptop";

                LaptopClass laptop = new LaptopClass(assetType, assetOS, assetName, assetPrice, assetDate, assetOffice);

                

                
            } 
            catch (System.Exception e)
            {
                Console.WriteLine("Check you have the right inputs, You can only use numbers for price and date is entered like 'dd/MM/yyyy'");
                Console.WriteLine(e);

            }
            
            

            break;


        //if choice is phone
        case "2":


            try
            {
                Console.Write("Assets brand: ");
                string assetBrand = Console.ReadLine().Trim();

                Console.Write("Assets name: ");
                string assetName = Console.ReadLine().Trim();

                Console.Write("Assets Price: ");
                double assetPrice = Double.Parse(Console.ReadLine());

                Console.Write("Assets purchase date (write like this -> dd/MM/yyyy): ");
                string input = Console.ReadLine();
                DateTime Date = Convert.ToDateTime(input);
                DateOnly assetDate = DateOnly.FromDateTime(Date);

                Console.Write("What office is this from: ");
                string assetOffice = Console.ReadLine().Trim();
                
                string assetType = "Phone";
                
                MobileClass mobile = new MobileClass(assetType, assetBrand, assetName, assetPrice, assetDate, assetOffice);


                
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Check you have the right inputs, You can only use numbers for price and date is entered like 'dd/MM/yyyy'");
                Console.WriteLine(e);

            }


            break;

            
        default :

            Console.WriteLine("You can only use 1 or 2 for you choices");

            break;
    }

}



