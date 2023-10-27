// See https://aka.ms/new-console-template for more information
public class Elevator
{
    private int _NFloor;
    private bool _doorOpen = true;
    private List<int> _floors;

    public Elevator(int NFloor, bool doorOpen, int numberFloors)
    {
        _floors = new List<int>();
        _NFloor = NFloor;
        for(int i = 1; i <= numberFloors; i++)
           {
            _floors.Add(i);
           }
    }

    public List<int>GetList()
    {
        return _floors;
    }
    public bool doorClose()
    {
        return false;
    }

    public bool doorOpen()
    {
        return true;
    }

    public void ListAvailable()
    {
        for (int i = 0; i < _floors.Count; i++)
        {
            if(i != _NFloor)
            {
                Console.WriteLine(i);
            }
        }
    }

    public void DisplayFloor()
    {
        Console.WriteLine($"Floor: {_NFloor}");
    }
}
