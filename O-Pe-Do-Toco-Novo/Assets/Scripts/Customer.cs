using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class Customer : MonoBehaviour{
    [Header("Dish data")]
    public DietType dietType;
    public Order order;
    public Sprite[] satisfactionIcons;
    public Sprite balloonIcon;
    public Vector3 balloonPosition;
    public OrderManager orderManager;
    
    [Header("AI data")]
    public NavMeshAgent agent;
    public ChairManager chairManager;
    public Chair chair;
    public Transform exit;



    public enum State{
        WALKING, //entering and leaving
        IDLE, //waiting
        EATING
    }
    public State state;

    public void Start(){
        state = State.WALKING;
        agent = GetComponent<NavMeshAgent>();
        chair = chairManager.chairs[0];
        SetChairDestination();
    }

    public Order PlaceOrder(){
        order = orderManager.PlaceOrder(dietType, this);
        return order;
    }

    public void SetChairDestination(){
        //will do somenthing to prevent same random number and stop
        //new customers until a seat is free
        chair = chairManager.chairs[Random.Range(0, chairManager.chairs.Length)];
        agent.destination = chair.transform.position;
        chair.Occupy();
    }

    public void Sit(){
        state = State.IDLE;
    }

    public void Eat(){
        state = State.EATING;
    }

    public Sprite CheckOrderSatisfaction(Order _order){
        int score = 0; //defines how much the Customer will pay
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
            default:
                Debug.Log("$0");
                return satisfactionIcons[0];
        }
    }

    public void Leave(){
        PopUpSatisfaction();
        StartCoroutine("WalkAway");
    }

    public void PopUpSatisfaction(){

    }

    IEnumerator WalkAway(){
        yield return new WaitForSeconds(2f);
        state = State.WALKING;
        agent.destination = exit.position;
    }
}
