using UnityEngine;

public class Chair : MonoBehaviour
{
    public bool isOccupied;
    
    public void Occupy()
    {
        isOccupied = true;
    }
    
    public void Vacate()
    {
        isOccupied = false;
    }
}