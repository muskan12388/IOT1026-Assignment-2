namespace Assignment
{


public class Chest
{
    private enum ChestState
    {
        Locked,
        Closed,
        Opened
    }
   //stating treasurechest menu
    private ChestState _state;
    private string _material;
    private string _lockType;
    private string _lootQuality;


 // treasurechest material and its properties
    public Chest()
    {
        _material = "iron";
        _lockType = "Standard";
        _lootQuality = "Common";
        _state = ChestState.Locked;
    }
    
    public Chest(string material, string lockType, string lootQuality)
    {
        _material = material;
        _lockType = lockType;
        _lootQuality = lootQuality;
        _state = ChestState.Locked;
    }
 //unlocking the chest if its not
    private void Unlock()
    {
        if (_state == ChestState.Locked)
        {
            Console.WriteLine("Unlocking the chest...");
            _state = ChestState.Closed;
        }
        else
        {
            Console.WriteLine("Invalid action: The chest is already unlocked.");
        }
    }


 //locking the chest
    private void Lock()
    {
        if (_state == ChestState.Closed)
        {
            Console.WriteLine("Locking the chest...");
            _state = ChestState.Locked;
        }
        else
        {
            Console.WriteLine("Invalid action: The chest is already locked.");
        }
    }


   //opening the chest
    private void Open()
    {
        if (_state == ChestState.Closed)
        {
            Console.WriteLine("Opening the chest...");
            _state = ChestState.Opened;
        }
        else
        {
            Console.WriteLine("Invalid action: The chest is already open.");
        }
    }

    //closing the chest

    private void unlocked()
    {
        if (_state == ChestState.Opened)
        {
            Console.WriteLine("closing the chest...");
            _state = ChestState.Closed;
        }
        else
        {
            Console.WriteLine("Invalid action: The chest is already closed.");
        }
    }
    

    //manipulating actions
    public string Manipulate(Action<Chest> action)
    {
        action(this);
        return _state.ToString();
    }

    public override string ToString()
    {
        return $"Material: {_material}, Lock Type: {_lockType}, Loot Quality: {_lootQuality}, State: {_state}";
    }

    public static void Main(string[] args)
    {
        Chest chest = new Chest("iron", "standard", "common");
        Console.WriteLine(chest);

        chest.Manipulate(c => c.Unlock());
        Console.WriteLine(chest);

        chest.Manipulate(c => c.Open());
        Console.WriteLine(chest);

        chest.Manipulate(c => c.Close());
        Console.WriteLine(chest);

        chest.Manipulate(c => c.Lock());
        Console.WriteLine(chest);
    }

        private void Close()
        {
            throw new NotImplementedException();
        }
    }
}