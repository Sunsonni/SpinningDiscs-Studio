namespace SpinningDiscs;

public abstract class BaseDisc
{
    public string Name { get; set; }
    public int Capacity { get; set; }
    public string DiscType { get; set; }
    public BaseDisc(string name, int capacity, string discType)
    {
        Name = name;
        Capacity = capacity;
        DiscType = discType;
    }

   
}