using UnityEngine;

[CreateAssetMenu(menuName = "Order")]
public class Order : ScriptableObject
{
    private enum dietType{ Carnivore, Herbivore };

    [Header("Item Description")]
    public string plateName;
    [TextArea(10,10)]
    public int price; //we can change to float later

    public GameObject[] ingredients;
}
