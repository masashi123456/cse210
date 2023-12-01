public abstract class Device{
    protected bool _power = false;
    string _name;
    protected long _powerOnTime = 0;
    
    protected DateTime _dateTime;

    public Device(string name){
        _name = name;
    }

    public void TogglePower(){
            _power = true;
            _dateTime = DateTime.Now;
            long unixTime = ((DateTimeOffset)_dateTime).ToUnixTimeSeconds();
            _powerOnTime = unixTime;
        }
    
    public void PowerOff(){
            _power = false;
            _powerOnTime = 0;
        }
    

    public string GetPower(){
        
        if(_power == true){
            return "The device is on";
        }
        else {
            return "The device is off";
        }
    }

    public double getTime(){
        if(_power)
        {
            DateTime currentTime = DateTime.UtcNow;
            long unixTime = ((DateTimeOffset)currentTime).ToUnixTimeSeconds();
            return unixTime - _powerOnTime;
        }

        else{
            return 0;
        }
    }


    public string Display()
    {
        return $"{_name}: {_power} {getTime()}";
    }



    
}