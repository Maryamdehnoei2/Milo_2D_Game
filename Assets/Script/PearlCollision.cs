using UnityEngine;

public class PearlCollision : MonoBehaviour
{
    [SerializeField] private PearlManager pearlManager;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {

            pearlManager.AddPearl();
            Destroy(gameObject);
        }
    }
}
