using System;
using System.Reflection;

namespace Animals;
public abstract class Animal 
{
    private string name;
    public string Name { 
        get => name; 
        set { if(value.Length >=  3) name = value;}
        
    }

    private string gender;
    public string Gender { 
        get => gender; 
        set { if(value == "Male" || value == "Female") gender = value;}
        
    }

    private int age;
    public int Age { get => age; set => age = value; }

    private int price;
    public int Price { get => price; set=> price = value; }

    private int energy;
    public int Energy
    {
        get => energy;
        set { if(value <= 100) energy = value;}
    }

    private string mealQuantity;
    public string MealQuantity
    {
        get => mealQuantity;
        set  { if(value == "Normal" || value == "Medium" || value == "High") mealQuantity = value; }
    }
    
    public virtual void Eat(int enr)
    {
        switch(enr){
            case 40 when energy <= 100:
                energy += 20;
                price += 10;
                break;
            case 80 when energy <= 100:
                energy += 40;
                price += 15;
                break;
            case 100 when energy <= 100:
                energy+= 50;
                price += 20;
                break;
        }
    }

    public virtual void Play(int min){
        switch(min){
            case 15 when energy > 0:
                energy -= 15;
                break;
            case 30 when energy > 0:
                energy -= 30;
                break;
            case 60 when energy > 0:
                energy -= 60;
                break;
        }
    }

    public virtual void Sleep(int min){
        switch(min){
            case 15 when energy < 100:
                energy += 15;
                break;
            case 30 when energy < 100:
                energy += 30;
                break;
            case 70 when energy > 100:
                energy += 70;
                break;
        }
    }

    public virtual void Print(){
        Console.WriteLine();
        Console.WriteLine("<-------------------------------------->");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Energy: " + energy);
        Console.WriteLine("MealQuality: " + mealQuantity
        );
    }
    public Animal(string name,int age,string gender,int price,int energy,string  mealQuantity)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.price = price;
        this.energy = energy;
        this.mealQuantity = mealQuantity;
    }
    
    public Animal(string name,int age,string gender)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.price = 50;
        this.energy = 100;
        this.mealQuantity = "Medium";
    }

    public Animal()
    {
        this.name = "Silwer";
        this.age = 1;
        this.gender = "Male";
        this.price = 50;
        this.energy = 100;
        this.mealQuantity = "Medium";
    }

}
 


