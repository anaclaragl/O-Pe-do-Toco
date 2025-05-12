using UnityEngine;

public class OrderManager : MonoBehaviour{
    public Dish[] carnivoreDishes;
    public Dish[] herbivoreDishes;
    public Dish chosenDish;
    public int randomDish;
    Action OnNewOrder;
    Action OnDeliveredOrder;

    //on new order{ ui ativa, espera ativa }
    //on entregue{ ui desativa, comer ativa, satisfacao ativa, dinheiro, embora }

    public Order PlaceOrder(DietType dietType, Costumer costumer){
        if(dietType == dietType.CARNIVORE){
            chosenDish = carnivoreDishes[Random.Range(0, carnivoreDishes.Lenght)];
        }else{
            chosenDish = herbivoreDishes[Random.Range(0, herbivoreDishes.Lenght)];
        }
        return new Order(chosenDish, costumer);
    }
}