using UnityEngine;

public class ChairManager : MonoBehaviour
{
    public Chair[] chairs;

    public void Awake()
    {
        chairs = GameObject.FindObjectsOfType<Chair>();
    }
}