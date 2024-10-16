public class Notebook : Product
{
    public string Processor;
    public string OpSystem;
    public bool HasGraphicCart;

    public Notebook(string brandName, string model, decimal price, decimal cost, int count, string opSystem, string processor)
        : base(brandName, model, price, cost, count)
    {
        Processor = processor;
        OpSystem = opSystem;

    }
    public Notebook(string brandName, string model, decimal price, decimal cost, int count, string opSystem, string processor, bool hasGraphicCart)
       : base(brandName, model, price, cost, count)
    {
        Processor = processor;
        OpSystem = opSystem;
        HasGraphicCart = hasGraphicCart;
    }
}