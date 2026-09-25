using UnityEngine;

public class Jellyfish : MonoBehaviour
{
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private float speedJellyfish;
    [SerializeField] private float moveDistanse = 5;
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
        float movement=Mathf.PingPong(Time.time*speedJellyfish,moveDistanse);
        transform.position=startPosition+Vector3.up*movement;
    }
}
