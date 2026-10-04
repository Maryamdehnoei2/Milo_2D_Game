using Unity.VisualScripting;
using UnityEngine;

public class HookMovement : MonoBehaviour
{

    [SerializeField] private Vector3 startPosition;
    [SerializeField] private float speed;
    [SerializeField] private float moveDistanse = 3;
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float movement=Mathf.PingPong(Time.time*speed, moveDistanse);
        transform.position=startPosition+Vector3.up*movement;
    }
}
