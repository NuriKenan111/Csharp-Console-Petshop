namespace Animals;

public class PetShop
{
    public Animal[] animals;
    public Animal[] purchasedAnim;
    
    public PetShop(int capacity)
    {
        animals = new Animal[capacity];
    }

    public void BuyAnimal(string animalName,ref int cash)
    {
        for (int i = 0; i < animals.Length; i++)
        {
            if (animals[i] != null && animals[i].Name == animalName)
            {
                
                Console.WriteLine($"{animals[i].Name} has been purchased.");
                Console.WriteLine($"your remaining money is {cash - animals[i].Price}");
                if(purchasedAnim == null){
                    purchasedAnim = new Animal[animals.Length];
                    purchasedAnim[0] = animals[i];
                    animals[i] = null;
                    break;
                } 
                for (int j = 0; j < purchasedAnim.Length; j++)
                {
                    if (purchasedAnim[j] == null)
                    {
                        purchasedAnim[j] = animals[i];
                        break;
                    }
                }
                animals[i] = null;
                break;
            }
        }
        
    }

    public void AddAnimal(Animal animal)
    {
        for (int i = 0; i < animals.Length; i++)
        {
            if (animals[i] == null)
            {
                animals[i] = animal;
                Console.WriteLine($"{animal.Name} has been added to the pet shop.");
                return;
            }
        }

        Console.WriteLine("Pet shop is full, cannot add more animals.");
    }

    public void SellAnimal(int indx,ref int cash){
        Console.Clear();
        if(purchasedAnim != null){
            for (int i = 0; i < purchasedAnim.Length ; i++)
            {
                AddAnimal(purchasedAnim[indx - 1]);
                Console.WriteLine("your animal has been sold");
                Console.WriteLine("Your money: " + (cash += purchasedAnim[indx - 1].Price));
                purchasedAnim[indx - 1] = null;
                return;
            }
        }
        PrintPurchasedAnim();

    }
    public void PrintAnimals()
    {
        Console.Clear();
        Console.WriteLine("Animals in the pet shop:");
        foreach (var animal in animals)
        {
            if (animal != null)
            {
                animal.Print();
                Console.WriteLine();
            }
        }
    }
    public void PrintPurchasedAnim(){
        if(purchasedAnim == null){
            Console.WriteLine("you've never bought an animal");
            return;
        } 
        Console.Clear();
        foreach (var item in purchasedAnim)
        {
            if(item != null){
                item.Print();
            }
            
        }
    
    }
}