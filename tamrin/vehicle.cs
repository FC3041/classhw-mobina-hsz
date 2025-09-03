abstract class Vehicle
{
    public static int Number_of_Vehicles { get; private set; } = 0;
    public abstract double GetFuelEfficienc();
    public Vehicle()
    {
        Number_of_Vehicles++;
    }
}

class Car : Vehicle
{
    public double fuel_consumption;
    public Car(double f)
    {
        fuel_consumption = f;
    }
    public override double GetFuelEfficienc()
    {
        return fuel_consumption;
    }

}

class Bike : Vehicle
{
    public bool hasCarrier = false;
    public Bike(bool h = false)
    {
        hasCarrier = h;
    }
    public override double GetFuelEfficienc()
    {
        return hasCarrier ? 0.5 : 0;
    }

}