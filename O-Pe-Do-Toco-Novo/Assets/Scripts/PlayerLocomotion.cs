using UnityEngine;

//Simple movement, without using InputSystem
[RequireComponent(typeof(CharacterController))]
public class PlayerLocomotion : MonoBehaviour
{
    private CharacterController characterController;
    public float speed = 8.0f;
    public Vector3 movement;

    public void Start(){
        characterController = gameObject.GetComponent<CharacterController>();
    }

    public void Update(){
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //normalize vector

        if(movement.magnitude > 0.1f){
            transform.forward = movement; 
            characterController.Move(movement * speed * Time.deltaTime);
        }
    }
}
