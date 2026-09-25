using UnityEngine;

public class PearlCollision : MonoBehaviour
{
    [SerializeField] private PearlManager pearlManager;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {

            pearlManager.AddPearl();
            Destroy(gameObject);
        }
    }
}
