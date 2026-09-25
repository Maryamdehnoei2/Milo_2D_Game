using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveInput;
    [SerializeField] private Rigidbody2D rigidbodyP;
    [SerializeField] private float speed;
    [SerializeField] private Animator animatorP;
    [SerializeField] private bool isUp;
    [SerializeField] private bool isFall;
   

    void Update()
    {
        InputKey();
    }


    private void FixedUpdate()
    {
        PlayerMove();
    }
    private void InputKey()
    {
        moveInput = Input.GetAxis("Vertical");

    }

    private void PlayerMove()
    {
        rigidbodyP.linearVelocity = new Vector2(speed - 2, moveInput * speed);
        isUp = moveInput > 0;
        isFall = moveInput < 0;
        animatorP.SetBool("IsUp", isUp);
        animatorP.SetBool("IsFall", isFall);
    }
}
