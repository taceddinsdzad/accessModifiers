public class Phone : Product
{
    public string RAM { get; private set; }
    public string Color { get; private set; }
    public decimal Balance { get; private set; }
    public Phone(string brandName, string model, decimal price, decimal cost, int count)
        : base(brandName, model, price, cost, count)
    {

        Balance = 0;
    }
    public Phone(string brandName, string model, decimal price, decimal cost, int count, string ram, string color = "Black")
        : base(brandName, model, price, cost, count)
    {
        RAM = ram;
        Color = color;
        Balance = 0;
    }

    public void Call(int seconds)
    {
        decimal costOfCall = seconds * 0.1m;
        if (Balance >= costOfCall)
        {
            Balance -= costOfCall;
            Console.WriteLine($"Zeng edildi, {seconds} saniye. Qalan balans: {Balance}");
        }
        else
        {
            Console.WriteLine("Balansınız kifayet qeder deyil");
        }
    }

    public void Pay(decimal money)
    {
        Balance += money;
        Console.WriteLine($"Balans artırıldı: {Balance}");
    }
}
