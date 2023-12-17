public class IPhoneBulilder : ICellPhoneBuilder
{
    private string Brand = "Apple";
    private string OS = "iOS";
    private string Processor;
    private double ScreenSize;
    private int Battery;
    private int Camera;

    public CellPhone GetPhone()
    {
        //We can put condition here for default values or any conditional values nust set
        return new CellPhone(OS, Processor, ScreenSize, Battery, Camera, Brand);
    }

    public ICellPhoneBuilder SetOS(string os)
    {
        this.OS = os;
        return this;
    }

    public ICellPhoneBuilder SetProcessor(string processor)
    {
        this.Processor = processor;
        return this;
    }

    public ICellPhoneBuilder SetCamera(int camera)
    {
        this.Camera = camera;
        return this;
    }

    public ICellPhoneBuilder SetBattery(int battery)
    {
        this.Battery = battery;
        return this;
    }

    public ICellPhoneBuilder SetScreenSize(double screenSize)
    {
        this.ScreenSize = screenSize;
        return this;
    }
}