using Unity.VisualScripting;
using UnityEngine;

public class Shark : MonoBehaviour
{
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private float speedShark;
    [SerializeField] private float moveDistanse=15;
    [SerializeField] private SpriteRenderer sharkSprite;
    private float previousMovement;
    void Start()
    {
        startPosition=transform.position;
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float movement=Mathf.PingPong(Time.time*speedShark, moveDistanse);
        transform.position=startPosition+Vector3.left*movement;

        if(movement>previousMovement)
        {
            sharkSprite.flipX = true;
        }
        else if(movement<previousMovement)
        {
            sharkSprite.flipX = false;
        }
        previousMovement = movement;
    }

}
