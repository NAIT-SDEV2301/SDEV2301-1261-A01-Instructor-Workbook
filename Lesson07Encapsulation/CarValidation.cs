class Program
{
    static void Main()
    {
        try
        {
            Car currentCar = new Car(150,"Lexus RX350");
            Console.WriteLine($"Speed: {currentCar.Speed}, Model: {currentCar.Model}");
            currentCar.Speed = -50;
            Console.WriteLine($"Speed: {currentCar.Speed}, Model: {currentCar.Model}");            
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }   
}

class Car
{
    private int _speed;

    public string Model { get; }
    public int Speed
    {
        get => _speed;
        set
        {
            if (value < 0 || value > 200)
            {
                throw new ArgumentOutOfRangeException(nameof(value),"Speed must be between 0 and 200.");
            }
            _speed = value;
        }
    }

    public Car(int speed, string model)
    {
        Speed = speed;
        Model = model;
    }
}