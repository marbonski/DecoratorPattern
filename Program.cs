// See https://aka.ms/new-console-template for more information

// Create ConcreteComponent
Espresso espresso = new Espresso();
Console.WriteLine("Espresso cost: " + espresso.Cost());

// Create Decorator
CarmelDecorator carmelDecorator = new CarmelDecorator(espresso);
Console.WriteLine("Espresso cost: " + carmelDecorator.Cost());

// Wait for user
Console.ReadKey();

// The 'Component' abstract class
abstract class Beverage
{
    public abstract int Cost();
}

// the 'Decorator' abstract class
abstract class AddonDecorator : Beverage
{
    public abstract override int Cost();
}

// The 'ConcreteComponent' class
class Espresso : Beverage
{
    public override int Cost()
    {
        return 1;
    }
}

// The 'ConcreteDecorator' class
class CarmelDecorator : AddonDecorator
{
    Beverage beverage;
    public CarmelDecorator(Beverage b)
    {
        this.beverage = b;
    }
    public override int Cost()
    {
        return this.beverage.Cost() + 2;
    }
}


