public interface ICellPhoneBuilder
{
    CellPhone GetPhone();
    ICellPhoneBuilder SetBattery(int battery);
    ICellPhoneBuilder SetScreenSize(double screenSize);
    ICellPhoneBuilder SetProcessor(string processor);
    ICellPhoneBuilder SetCamera(int camera);
}