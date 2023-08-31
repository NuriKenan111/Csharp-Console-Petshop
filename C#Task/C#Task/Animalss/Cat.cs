﻿namespace Animals;

public class Cat : Animal
{
    public Cat(string name,int age,string gender): base(name,age,gender){}
    public Cat(string name,int age,string gender,int price,int energy,string  mealQuantity)
    :base(name,age,gender,price,energy,mealQuantity){}
    public Cat():base(){}

    public override void Play(int min)
    {
        base.Play(min);
    }

    public override void Print()
    {
        base.Print();
    }

    public override void Sleep(int min)
    {
        base.Sleep(min);
    }

    public override void Eat(int enr)
    {
        base.Eat(enr);
    }

}