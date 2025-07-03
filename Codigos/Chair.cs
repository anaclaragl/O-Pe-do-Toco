public class Chair
{
    public bool isOccupied { get; private set; }
    
    public void Occupy()
    {
        isOccupied = true;
    }
    
    public void Vacate()
    {
        isOccupied = false;
    }
}