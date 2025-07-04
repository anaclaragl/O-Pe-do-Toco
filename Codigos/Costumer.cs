using UnityEngine;
using UnityEngine.AI;

public class Costumer : MonoBehaviour{
    DietType dietType;
    Order order;
    Sprite[] satisfactionIcons;
    Sprite balloonIcon;
    Vector3 balloonPosition;
    int randomChair;

    NavMeshAgent agent;
    ChairManager chairManager;
    Chair chair;

    public void Start(){
        agent = GetComponent<NavMeshAgent>();
        SetChairDestination();
    }

    public Order PlaceOrder(){
        order = OrderManager.instance.PlaceOrder(dietType, this);
        return order;
    }

    public void SetChairDestination(){
        chair = chairManager.chairs[Random.Range(0, chairManager.chairs.Lenght)]
        agent.destination = chair.transform.position;
        chair.Occupy();
    }

    public Sprite CheckOrderSatisfaction(Order _order){
        int score = 0; //defines how much the costumer will pay
        //2 = full price, 1 = half, 0 = 0
        
        if(order.dish.dietType == _order.dish.dietType){
            score++;
        }
        if(order.dish.plateName == _order.dish.plateName){
            score++;
        }

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
