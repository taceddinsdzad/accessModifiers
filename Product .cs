public class Product
{
    public string Id;
    public string BrandName;
    public string Model;
    public decimal Price;
    public decimal Cost;
    public int Count;
    public decimal Income;
    public Product(string brandName, string model, decimal price, decimal cost, int count)
    {
        BrandName = brandName;
        Model = model;
        Price = price;
        Cost = cost;
        Count = count;
        if (count < 0)
        {
            Count = 0;
        }
        else
        {
            Count = count;
        }
        Income = 0;
        //məhsulun unikal id sini təyin etmek üçün brandın iki simvolu ile modelin ilk iki simvolunu birleşdirirem:
        Id = BrandName.Substring(0, 2).ToUpper() + Model.Substring(0, 2).ToUpper();
    }

    public void GetInfo()
    {
        Console.WriteLine($"Id: {Id}, Bren: {BrandName}  Model: {Model}  Qiymet: {Price}  Xerc: {Cost}  Say: {Count}  Gelir: {Income}");
    }

    public void Sale(int quantity)
    {
        if (quantity <= Count)
        {
            Count -= quantity;
            Income += (Price - Cost) * quantity;
            Console.WriteLine($"Satısh uqurlu oldu. Gelir: {Income} Qalan say: {Count}");
        }
        else
        {
            Console.WriteLine("mehsul kifayet qeder deyil");
        }
    }
}
