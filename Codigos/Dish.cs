using UnityEngine;
public enum DietType{ CARNIVORE, HERBIVORE };

[CreateAssetMenu(menuName = "Dish")]
public class Dish : ScriptableObject
{

    [Header("Item Description")]
    public string plateName;
    [TextArea(10,10)]
    public int price; //we can change it to float later
    public float preparationTime;
    public DietType dietType;

    public GameObject[] ingredients;
}