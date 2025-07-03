using UnityEngine;

public class ChairManager : MonoBehaviour{
    public Chair[] chairs;

    public Start(){
        chairs = GameObject.GetComponents<Chair>();
    }
}