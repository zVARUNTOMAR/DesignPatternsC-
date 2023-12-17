namespace BuilderDesignPattern;

public class Program
{
    static void Main(string[] args)
    {
        // CellPhone phone = new CellPhone("Android", "Qualcomm", 5.6, 3500, 15);
        // string output = phone.ToString();
        // Console.WriteLine(output);

        Shop shop = new Shop();

        CellPhone cellPhone = shop.ConstructSamsungPhone();
        CellPhone applePhone = shop.ConstructApplePhone();

        Console.WriteLine($"{cellPhone}");
        Console.WriteLine($"{applePhone}");

    }
}

//Director Class
public class Shop
{
    public CellPhone ConstructSamsungPhone()
    {
        ICellPhoneBuilder b = new SamsungPhoneBuilder();
        return b.SetBattery(5000).GetPhone();
    }

    public CellPhone ConstructApplePhone()
    {
        ICellPhoneBuilder b = new IPhoneBulilder();
        return b.SetBattery(5000).GetPhone();
    }
}