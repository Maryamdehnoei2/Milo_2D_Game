using UnityEngine;

public class JellyfishCollision : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private AudioSource jellyfishSound;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

   
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Jellyfish"))
        {
            playerHealth.Damage();
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("JellyfishHead"))
        {
            Destroy(collision.transform.parent.gameObject);
        }
    }

}
