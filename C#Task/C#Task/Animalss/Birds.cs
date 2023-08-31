namespace Animals;

public class Bird : Animal
{
    public Bird(string name,int age,string gender): base(name,age,gender){}
    public Bird(string name,int age,string gender,int price,int energy,string  mealQuantity)
    :base(name,age,gender,price,energy,mealQuantity){}
    public Bird():base(){}

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
