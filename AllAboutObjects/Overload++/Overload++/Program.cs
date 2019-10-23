using static System.Console;
class CarDemo
{
    static void Main()
    {
        Car car1 = new Car("Civic", 38.50);
        Car car2 = new Car("Corolla");
        car1++;
        string message = "Hey";
        Display(message, car1);
    }
    public static void Display(string message, Car s)
    {
        WriteLine("{0} has {1:0.00} miles per gallon", s.Model, s.Mpg);
    }

}

class Car
{
    private string model;
    private double mpg;

    public string Model
    {
        get
        {
            return model;
        }
        set
        {
            model = value;
        }
    }

    public double Mpg
    {
        get
        {
            return mpg;
        }
        set
        {
            mpg = value;
        }
    }
    public Car()
    {

    }
    public Car(string car, double miles)
    {
        model = car;
        mpg = miles;
    }

    public Car(string car)
    {
        model = car;
        mpg = 20;
    }

    public static Car operator ++(Car cars)   //to use car++, you need to use "++" not "+".                  
    {

        cars.mpg = cars.mpg + 1;              // dont use cars.mpg++ here because you cant use ++ in objects with no overloaded operator yet
        return (new Car(cars.model, cars.mpg));
    }

}
