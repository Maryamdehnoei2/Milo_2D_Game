using UnityEngine;
using UnityEngine.UIElements;

public class SharkChase : MonoBehaviour
{
    [SerializeField] private Transform transformPlayer;
    [SerializeField] private float speed = 2f;
    [SerializeField] private bool isFishInRange = false;
    [SerializeField] private SpriteRenderer sharkSprite;

    void Update()
    {
        Follow();
    }
    private void Follow()
    {
        if (isFishInRange)
        {
            if (transformPlayer.position.x < transform.parent.position.x)
            {
                sharkSprite.flipX = true;
            }
            else
            {
                sharkSprite.flipX = false;
            }
            Vector3 targetPosition = new Vector3(transformPlayer.position.x, transform.parent.position.y, transform.parent.position.z);
            transform.parent.position = Vector3.MoveTowards(transform.parent.position, targetPosition, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isFishInRange = true;
            transform.parent.GetComponent<Shark>().isChase = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isFishInRange = false;
            transform.parent.GetComponent<Shark>().isChase = false;
        }
    }
}
