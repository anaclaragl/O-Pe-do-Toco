using UnityEngine;

public class Costumer : MonoBehaviour{
    DietType dietType;
    Order order;
    Sprite[] satisfactionIcons;
    Sprite balloonIcon;
    Vector3 balloonPosition;

    public void Start(){
        order = OrderManager.instance.PlaceOrder(dietType, this);
    }

    public bool CanOrder(Dish dish){
        return dish.dietType == dietType;
    }

    public Sprite CheckOrderSatisfaction(Order order){
        int score = 0; //defines how much will the costumer pay 
        //2 = full price, 1 = half, 0 = 0

        //if dietType correct = score++
        //if dish correct = score++

        switch(score){
            case 2:
                Debug.Log("$100");
                return satisfactionIcons[2];
                break;
            case 1:
                Debug.Log("$50");
                return satisfactionIcons[1];
                break;
            case 0:
                Debug.Log("$0");
                return satisfactionIcons[0];
                break;
        }
    }
}