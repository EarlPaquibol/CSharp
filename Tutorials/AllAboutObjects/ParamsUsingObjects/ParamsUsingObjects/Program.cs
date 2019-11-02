using static System.Console;
class ShirtDemo
{
    static void Main()
    {
        Shirt shirt1, shirt2, shirt3;
        shirt1 = new Shirt();
        shirt2 = new Shirt();
        shirt3 = new Shirt();
        shirt1.Material = "cotton";
        shirt1.Color = "white";
        shirt1.Size = "L";
        shirt2.Material = "cotton";
        shirt2.Color = "blue";
        shirt2.Size = "XL";
        shirt3.Material = "polyester";
        shirt3.Color = "pink";
        shirt3.Size = "M";
        Display(shirt1, shirt2, shirt3);
    }
    public static void Display(params Shirt[] shirts)
    {
        for (int x=0; x<shirts.Length; ++x)
            WriteLine("{0} {1} {2}", shirts[x].Color, shirts[x].Material, shirts[x].Size);
    }
}


class Shirt
{
    private string material;
    private string color;
    private string size;
    

    public string Material
    {
        get
        {
            return material;
        }
        set
        {
            material = value;
        }
    }
    public string Size
    {
        get
        {
            return size;
        }
        set
        {
            size = value;
        }
    }
    public string Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
        }
    }
}
