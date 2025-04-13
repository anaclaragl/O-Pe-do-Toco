using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public PlayerLocomotion playerLocomotion;

    public void Start(){
        animator = GetComponentInChildren<Animator>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
    }

    public void Update(){
        animator.SetFloat("Magnitude", playerLocomotion.movement.magnitude);
    }
}
