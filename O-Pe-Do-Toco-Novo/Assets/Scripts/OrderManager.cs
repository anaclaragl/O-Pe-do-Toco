using UnityEngine;
using UnityEngine.Events;

public class OrderManager : MonoBehaviour{
    public Dish[] carnivoreDishes;
    public Dish[] herbivoreDishes;
    public Dish chosenDish;
    UnityEvent OnNewOrder;
    UnityEvent OnDeliveredOrder;

    public Order PlaceOrder(DietType dietType, Customer customer){
        if(dietType == DietType.CARNIVORE){
            chosenDish = carnivoreDishes[Random.Range(0, carnivoreDishes.Length)];
        }else{
            chosenDish = herbivoreDishes[Random.Range(0, herbivoreDishes.Length)];
        }
        return new Order(chosenDish, customer);
    }
}