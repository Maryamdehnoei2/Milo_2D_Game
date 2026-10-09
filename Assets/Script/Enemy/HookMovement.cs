using Unity.VisualScripting;
using UnityEngine;

public class HookMovement : MonoBehaviour
{

    [SerializeField] private Vector3 startPosition;
    [SerializeField] private float speed;
    [SerializeField] private float moveDistanse = 3;
    [SerializeField] private Hook hook;
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if(hook.IsFishCaught)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else
        {
            Movement();
        }
       
    }

    void Movement()
    {
        float movement=Mathf.PingPong(Time.time*speed, moveDistanse);
        transform.position=startPosition+Vector3.up*movement;
    }
}
