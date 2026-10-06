using UnityEngine;

public class DiamondCollision : MonoBehaviour
{
    [SerializeField] private DiamondManager diamondManager;
    [SerializeField] private AudioClip diamondSound;

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
            diamondManager.AddDiamond();
            AudioSource.PlayClipAtPoint(diamondSound, transform.position);
            Destroy(gameObject);
        }    
    }
}
