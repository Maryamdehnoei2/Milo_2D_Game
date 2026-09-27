using UnityEngine;

public class DiamondCollision : MonoBehaviour
{
    [SerializeField] private DiamondManager diamondManager;

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
            Destroy(gameObject);
        }    
    }
}
