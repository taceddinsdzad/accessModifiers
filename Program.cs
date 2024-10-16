class Program
{
    static void Main(string[] args)
    {
        Phone phone = new Phone("Honor", "x9b", 690, 615, 12, "12GB");

        Notebook notebook = new Notebook("Asus", "Tufx15", 2100, 2000, 3, "Windows 11", "Intel i5", true);


        phone.Pay(5);
        phone.Call(31);
        phone.Sale(6);
        phone.GetInfo();
        notebook.GetInfo();
    }
}
