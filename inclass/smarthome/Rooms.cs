public class Rooms{

    List<Device>_devices = new List<Device>();
    string _name;

    public Rooms(string name){
        _name = name;
    }

    public void AddDevice(Device device)
    {
        _devices.Add(device);
    }

    



}