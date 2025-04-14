using UnityEngine;
using UnityEngine.InputSystem;

//Simple movement, without using InputSystem
[RequireComponent(typeof(CharacterController))]
public class PlayerLocomotion : MonoBehaviour
{
    private CharacterController characterController;
    public float speed = 8.0f;
    public Vector3 movement;
    Vector2 input;

    public void Start(){
        characterController = gameObject.GetComponent<CharacterController>();
    }

    public void Update(){
        Movement();
    }

    public void Move(InputAction.CallbackContext context){
        input = context.ReadValue<Vector2>();
        movement = new Vector3(input.x, 0, input.y);
    }

    private void Movement(){
        if(movement.magnitude > 0.1){
            transform.forward = movement; 
        }
        characterController.Move(movement * speed * Time.deltaTime);
    }
}
