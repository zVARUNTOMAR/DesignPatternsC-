public class CellPhone
{
    string Brand;
    string OS;
    string Processor;
    double ScreenSize;
    int Battery;
    int Camera;

    public CellPhone(string OS, string Processor, double ScreenSize, int battery, int Camera, string Brand)
    {
        this.OS = OS;
        this.Processor = Processor;
        this.ScreenSize = ScreenSize;
        this.Battery = battery;
        this.Camera = Camera;
        this.Brand = Brand;
    }

    public override string ToString()
    {
        return $"Brand : {Brand} OS : {OS}, Processor : {Processor}, ScreenSize : {ScreenSize} Battery : {Battery} Camera : {Camera}";
    }
}