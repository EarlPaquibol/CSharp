using static System.Console;
class PaintintDemo
{
    static void Main()
    {
        Room[] room = new Room[8];
        for (int x = 0; x < room.Length; ++x)
        {
            room[x] = new Room();
        }
        Room room1 = new Room(22, 15, 11);
        WriteLine(room1.Area);
        WriteLine(room1.Gallons);
    }
}

class Room
{
    public int length { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int Area;
    public int Gallons;

    public Room()
    {

    }
    public Room(int length, int width, int height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
        CalcArea();
        CalcGallons();
    }

    private void CalcArea()
    {
        int temp = 2 * (length + width) * height;
        Area = temp; // (length+width);



    }

    private void CalcGallons()
    {
        const int gallon = 350;
        if (Area < 350)
        {
            Gallons = 1;
        }
        else if (Area == 620)
        {
            Gallons = 2;
        }
        else
        {
            Gallons = 3;
        }

    }




}

