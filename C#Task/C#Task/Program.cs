using Animals;

class Program{
    static void Main(){
        Animal cat1 = new Cat("Rex",2,"Male",150,50,"High");
        Animal cat2 = new Cat("Vandam",3,"Male",200,99,"Medium");
        Animal cat3 = new Cat("Johny",1,"Male",150,50,"Normal");
        Animal dog1 = new Dog("Bella",1,"Female",130,70,"High");
        Animal dog2 = new Dog("Max",4,"Male",200,90,"Medium");
        Animal bird1 = new Bird("Lucy",1,"Male",20,20,"Normal");
        Animal fish1 = new Fish("Ton",4,"Female",200,90,"Medium");

        PetShop petshop = new PetShop(10);

        petshop.AddAnimal(cat1);
        petshop.AddAnimal(cat2);
        petshop.AddAnimal(cat3);
        petshop.AddAnimal(dog1);
        petshop.AddAnimal(dog2);
        petshop.AddAnimal(bird1);
        petshop.AddAnimal(fish1);

        int cash = 300;
        string[] menuItems = { "Animal Shop ", "Animal Sell", "Animal Eat", "Animal Play","Animal Sleeping","Your Animals"};
        int selectedItemIndex = 0;

        while (true)
        {
            Console.Clear();

            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == selectedItemIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-> " + menuItems[i]);
                    Console.ResetColor();
                }
                else Console.WriteLine(menuItems[i]);
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                selectedItemIndex = (selectedItemIndex + 1) % menuItems.Length; 
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                selectedItemIndex = (selectedItemIndex - 1 + menuItems.Length) % menuItems.Length;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                
                if(selectedItemIndex == 0){
                
                    petshop.PrintAnimals();
                    Console.Write("Write the name of the animal you are going to buy: ");
                    string inputName=Console.ReadLine();
                    petshop.BuyAnimal(inputName,ref cash);
                    Console.ReadLine();
                }
                else if(selectedItemIndex == 1){
                    petshop.PrintPurchasedAnim();
                    Console.Write("write the number of the animal you will sell: ");
                    int inputnum = int.Parse(Console.ReadLine());
                    petshop.SellAnimal(inputnum,ref cash);
                    Console.ReadLine();
                }
                else if(selectedItemIndex == 2){
                    petshop.PrintPurchasedAnim();
                    Console.Write("Write the number of the animal you will feed(1,2 vs.): ");
                    int inputNameFeed = int.Parse(Console.ReadLine());
                    Console.Write("include how much you will feed the animal(40,80,100): ");
                    int muchfeed = int.Parse(Console.ReadLine());
                    petshop.purchasedAnim[inputNameFeed - 1].Eat(muchfeed);
                    Console.WriteLine($"{petshop.purchasedAnim[inputNameFeed - 1].Name} animal fed");
                    Console.ReadLine();
                }
                else if(selectedItemIndex == 3){
                    petshop.PrintPurchasedAnim();
                    Console.Write("Write the number of the animal you will play(1,2 vs.): ");
                    int inputNamePlay = int.Parse(Console.ReadLine());
                    Console.Write("include the minute you will play with the animal(15,30,60): ");
                    int muchplay= int.Parse(Console.ReadLine());
                    petshop.purchasedAnim[inputNamePlay - 1].Play(muchplay);
                    Console.WriteLine($"{petshop.purchasedAnim[inputNamePlay - 1].Name} animal Playing");
                    Console.ReadLine();
                }
                else if(selectedItemIndex == 4){
                    petshop.PrintPurchasedAnim();
                    Console.Write("Include the number of your pet's bedding(1,2 vs.): ");
                    int inputNamePlay = int.Parse(Console.ReadLine());
                    Console.Write("include the minute you will play with the animal(15,30,70): ");
                    int muchplay= int.Parse(Console.ReadLine());
                    petshop.purchasedAnim[inputNamePlay - 1].Sleep(muchplay);
                    Console.WriteLine($"{petshop.purchasedAnim[inputNamePlay - 1].Name} animal sleeping");
                    Console.ReadLine();
                }
                else if(selectedItemIndex == 5){
                    petshop.PrintPurchasedAnim();
                    Console.Write("Press the key to return to the menu...");
                    Console.ReadLine();
                }
                continue;
            }
        }
    }
}