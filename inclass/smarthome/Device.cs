public class SmartDevice{
    public bool _power = false;
    public string _name;
    
    public DateTime _dateTime;

    public SmartDevice(string name){
        _name = name;
    }

    public void TogglePower(){
        if (_power==false){
            _power = true;
            _dateTime = DateTime.Now;
        }

        if (_power==true){
            _power = false;
        }
    }

    public bool GetPower(){
        return _power;
    }



    
}